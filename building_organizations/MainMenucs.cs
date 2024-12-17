using building_organizations.Entity;
using building_organizations.EntityForms;
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

namespace building_organizations
{
    public partial class MainMenucs : Form
    {
        private DatabaseController databaseController;
        private user us;
        private bool isAbsolute = false;
        private bool isEditor = false;
        private bool isViewer = false;
        private string tablename;
        public MainMenucs(user us)
        {
            this.us = us;
            InitializeComponent();
            databaseController = new DatabaseController();
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = true; // Разрешить добавлять строки
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke; // Включить режим редактирования

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
            tablename = "delivery";
        }

        private void bank_Click(object sender, EventArgs e)
        {
            databaseController.Select("bank", dataGridView1);
            tablename = "bank";
        }

        private void Supply_Click(object sender, EventArgs e)
        {
            databaseController.Select("supplier", dataGridView1);
            tablename = "supplier";
        }
        private void Street_Click(object sender, EventArgs e)
        {
            databaseController.Select("street", dataGridView1);
            tablename = "street";

        }

        private void Bulding_materials_Click(object sender, EventArgs e)
        {
            databaseController.Select("building_materials", dataGridView1);
            tablename = "building_materials";
        }

        private void work_type_Click(object sender, EventArgs e)
        {
            databaseController.Select("work_type", dataGridView1);
            tablename = "work_type";
        }

        private void brigade_Click(object sender, EventArgs e)
        {
            databaseController.Select("brigade", dataGridView1);
            tablename = "brigade";
        }

        private void workers_Click(object sender, EventArgs e)
        {

            databaseController.Select("workers", dataGridView1);
            tablename = "workers";
        }

        private void unit_of_measurement_Click(object sender, EventArgs e)
        {
            databaseController.Select("unit_of_measurement", dataGridView1);
            tablename = "unit_of_measurement";
        }

        private void specialization_Click(object sender, EventArgs e)
        {
            databaseController.Select("specialization", dataGridView1);
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
            AddForm addForm = new AddForm(tablename);
            addForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateForm editForm = new UpdateForm();
            editForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            databaseController.Delete(tablename, Convert.ToInt32(textBox1.Text));
        }

    }
}
