using building_organizations.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace building_organizations
{
    public partial class AddForm: Form
    {
        private List<TextBox> textBoxesList = new List<TextBox>();
        private DatabaseController databaseController;
        private string tablename;
        public  AddForm(string tablename)
        {
            this.tablename = tablename;
            databaseController = new DatabaseController();
            string jsonFilePath = "C:\\Users\\serov\\source\\repos\\building_organizations\\building_organizations\\Entity\\Stetham.json";
            string jsonContent = File.ReadAllText(jsonFilePath);
            dynamic tables = JsonConvert.DeserializeObject(jsonContent);
            this.Text = tablename;
            int i = 0;
            foreach (var table in tables)
            {
                if(table.table_name == tablename)
                {
                    foreach(var column in table.columns)
                    {
                        Label label = new Label();
                        label.Text = column.lname;
                        label.Location = new System.Drawing.Point(20, 20 + i * 40);
                        label.AutoSize = true;
                        label.Font=  new Font("Impact", 12F);
                        label.Show();
                        this.Controls.Add(label);
                        TextBox textBox = new TextBox();
                        textBox.Location = new System.Drawing.Point(200, 20 + i * 40);
                        textBox.Width = 200;
                        textBox.Text = "";
                        i++;
                        this.Controls.Add(textBox);
                        textBoxesList.Add(textBox);
                    }
                }
            }
            Button saveButton = new Button
            {
                Text = "Добавить",
                Location = new System.Drawing.Point(150, 20 + i * 40),
                Width = 100
            };
            saveButton.BackColor = Color.FromArgb(255, 128, 128);
            saveButton.Font = new Font("Impact", 14F);
            saveButton.Size = new Size(177, 81);
            saveButton.TabIndex = 2;
            saveButton.Text = "Добавить";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += SaveButton_Click;
            this.Controls.Add(saveButton);
            InitializeComponent();
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] data = { };
                Array.Resize(ref data, textBoxesList.Count);
                for (int i = 0; i < textBoxesList.Count; i++)
                {
                    string value = textBoxesList[i].Text;
                    data[i] = value;
                }
                databaseController.Add(data, tablename);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неверный запрос:{ex.Message}");
            }
            finally {
                MessageBox.Show($"Данные успешно сохранены!");
            }
            
        }

    }
    
}
