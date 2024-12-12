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
    public partial class MainMenucs : Form
    {
        DatabaseController databaseController;
        user user;
        bool isAbsolute = false;
        bool isEditor = false;
        bool isViewer = false;
        private void CheckUser()
        {
            switch (user.role)
            {
                case "admin":
                    isAbsolute = true;
                    break;
                case "editor":
                    isEditor = true;
                    break;
                case "viewer":
                    isViewer = true;
                    break;
                default:
                    break;
            }
        }
        public MainMenucs(user us)
        {
            user = us;
            InitializeComponent();
            databaseController = new DatabaseController();
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

            //databaseController.SelectFromDataBase("city", dataGridView1);
        }

        private void changeRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
