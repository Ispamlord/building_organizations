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
    public partial class QueryToolWindow : Form
    {
        DatabaseController databaseController;
        public QueryToolWindow()
        {
            InitializeComponent();
            databaseController = new DatabaseController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                databaseController.QueryTool(textBox1.Text, dataGridView1);
            }
            catch (Exception ex) {
            }
        }
    }
}
