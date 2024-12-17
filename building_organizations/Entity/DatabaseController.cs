using Newtonsoft.Json;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace building_organizations.Entity
{
    
    public class DatabaseController
    {
        private string jsonFilePath = "C:\\Users\\serov\\source\\repos\\building_organizations\\building_organizations\\Entity\\Tables.json";
        private string sqlCon = "Server=localhost;Port=5432;Database=building_constraction;User id = postgres; Password=1234;";
        private NpgsqlConnection sqlConnection;
        private NpgsqlDataReader reader;
        private string jsonContent;
        public DatabaseController() {
            sqlConnection = new NpgsqlConnection(sqlCon);
            sqlConnection.Open();
            jsonContent = File.ReadAllText(jsonFilePath);
        }
        public void Update(string tablename, string[] update,int id)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            dynamic tables = JsonConvert.DeserializeObject(jsonContent);
            string sql = $"UPDATE {tablename} ";
            int i = 0;
            string idparam = "@idparam";
            string Where =$" WHERE id = {idparam};";
            command.Parameters.AddWithValue(idparam, id);
            try {
                foreach(var table in tables)
                {
                    if (table.table_name == tablename) {
                        var columns = table.columns;
                        var lastcolum = columns.Last;
                        foreach (var column in table.columns)
                        {
                            
                            if (column.primary_key != null)
                            {
                                continue;
                            }
                            if(update[i] == "" || update[i] == " ")
                            {
                                i++;
                                continue;
                            }
                            if (column.references != null)
                            {
                                var refer = column.references;
                                string paramname = $"@param{i}";
                                sql += $"SET {column.column_name} = {paramname} ";
                                int? ids = FindIdByType(refer.table,  refer.replace_with, update[i]);
                                if (!ids.HasValue)
                                {
                                    MessageBox.Show("No ID found.");
                                }

                                command.Parameters.AddWithValue(paramname, ids);
                            }
                            else
                            {
                                string paramname = $"@param{i}";
                                sql += $"SET {column.column_name} = {paramname}";
                                object r = ReturnType(column.type,update[i]);
                                command.Parameters.AddWithValue(paramname, r);
                            }
                            if (column != lastcolum)
                            {
                                sql += ", ";
                            }
                            i++;
                        }   
                    }
                }
                
                sql += Where;
                
            }
            catch (Exception ex) { }
        }
        public void Delete(string tablename, string column, string data) {
            string sql = $"DELETE FROM {tablename} WHERE {column} = {data};";
        }
        public void Delete(string tablename, int id) {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            string sql = $"DELETE FROM {tablename} WHERE id = @id;";
            
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = sql;
            command.ExecuteNonQuery();
            command.Dispose();
        }
        //запись в таблицу
        public string[]? Select(string tablename,DataGridView d)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            List<string> columnNames = new List<string>();
            try
            {
                dynamic tables = JsonConvert.DeserializeObject(jsonContent);
                string sql ="";
                foreach (var table in tables)
                {
                    if(table.table_name == tablename)
                    {
                        var columns = table.columns;
                        var lastcolum = columns.Last;
                        sql = $"SELECT ";
                        
                        foreach (var column in table.columns)
                        {
                            if (column.references != null)
                            {
                                var refer = column.references;
                                sql += $"{refer.table}.{refer.replace_with} AS {column.lname}";
                            } else {
                                if (column.primary_key == null) sql += $"{table.table_name}.{column.column_name} AS \"{column.lname}\"";
                                else sql += $"{table.table_name}.{column.column_name}";
                            }
                            if (column != lastcolum)
                            {
                                sql += ", ";
                            }
                        }
                        sql += $" FROM {table.table_name} ";
                        foreach (var column in columns)
                        {
                            if (column.references != null)
                            {
                                var refer = column.references;
                                sql += $" JOIN {refer.table} ON {refer.table}.id = {table.table_name}.{column.column_name} ";
                            }
                        }
                        sql += ";";
                    }
                }
                MessageBox.Show(sql);
                command.CommandText = sql;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        d.DataSource = dt;
                    }
                }
                return columnNames.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}");
                return null;
            }
            finally
            {
                command.Dispose();
            }

        }
        //Превращение нужного объекта в нужный тип данных с помощью типа данных написаного в .json файле.
        public object ReturnType(string obj, string name) {
            object ob  = null;
            switch (obj)
            {
                case "integer":
                    ob = Convert.ToInt32(name);
                    break;
                case "text":
                    ob = name;
                    break;
                case "date":
                    ob = Convert.ToDateTime(name);
                    break;
                case "boolean":
                    ob = Convert.ToBoolean(name);
                    break;
                case "double":
                    ob = Convert.ToDouble(name);
                    break;
                default:
                    throw new Exception($"Unsupported type: ");
            }
            return ob;
        }
        //функция добавления в таблицу
        public void Add(string[] data, string tablename) {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            dynamic tables = JsonConvert.DeserializeObject(jsonContent);
            string sql = $"INSERT INTO {tablename} (";
            try
            {
                
                foreach (var table in tables)
                {
                    if (table.table_name == tablename)
                    {
                        var columns = table.columns;
                        var lastcolum = columns.Last;
                        string minizapros = " ";
                        foreach (var column in table.columns)
                        {
                            minizapros = column.column_name;
                            if (column != lastcolum)
                            {
                                minizapros += ", ";
                            }
                            sql += minizapros;
                        }
                        sql += ") VALUES (";
                        int i = 0;

                        foreach (var column in table.columns)
                        {
                            if (column.references != null)
                            {
                                var refer = column.references;

                                string paramname = $"@param{i}";
                                sql += paramname;

                                if (column != lastcolum)
                                {
                                    sql += ", ";
                                }
                                string rtable = refer.table != null ? refer.table.ToString() : "";
                                string Replece = refer.replace_with != null ? refer.replace_with.ToString() : "";
                                int? id = FindIdByType(rtable, Replece, data[i]);
                                if (!id.HasValue)
                                {
                                    MessageBox.Show("No ID found.");
                                }

                                command.Parameters.AddWithValue(paramname, id);
                            }
                            else
                            {
                                string paramname = $"@param{i}";
                                sql += paramname;

                                if (column != lastcolum)
                                {
                                    sql += ", ";
                                }
                                string columnType = column.type != null ? column.type.ToString() : "";
                                object r = ReturnType(columnType, data[i]);
                                command.Parameters.AddWithValue(paramname, r);
                            }
                            i++;

                        }
                        sql += ");";
                    }
                }

                command.CommandText = sql;
                command.ExecuteNonQuery();
                command.Dispose();

            }catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
        //функция для поиска внешнего ключа по типу данных которым заменяется сам внешний ключ
        public int? FindIdByType(string tablename, string columnName, object value)
        {
            using (var command1 = new NpgsqlCommand())
            {
                command1.Connection = sqlConnection;

                command1.CommandText = $"SELECT id FROM {tablename} WHERE {columnName} = @value";

                command1.Parameters.AddWithValue("@value", value);

                using (var reader = command1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32(0); 
                    }
                }
            }
            return null;
        }
        //функция для свободных Select запросов
        public void QueryTool(string sql, DataGridView dataGridView)
        {
            bool result = sql.Contains("SELECT");
            if (result)
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                DataTable dt = new DataTable();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                        dataGridView.DataSource = dt;
                    }
                }
                command.Dispose();
            }
            else {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.ExecuteReader();
                command.Dispose(); 
            }

        }
        //создание пользователя
        public void CreateUser(string username, string password, string role)
        {
            NpgsqlCommand command = new NpgsqlCommand();

            string sq = "INSERT INTO users (usernames, passwords, roles) VALUES (@username, @password, @role);";


            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = sq;

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@role", role);

            command.ExecuteNonQuery();  
        }
        //Вход пользователя в программу
        public bool AuthenticateUser(string username, string password,user us)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            string sq = "SELECT id,usernames, passwords, roles FROM users WHERE usernames = @username;";

            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = sq;

            
            command.Parameters.AddWithValue("@username", username);

            
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read()) 
                {
                    string storedPassword = reader["passwords"].ToString();
                    string storedRole = reader["roles"].ToString();
                    int id = Convert.ToInt32(reader["id"]);
                    us.id = id;
                    us.username = username;
                    us.password = password;
                    us.role = storedRole;

                    if (HashingPassword.VerifyPassword(password, storedPassword))
                    {
                        MessageBox.Show($"Authentication successful. Role: {storedRole}");
                        return (true);
                    }
                    else
                    {

                        MessageBox.Show("Authentication failed. Incorrect password.");
                        return false;
                    }
                }
                else
                {
                   
                    MessageBox.Show("Authentication failed. User not found.");
                    return false;
                }
            }
        }
        

    }
}
