using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace building_organizations.Entity
{
    public class DatabaseController
    {
        private string sqlCon = "Server=localhost;Port=5432;Database=building_constraction;User id = postgres; Password=1234;";
        private NpgsqlConnection sqlConnection;
        private NpgsqlCommand command;
        NpgsqlDataReader reader;
        public DatabaseController() {
            sqlConnection = new NpgsqlConnection(sqlCon);
            sqlConnection.Open();
            command = new NpgsqlCommand();
        }
        public void SetRole(string role) { 
            
        }
        public void CreateUser(string username, string password, string role)
        {

            string sq = "INSERT INTO users (usernames, passwords, roles) VALUES (@username, @password, @role);";


            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = sq;

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@role", role);

            command.ExecuteNonQuery();  
        }

        
        public bool AuthenticateUser(string username, string password,user us)
        {
            
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
        public void SelectFromDataBase(string select, DataGridView d)
        {
            
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;

            command.CommandText = "Set ROLE manager;" + "Update bank Set name= 'bank'Where id =1";
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                d.DataSource = dt;
            }
            command.Dispose();
        }
        public void UpdatetFromDataBase(string o, string[] arg)
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(sqlCon);
            sqlConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            for (int i=0; i < arg.Length; i++)
            {
                command.CommandText = "UPDATE " + o + arg[i] + ";";
                reader = command.ExecuteReader();
            }
           
            
            command.Dispose();
            sqlConnection.Close();
        }

    }
}
