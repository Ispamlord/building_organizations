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

namespace building_organizations.SettingForms
{
    public partial class ChangeForms : Form
    {
        DatabaseController databaseController;
        user us;
        public ChangeForms(user us)
        {
            this.us = us;
            InitializeComponent();
            databaseController = new DatabaseController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (us.password == textBox1.Text)
            {
                us.password = textBox2.Text;
                databaseController.ChangePass(us.id, us.password);
            }
            else
            {
                MessageBox.Show("Пароль неверный");
            }
        }
    }
}
