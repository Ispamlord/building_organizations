using building_organizations.Entity;
using Npgsql;
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
            string queryText = textBox1.Text.Trim();

            if (!queryText.StartsWith("Select", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Ошибка: запрос должен начинаться с 'Select'.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            databaseController.QueryTool(queryText, dataGridView1);
            
        }
    }
}
