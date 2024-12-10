using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace building_organizations
{
    public partial class TableWindow : Form
    {
        string sqlCon = "Server=localhost;Port=5432;Database=building_constraction;User id = postgres; Password=1234;";
        public TableWindow()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void sqlConnection()
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(sqlCon);
            sqlConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT*FROM employees";
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }
            command.Dispose();

            sqlConnection.Close();
        }
    }
}
