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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace building_organizations.Entity
{
    
    public class DatabaseController
    {
        private string jsonFilePath = "C:\\Users\\serov\\source\\repos\\building_organizations\\building_organizations\\Entity\\Stetham.json";
        private string sqlCon = "Server=localhost;Port=5432;Database=building_constraction;User id = postgres; Password=1234;";
        private NpgsqlConnection sqlConnection;
        private NpgsqlDataReader reader;
        private string jsonContent;
        public DatabaseController() {
            sqlConnection = new NpgsqlConnection(sqlCon);
            sqlConnection.Open();
            jsonContent = File.ReadAllText(jsonFilePath);
        }
        public void Find(string columna, string tablename, string data, DataGridView d)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            string a = "@where";

            string where = $"WHERE "; 
            try
            {
                dynamic tables = JsonConvert.DeserializeObject(jsonContent);
                string sql = "";
                foreach (var table in tables)
                {
                    if (table.table_name == tablename)
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
                                string s = column.lname.ToString();
                                if (columna == s)
                                {
                                    string rtable = refer.table != null ? refer.table.ToString() : "";
                                    string Replece = refer.replace_with != null ? refer.replace_with.ToString() : "";
                                    string refertype = refer.type != null ? refer.type.ToString() : "";
                                    object rr;
                                    try
                                    {
                                        rr = ReturnType(refertype, data);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show($"Ошибка приведения к типу: {ex.Message}");
                                        return;
                                    }
                                    int? ids = FindIdByType(rtable, Replece, rr);
                                    where += $" {refer.table}.id = {a} ";
                                    command.Parameters.AddWithValue(a, ids);
                                }
                            }
                            else
                            {
                                if (column.primary_key == null) sql += $"{table.table_name}.{column.column_name} AS \"{column.lname}\"";
                                else sql += $"{table.table_name}.{column.column_name}";
                                string s = column.lname.ToString();
                                
                                if (columna == s)
                                {
                                    string columnType = column.type != null ? column.type.ToString() : "";
                                    object r;
                                    try
                                    {
                                        r = ReturnType(columnType, data);
                                    }
                                    catch(Exception ex)
                                    {
                                        MessageBox.Show($"Ошибка приведения к типу: {ex.Message}");
                                        return;
                                    }
                                    if (columnType == "text")
                                    {
                                        string pattern = $"%{data}%";
                                        command.Parameters.AddWithValue(a, pattern);
                                        where += $" {table.table_name}.{column.column_name} LIKE {a} ";
                                    }
                                    else
                                    {
                                        command.Parameters.AddWithValue(a, r);
                                        where += $" {table.table_name}.{column.column_name} = {a} ";
                                    }
                                    
                                }
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
                        sql += where;
                        sql += ";";
                        //MessageBox.Show(sql);
                    }
                }

                command.CommandText = sql;
                using (var reader = command.ExecuteReader())
                {
                    
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        d.DataSource = dt;
                    
                }
            }
            catch (Exception ex) { MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}"); }
            finally { 
                command.Dispose(); 
            }
        }
        public void Update(string tablename, string[] update)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            dynamic tables = JsonConvert.DeserializeObject(jsonContent);
            string sql = $"UPDATE {tablename} SET ";
            int i = 0;
            string idparam = "@idparam";
            string Where =$" WHERE id = {idparam};";
            command.Parameters.AddWithValue(idparam, Convert.ToInt32(update[i]));
            i++;
            int k = 0;
            for (int j = 0; j < update.Length; j++)
            {
                k++;
            }
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
                                sql += $"{column.column_name} = {paramname} ";
                                string rtable = refer.table != null ? refer.table.ToString() : "";
                                string Replece = refer.replace_with != null ? refer.replace_with.ToString() : "";
                                string refertype = refer.type != null ? refer.type.ToString() : "";
                                object rr;
                                try
                                {
                                    rr = ReturnType(refertype, update[i]);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Ошибка приведения к типу: {ex.Message}");
                                    return;
                                }
                                int? ids = FindIdByType(rtable, Replece, rr);
                                
                                command.Parameters.AddWithValue(paramname, ids);
                            }
                            else
                            {
                                string paramname = $"@param{i}";
                                sql += $"{column.column_name} = {paramname} ";
                                string columnType = column.type != null ? column.type.ToString() : "";
                                object r;
                                try
                                {
                                    r = ReturnType(columnType, update[i]);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Ошибка приведения к типу: {ex.Message}");
                                    return;
                                }
                                command.Parameters.AddWithValue(paramname, r);
                            }
                            if (column != lastcolum && k!=2)
                            {
                                sql += ", ";
                                k--;
                            }
                            i++;
                        }   
                    }
                }
                
                sql += Where;
                command.CommandText = sql;
                command.ExecuteNonQuery();
                command.Dispose();

            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }
        public void Delete(string tablename, string column, string data) {
            string sql = $"DELETE FROM {tablename} WHERE {column} = {data};";
        }
        public void Delete(string tablename, int id) {
            try {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                string sql = $"DELETE FROM {tablename} WHERE id = @id;";

                command.Parameters.AddWithValue("@id", id);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                command.Dispose();
                MessageBox.Show("Данные удалены!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                                sql += $"{refer.table}.{refer.replace_with} AS \"{column.lname}\"";
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
                                string refertype = refer.type != null ? refer.type.ToString() : "";
                                object rr = ReturnType(refertype, data[i]);
                                int? ids = FindIdByType(rtable, Replece, rr);
                                

                                command.Parameters.AddWithValue(paramname, ids);
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
            try
            {
                    using (var command = new NpgsqlCommand())
                    {
                        command.Connection = sqlConnection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                        {
                            dataGridView.DataSource = null;

                            var dataTable = new System.Data.DataTable();
                            dataTable.Load(reader);

                            dataGridView.DataSource = dataTable;
                        }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении запроса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //Для 
        public void ChangePass(int id, string password) {
            HashingPassword hashingPassword = new HashingPassword();
            NpgsqlCommand command = new NpgsqlCommand();
            string sq = "UPDATE users SET passwords = @password WHERE id = @id";
            string pass = HashingPassword.HashPassword(password);
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = sq;
            command.Parameters.AddWithValue("@password", pass);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
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
