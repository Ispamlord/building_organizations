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
            if (isAbsolute)
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
            CityForm city = new CityForm();
            switch (us.role)
            {
                case "admin":
                    city.Show();
                    break;
                case "editor":
                    city.Show();
                    break;
                case "viewer":
                    databaseController.SelectRawFromDataBase("city", dataGridView1);
                    break;
            }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            //databaseController.Add_to_DataBase();
        }

        private void delivery_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery();
            switch (us.role)
            {
                case "admin":
                    delivery.Show();
                    break;
                case "editor":
                    delivery.Show();
                    break;
                case "viewer":
                    databaseController.SelectRawFromDataBase("delivery", dataGridView1);
                    break;
            }
        }

        private void bank_Click(object sender, EventArgs e)
        {
            Bank bank = new Bank();
            switch (us.role)
            {
                case "admin":
                    bank.Show();
                    break;
                case "editor":
                    databaseController.SelectRawFromDataBase("bank", dataGridView1);
                    break;
                case "viewer":
                    databaseController.SelectRawFromDataBase("bank", dataGridView1);
                    break;
            }
        }

        private void Supply_Click(object sender, EventArgs e)
        {
            Supplyer supplyer = new Supplyer();
            switch (us.role)
            {
                case "admin":
                    supplyer.Show();
                    break;
                case "editor":
                    databaseController.SelectRawFromDataBase("supplier", dataGridView1);
                    break;
                case "viewer":
                    databaseController.SelectRawFromDataBase("supplier", dataGridView1);
                    break;
            }
        }
        private void Street_Click(object sender, EventArgs e)
        {
            StreetForm streetForm = new StreetForm();
            databaseController.Select("street", dataGridView1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //databaseController.Remove();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //databaseController.UpdatetFromDataBase();
        }

        private void Bulding_materials_Click(object sender, EventArgs e)
        {
            building_material building_Material = new building_material();
            switch (us.role)
            {
                case "admin":
                    building_Material.Show();
                    break;
                case "editor":
                    building_Material.Show();
                    break;
                case "viewer":
                    databaseController.SelectRawFromDataBase("building_materials", dataGridView1);
                    break;
            }
        }

        private void work_type_Click(object sender, EventArgs e)
        {
            Work_type work_type = new Work_type();
            switch (us.role)
            {
                case "admin":
                    work_type.Show();
                    break;
                case "editor":
                    work_type.Show();
                    break;
                case "viewer":
                    databaseController.SelectRawFromDataBase("work_type", dataGridView1);
                    break;
            }
        }

        private void brigade_Click(object sender, EventArgs e)
        {
            Brigade brigade;
            switch (us.role)
            {
                case "admin":
                    brigade = new Brigade();
                    brigade.Show();
                    break;
                case "editor":
                    brigade = new Brigade();
                    brigade.Show();
                    break;
                case "viewer":
                    databaseController.SelectRawFromDataBase("brigade", dataGridView1);
                    break;
            }
        }

        private void workers_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            databaseController.Select("workers", dataGridView1);
        }

        private void unit_of_measurement_Click(object sender, EventArgs e)
        {
            unit_of_measurement un = new unit_of_measurement();
            switch (us.role)
            {
                case "admin":
                    un.Show();
                    break;
                case "editor":
                    un.Show();
                    break;
                case "viewer":
                    databaseController.SelectRawFromDataBase("unit_of_measurement", dataGridView1);
                    break;
            }
        }

        private void specialization_Click(object sender, EventArgs e)
        {
            specialitation un = new specialitation();
            switch (us.role)
            {
                case "admin":
                    un.Show();
                    break;
                case "editor":
                    un.Show();
                    break;
                case "viewer":
                    databaseController.SelectRawFromDataBase("specialization", dataGridView1);
                    break;
            }
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
            //AddForm addForm  = new AddForm();
        }
    }
}
