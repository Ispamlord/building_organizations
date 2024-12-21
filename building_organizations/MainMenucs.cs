using building_organizations.Entity;
using building_organizations.SettingForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace building_organizations
{
    public partial class MainMenucs : Form
    {
        private DatabaseController databaseController;
        private user us;
        private string tablename = "";
        public MainMenucs(user us)
        {
            this.us = us;
            InitializeComponent();
            databaseController = new DatabaseController();
            dataGridView1.ReadOnly = false;

        }

        public void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (us.role == "admin")
            {
                QueryToolWindow qq = new QueryToolWindow();
                qq.Show();
            }
            else
            {
                MessageBox.Show("Недостаточно прав");
            }
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databaseController.Select("city", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "city";
        }

        private void changeRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void delivery_Click(object sender, EventArgs e)
        {
            databaseController.Select("delivery", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "delivery";
        }

        private void bank_Click(object sender, EventArgs e)
        {
            databaseController.Select("bank", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "bank";
        }


        private void Street_Click(object sender, EventArgs e)
        {
            databaseController.Select("street", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "street";

        }

        private void work_type_Click(object sender, EventArgs e)
        {
            databaseController.Select("work_type", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "work_type";
        }

        private void brigade_Click(object sender, EventArgs e)
        {
            databaseController.Select("brigade", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "brigade";
        }

        private void workers_Click(object sender, EventArgs e)
        {

            databaseController.Select("workers", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "workers";
        }

        private void unit_of_measurement_Click(object sender, EventArgs e)
        {
            databaseController.Select("unit_of_measurement", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "unit_of_measurement";
        }

        private void specialization_Click(object sender, EventArgs e)
        {
            databaseController.Select("specialization", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "specialization";
        }

        private void work_on_object_Click(object sender, EventArgs e)
        {

        }

        private void сменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForms changeForms = new ChangeForms(us);
            changeForms.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (us.role == "viewer")
            {
                MessageBox.Show("Недостаточно прав");
            }
            else
            {
                if (tablename == "")
                {
                    MessageBox.Show("Выберите сначала таблицу!");
                }
                else
                {
                    AddForm addForm = new AddForm(tablename);
                    addForm.Show();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (us.role == "viewer")
            {
                MessageBox.Show("Недостаточно прав");
            }
            else
            {
                if (tablename == "")
                {
                    MessageBox.Show("Выберите сначала таблицу!");
                }
                else
                {
                    UpdateForm editForm = new UpdateForm(tablename);
                    editForm.Show();
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (us.role == "viewer")
            {
                MessageBox.Show("Недостаточно прав");
            }
            else
            {
                if (tablename == "")
                {
                    MessageBox.Show("Выберите сначала таблицу!");
                }
                else
                {
                    databaseController.Find(comboBox1.Text, tablename, textBox1.Text, dataGridView1);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (us.role == "viewer")
            {
                MessageBox.Show("Недостаточно прав");
            }
            else
            {
                if (tablename == "")
                {
                    MessageBox.Show("Выберите сначала таблицу!");
                }
                else
                {
                    databaseController.Delete(tablename, Convert.ToInt32(textBox1.Text));
                }
            }

        }

        private void work_on_object_Click_1(object sender, EventArgs e)
        {

        }

        private void Supplyer_Click(object sender, EventArgs e)
        {
            databaseController.Select("supplier", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "supplier";
        }

        private void Bulding_materials_Click_1(object sender, EventArgs e)
        {
            databaseController.Select("building_materials", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "building_materials";
        }

        private void объектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databaseController.Select("object", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "object";
        }
    }
}
