using System.Data.SqlClient;
using Sortify.Repository;

namespace Sortify
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BTN_login_Click(object sender, EventArgs e)
        {
            string emailInput = textboxEmail.Text;
            string passwordInput = textboxPassword.Text;

            if (emailInput == string.Empty || passwordInput == string.Empty)
            {
                MessageBox.Show("Please fill out all the fields");
            }
            else
            {
                if (checkbox_as_admin.Checked)
                {
                    if (emailInput.Equals("admin01@gmail.com") && passwordInput.Equals("adminpass"))
                    {
                        this.Hide();
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Credentials not found");
                    }
                }
                else
                {
                    UserRepository userRepository = new UserRepository();
                    userRepository.ValidateUser(emailInput, passwordInput);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void BTN_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BTN_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textboxPassword.UseSystemPasswordChar = true;
        }

        private void checkboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPassword.Checked)
            {
                textboxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textboxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
