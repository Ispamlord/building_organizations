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
    public partial class RegistrateForm : Form
    {
        DatabaseController databaseController;
        
        public RegistrateForm()
        {
            InitializeComponent();
            databaseController = new DatabaseController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = textBox1.Text;
            string password = textBox2.Text;
            password = HashingPassword.HashPassword(password);
            if(textBox3.Text == "1234" && comboBox1.Text != "")
            {
                databaseController.CreateUser(username, password, comboBox1.Text);
            }
            else if(comboBox1.Text == "admin"|| comboBox1.Text == "editor")
            {
                MessageBox.Show("Недостаточно прав!");
            }
            else
            {
                databaseController.CreateUser(username, password, "viewer");
            }
        }
    }
}
