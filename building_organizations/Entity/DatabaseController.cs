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
                                sql += $"{refer.table}.{refer.replace_with}";
                            } else {
                                sql += $"{table.table_name}.{column.column_name}";
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
            foreach (var table in tables)
            {
                if (table.table_name == tablename)
                {
                    var columns = table.columns;
                    var lastcolum = columns.Last;
                    string minizapros=" ";
                    foreach (var column in table.columns)
                    {
                        minizapros = column.column_name;
                        if (column != lastcolum) {
                            minizapros += ", ";
                        }
                        sql += minizapros; 
                    }
                    sql += ") VALUES (";
                    int i = 0;

                    foreach (var column in table.columns)
                    {
                        if (column.references != null) {
                            var refer = column.references;
                            
                            string paramname = $"@param{i}";
                            sql += paramname;

                            if (column != lastcolum)
                            {
                                sql += ", ";
                            }
                            int? id = FindIdByType(refer.table, refer.type, refer.replace_with, data[i]);
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
                            object r = ReturnType(column.type, data[i]);
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
        }
        //функция для поиска внешнего ключа по типу данных которым заменяется сам внешний ключ
        public int? FindIdByType(string tablename, string columntype, string columnName, object value)
        {
            using (var command1 = new NpgsqlCommand())
            {
                command1.Connection = sqlConnection;

                command1.CommandText = $"SELECT id FROM {tablename} WHERE type = @type AND {columnName} = @value";

                command1.Parameters.AddWithValue("@type", columntype);
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
        public DataTable SelectRawFromDataBase(string select, DataGridView d)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM " + select + ";";

            DataTable dt = new DataTable();
            using (var reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    dt.Load(reader);
                    d.DataSource = dt; 
                }
            }

            command.Dispose();
            return dt; 
        }

        public void Add_to_DataBase(string select, object[] arg, string[] table_arg)
        {

            string query = $"INSERT INTO {select} ({string.Join(", ", table_arg)}) VALUES ({string.Join(", ", table_arg.Select((_, index) => $"@param{index}"))});";

            using (var command = new NpgsqlCommand(query, sqlConnection))
            {
                for (int i = 0; i < arg.Length; i++)
                {
                    command.Parameters.AddWithValue($"@param{i}", arg[i] ?? DBNull.Value);
                }

                using (var reader = command.ExecuteReader())
                {
                }
            }
        }
        public void UpdatetFromDataBase(string select, string[] col_arg, string id, object[] arg)
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(sqlCon);
            sqlConnection.Open();
            string sql = $"UPDATE {select} SET ";
            sql += string.Join(", ", col_arg.Select((col, index) => $"{col} = @param{index}"));
            sql += " WHERE id =" + id + " ;";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, sqlConnection))
            {
                for (int i = 0; i < arg.Length; i++)
                {
                    command.Parameters.AddWithValue($"@param{i}", arg[i] ?? DBNull.Value);
                }

                command.ExecuteNonQuery();
            }
            sqlConnection.Close();
        }
        public void AddWithReferences(
    string tableName,
    Dictionary<string, object> values,
    Dictionary<string, (string referenceTable, string referenceColumn)> references)
        {
            using (var command = new NpgsqlCommand())
            {
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;

                foreach (var reference in references)
                {
                    string key = reference.Key; 
                    string referenceTable = reference.Value.referenceTable; 
                    string referenceColumn = reference.Value.referenceColumn; 

                    if (values.ContainsKey(key)) 
                    {
                        string query = $"SELECT id FROM {referenceTable} WHERE {referenceColumn} = @param_{key}";
                        command.CommandText = query;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue($"@param_{key}", values[key]);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                values[key] = reader.GetInt32(0); 
                            }
                            else
                            {
                                throw new Exception($"Value '{values[key]}' not found in table '{referenceTable}'.");
                            }
                        }
                    }
                }

                string columns = string.Join(", ", values.Keys);
                string parameters = string.Join(", ", values.Keys.Select(k => $"@param_{k}"));
                string insertQuery = $"INSERT INTO {tableName} ({columns}) VALUES ({parameters})";

                command.CommandText = insertQuery;
                command.Parameters.Clear();

                foreach (var kvp in values)
                {
                    command.Parameters.AddWithValue($"@param_{kvp.Key}", kvp.Value);
                }

                command.ExecuteNonQuery();
            }
        }
        public void SelectWithoutId(string select, string[] table_arg, string[] join_agr, string[] id_join,DataGridView d, string[] name_join_arg) {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            try
            {
                
                string sql = "SELECT ";
                sql += string.Join(", ", table_arg);
                for (int i = 0; i < join_agr.Length; i++)
                {
                    sql += ", " + join_agr[i] + "." + name_join_arg[i];
                }
                sql += " FROM " + select + " ";
                for (int i = 0; i < join_agr.Length; i++)
                {
                    sql += $"JOIN {join_agr[i]} ON {join_agr[i]}.id = {select}.{id_join[i]} ";
                }
                sql += ";";
                command.CommandText = sql;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    d.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}");
            }
            finally
            {
                command.Dispose();
            }
        }
        public void Remove(string id)
        {

        }

    }
}
