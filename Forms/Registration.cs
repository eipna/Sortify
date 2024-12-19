using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sortify.Models;
using Sortify.Repository;

namespace Sortify
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void BTN_back_login_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void BTN_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BTN_register_Click(object sender, EventArgs e)
        {
            if (checkboxTermsConditions.Checked)
            {
                if (fieldPassword.Text.Equals(fieldConfirmPassword.Text))
                {
                    if (fieldPhone.Text.Length != 11)
                    {
                        MessageBox.Show("Invalid Phone Number");
                    }
                    else
                    {
                        try
                        {
                            if (Convert.ToInt32((string)fieldAge.Text) < 18 || Convert.ToInt32((string)fieldAge.Text) > 60)
                            {
                                MessageBox.Show("The age entered is outside of range");
                            }
                            else
                            {
                                User newUser = new User();
                                newUser.firstName = fieldFirstName.Text;
                                newUser.middleName = fieldMiddleName.Text;
                                newUser.lastName = fieldLastName.Text;
                                newUser.age = fieldAge.Text;
                                newUser.gender = fieldGender.Text;
                                newUser.email = fieldEmailAddress.Text;
                                newUser.password = fieldPassword.Text;
                                newUser.phone = fieldPhone.Text;
                                newUser.address = fieldAddress.Text;

                                var repo = new UserRepository();
                                repo.CreateUser(newUser);

                                MessageBox.Show("User created successfully");
                            }
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Invalid Age");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The passwords should match, please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please accept the terms and conditions");
            }
        }

        private void fieldEmailAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void fieldFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(fieldFirstName.Text))
                {
                    MessageBox.Show("First name is required");
                    return;
                }
                fieldMiddleName.Focus();
                e.Handled = true;
            }
        }

        private void fieldMiddleName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fieldLastName.Focus();
                e.Handled = true;
            }
        }

        private void fieldLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(fieldFirstName.Text))
                {
                    MessageBox.Show("Last name is required");
                    return;
                }
                fieldEmailAddress.Focus();
                e.Handled = true;
            }
        }

        private void fieldEmailAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!ValidateEmail(fieldEmailAddress.Text))
                {
                    MessageBox.Show("The email entered is not valid");
                    fieldEmailAddress.Text = "";
                }
                fieldPassword.Focus();
                e.Handled = true;
            }
        }

        private bool ValidateEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void fieldPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fieldConfirmPassword.Focus();
                e.Handled = true;
            }
        }

        private void fieldConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fieldAddress.Focus();
                e.Handled = true;
            }
        }

        private void fieldAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fieldAge.Focus();
                e.Handled = true;
            }
        }

        private void fieldAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int n = Convert.ToInt32(fieldAge.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Invalid phone number");
                    fieldAge.Text = "";
                }

                fieldPhone.Focus();
                e.Handled = true;
            }
        }

        private void fieldPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int n = Convert.ToInt32(fieldPhone.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Invalid phone number");
                    fieldPhone.Text = "";
                }
                fieldGender.Focus();
                e.Handled = true;
            }
        }

        private void label_terms_condition_Click(object sender, EventArgs e)
        {
            TermsConditions terms = new TermsConditions();
            terms.ShowDialog();
        }
    }
}
