using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sortify.Models;
using Sortify.Repository;

namespace Sortify
{
    public partial class UserDashboard : Form
    {
        private int user_id = 0;
        public UserDashboard(User user)
        {
            InitializeComponent();
            user_id = user.id;
            fieldFirstName.Text = user.firstName;
            fieldMiddleName.Text = user.middleName;
            fieldLastName.Text = user.lastName;
            fieldAge.Text = user.age;
            fieldGender.Text = user.gender;
            fieldEmail.Text = user.email;
            fieldPassword.Text = user.password;
            fieldPhone.Text = user.phone;
            fieldAddress.Text = user.address;
        }

        private void BTN_close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BTN_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void BTN_update_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Proceed to update?", "Update", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            User updatedUser = new User();
            updatedUser.id = user_id;
            updatedUser.firstName = fieldFirstName.Text;
            updatedUser.middleName = fieldMiddleName.Text;
            updatedUser.lastName = fieldLastName.Text;
            updatedUser.age = fieldAge.Text;
            updatedUser.gender = fieldGender.Text;
            updatedUser.email = fieldEmail.Text;
            updatedUser.password = fieldPassword.Text;
            updatedUser.phone = fieldPhone.Text;
            updatedUser.address = fieldAddress.Text;

            var repo = new UserRepository();
            repo.UpdateUser(updatedUser);

            MessageBox.Show("User has been updated");
        }
    }
}
