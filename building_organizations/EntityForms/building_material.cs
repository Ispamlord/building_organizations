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
    public partial class building_material : Form
    {
        DatabaseController database = new DatabaseController();
        public building_material()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] table = { label1.Text, label2.Text , label3.Text, label5.Text};
            string[] join = { "unit_of_measurement" };
            string[] id = { "unit_id" };
            string[] columns = { "name" };
           // database.SelectWithoutId("building_materials", table, join, id, dataGridView1, columns);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                object[] values = { Convert.ToInt32(textBox1.Text), textBox2.Text };
                string[] columns = { label1.Text, label2.Text }; ;
                //database.AddWithReferences()
                //database.Add_to_DataBase("building_materials", values, columns);

                MessageBox.Show("Record added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strings = { label2.Text };
            object[] ob = { textBox2.Text };
            try
            {
                //database.UpdatetFromDataBase("building_materials", strings, textBox1.Text, ob);
            }
            catch
            {
                MessageBox.Show("Invalid building_materials: ");
            }

        }
    }
}
