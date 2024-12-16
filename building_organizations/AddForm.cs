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

namespace building_organizations
{
    public partial class AddForm: Form
    {
        private List<TextBox> textBoxesList = new List<TextBox>();
        DatabaseController databaseController;
        private string tablename;
        public AddForm(string[] labels, string[] textBoxes, string tablename)
        {
            this.tablename = tablename;
            InitializeComponent();
            databaseController = new DatabaseController();
            if (labels.Length != textBoxes.Length)
            {
                throw new ArgumentException("Количество меток и текстовых полей должно совпадать.");
            }

            this.Text = "Динамическая форма";
            this.Size = new System.Drawing.Size(400, labels.Length * 50 + 100);

            for (int i = 0; i < labels.Length; i++)
            {
                Label label = new Label();
                label.Text = labels[i];
                label.Location = new System.Drawing.Point(20, 20 + i * 40);
                label.AutoSize = true;
                this.Controls.Add(label);

                TextBox textBox = new TextBox();
                textBox.Text = textBoxes[i];
                textBox.Location = new System.Drawing.Point(150, 20 + i * 40);
                textBox.Width = 200;
                this.Controls.Add(textBox);

                textBoxesList.Add(textBox);
            }

            Button closeButton = new Button();
            closeButton.Text = "Закрыть";
            closeButton.Location = new System.Drawing.Point(150, 20 + labels.Length * 40);
            closeButton.Click += (sender, e) => this.Close();
            this.Controls.Add(closeButton);
            Button addbuttton = new Button();
            addbuttton.Text = "Добавить";
            addbuttton.Location = new System.Drawing.Point(200, 30 + labels.Length * 40);
            addbuttton.Click += AddButton_click;
        }
        private void AddButton_click(object sender, EventArgs e)
        {
            try
            {
                string[] data = { };
                Array.Resize(ref data, textBoxesList.Count);
                for (int i = 0; i < textBoxesList.Count; i++)
                {
                    data[i] = textBoxesList[i].Text;
                }
                databaseController.Add(data,tablename);
            }
            catch (Exception ex) {
                MessageBox.Show("Error: ", ex.Message);
            }
        }
        
    }
    
}
