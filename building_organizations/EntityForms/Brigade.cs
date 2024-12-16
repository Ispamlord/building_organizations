using building_organizations.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace building_organizations.EntityForms
{
    public partial class Brigade : Form
    {
        DatabaseController database = new DatabaseController();
        public Brigade()
        {
            InitializeComponent();
            string[] table = { label2.Text };
            string[] join = { "workers" };
            string[] id = { "brigadir_id" };
            string[] columns = { "last_name" };
            database.SelectWithoutId("brigade", table, join, id, dataGridView1, columns);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //object[] values = { Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text };
                //string[] columns = { label1.Text, label2.Text , label3.Text};
                //Dictionary<string, object> values = new Dictionary<string, object>(){ { "id", Convert.ToInt32(textBox1.Text) }, {"name", textBox2.Text } };
                //Dictionary<string, (string referenceTable, string referenceColumn)> columns = {"",(""",""") };
                //database.AddWithReferences("brigade", values, columns);

                MessageBox.Show("Record added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strings = { label2.Text };
            object[] ob = { textBox2.Text };
            try
            {
                database.UpdatetFromDataBase("brigade", strings, textBox1.Text, ob);
            }

            catch
            {
                MessageBox.Show("Invalid brigade: ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] table = { label1.Text, label2.Text };
            string[] join = { "workers"};
            string[] id = { "brigadir_id" };
            string[] columns = { "last_name" };
            database.SelectWithoutId("brigade",table,join, id, dataGridView1, columns);
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
