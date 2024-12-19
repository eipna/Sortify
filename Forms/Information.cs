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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        private int user_id = 0;

        public void EditUser(User user)
        {
            fieldFirstName.Text = user.firstName;
            fieldMiddleName.Text = user.middleName;
            fieldLastName.Text = user.lastName;
            FieldAge.Text = user.age;
            FieldGender.Text = user.gender;
            fieldEmailAddress.Text = user.email;
            fieldPassword.Text = user.password;
            FieldPhone.Text = user.phone;
            FieldAddress.Text = user.address;

            user_id = user.id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.id = user_id;
            user.firstName = fieldFirstName.Text;
            user.middleName = fieldMiddleName.Text;
            user.lastName = fieldLastName.Text;
            user.age = FieldAge.Text;
            user.gender = FieldGender.Text;
            user.email = fieldEmailAddress.Text;
            user.password = fieldPassword.Text;
            user.phone = FieldPhone.Text;
            user.address = FieldAddress.Text;

            var repo = new UserRepository();

            if (user.id == 0)
            {
                repo.CreateUser(user);
            }
            else
            {
                DialogResult result = MessageBox.Show("Proceed to edit the user?", "Edit User", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
                repo.UpdateUser(user);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
