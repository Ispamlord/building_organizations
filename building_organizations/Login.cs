using building_organizations.Entity;
using Npgsql;
using System.Data;

namespace building_organizations
{
    public partial class Login : Form
    {
        DatabaseController databaseController;
        public Login()
        {
            InitializeComponent();
            databaseController = new DatabaseController();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RegistrateForm registrateForm = new RegistrateForm();
            registrateForm.Show();
        }
        public void label3_Click_1(object sender, EventArgs e)
        {
        }
        
        public void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            user user = new user();
            bool isAuthenticated = databaseController.AuthenticateUser(username, password, user);
            if (isAuthenticated)
            {
                MainMenucs mainMenucs = new MainMenucs(user);
                mainMenucs.Show();
                MessageBox.Show("Поздравляю вы вошли в с уровнем доступа:" + user.role);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
            
        }


    }
}
