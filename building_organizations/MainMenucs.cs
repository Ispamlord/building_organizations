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
        private bool isEdit = false;
        public MainMenucs(user us)
        {
            this.us = us;
            InitializeComponent();
            databaseController = new DatabaseController();
            dataGridView1.ReadOnly = false;
            isEditRedactor();

        }
        public void isEditRedactor()
        {
            if (us.role == "admin")
            {
                isEdit = true;
                return;
            } else if (us.role == "viewer")
            {
                isEdit = false;
            }
            else {
                switch (tablename) {
                    case "brigade":
                    case "workers":
                    case "work_on_object":
                    case "workers_brigade":
                    case "specialization_workers":
                    case "request":
                    case "brigade_on_object":
                        isEdit = true;
                        break;
                    default:
                        isEdit = false;
                        break;
                }
            } 
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
            isEditRedactor();
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
            isEditRedactor();
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
            isEditRedactor();
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
            isEditRedactor();
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
            isEditRedactor();
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
            isEditRedactor();
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
            isEditRedactor();
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
            isEditRedactor();
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
            isEditRedactor();
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
                    if (isEdit)
                    {
                        AddForm addForm = new AddForm(tablename);
                        addForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно прав");
                    }
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
                    if (isEdit)
                    {
                        UpdateForm editForm = new UpdateForm(tablename);
                        editForm.Show();
                    }
                    else {
                        MessageBox.Show("Недостаточно прав");
                    }
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
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
                    if (isEdit)
                    {
                        databaseController.Delete(tablename, Convert.ToInt32(textBox1.Text));
                        databaseController.Select(tablename, dataGridView1);
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно прав");
                    }
                }
            }

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
            isEditRedactor();
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
            isEditRedactor();
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
            isEditRedactor();
        }

        private void DocumentToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void tablepromToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void работаНаОбъектеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databaseController.Select("work_on_object", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "work_on_object";
            isEditRedactor();
        }

        private void AProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aboutprogram aboutprogram = new Aboutprogram();
            aboutprogram.Show();

        }

        private void SoderzhanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\serov\source\repos\building_organizations\building_organizations\Entity\Содержание.html"; // Укажите путь к вашему HTML-файлу

            if (File.Exists(filePath))
            {
                // Показать HTML в новом окне
                ShowHtmlInWebBrowser(filePath);
            }
        }
        private void ShowHtmlInWebBrowser(string filePath)
        {
            // Создаем окно для отображения HTML
            Form htmlWindow = new Form
            {
                Text = "HTML Viewer",
                Width = 800,
                Height = 600
            };

            // Добавляем компонент WebBrowser
            WebBrowser webBrowser = new WebBrowser
            {
                Dock = DockStyle.Fill,
                Url = new Uri(filePath) // Устанавливаем путь к HTML-файлу
            };

            htmlWindow.Controls.Add(webBrowser);

            // Показываем окно
            htmlWindow.ShowDialog();
        }
        private void бригадаИОбъектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databaseController.Select("brigade_on_object", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "brigade_on_object";
            isEditRedactor();
        }

        private void специализацияИРабочиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databaseController.Select("specialization_workers", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "specialization_workers";
            isEditRedactor();
        }

        private void RequestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            databaseController.Select("request", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "request";
            isEditRedactor();
        }

        private void бригадРабочиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databaseController.Select("workers_brigade", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "workers_brigade";
            isEditRedactor();
        }

        private void материалыИОбъектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databaseController.Select("building_materials_object", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "building_materials_object";
            isEditRedactor();
        }

        private void поставкаПоставщикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databaseController.Select("delivery_suplplier", dataGridView1);
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.HeaderText);
            }
            tablename = "delivery_suplplier";
            isEditRedactor();
        }
    }
}
