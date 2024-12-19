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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();

            ReadUsers();
        }

        private void ReadUsers()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Age");
            dataTable.Columns.Add("Gender");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Phone");
            dataTable.Columns.Add("Address");

            var repo = new UserRepository();
            var users = repo.GetUsers();

            foreach (var user in users)
            {
                var row = dataTable.NewRow();

                row["ID"] = user.id;
                row["Name"] = user.firstName + " " + user.middleName + " " + user.lastName;
                row["Age"] = user.age;
                row["Gender"] = user.gender;
                row["Email"] = user.email;
                row["Phone"] = user.phone;
                row["Address"] = user.address;

                dataTable.Rows.Add(row);
            }

            this.usersTable.DataSource = dataTable;
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

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void BTN_update_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            if (information.ShowDialog() == DialogResult.OK)
            {
                ReadUsers();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var value = usersTable.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null || value.Length == 0)
            {
                return;
            }

            int userID = int.Parse(value);

            var repo = new UserRepository();
            var user = repo.GetUser(userID);

            if (user == null)
            {
                return;
            }

            Information form = new Information();
            form.EditUser(user);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadUsers();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var value = usersTable.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null || value.Length == 0)
            {
                return;
            }

            int userID = int.Parse(value);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var repo = new UserRepository();
            repo.DeleteUser(userID);

            ReadUsers();
        }

        private void BubbleSortID(List<User> users)
        {
            int size = users.Count;
            bool swapped;

            for (int i = 0; i < size - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < size - 1 - i; j++)
                {
                    if (users[j].id > users[j + 1].id)
                    {
                        User temp = users[j];
                        users[j] = users[j + 1];
                        users[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }

        private void BubbleSortAge(List<User> users)
        {
            int size = users.Count;
            bool swapped;

            for (int i = 0; i < size - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < size - 1 - i; j++)
                {
                    if (int.Parse(users[j].age) > int.Parse(users[j + 1].age))
                    {
                        User temp = users[j];
                        users[j] = users[j + 1];
                        users[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButtonID.Checked)
            {
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("ID");
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Age");
                dataTable.Columns.Add("Gender");
                dataTable.Columns.Add("Email");
                dataTable.Columns.Add("Phone");
                dataTable.Columns.Add("Address");

                var repo = new UserRepository();
                List<User> users = repo.GetUsers();
                BubbleSortID(users);

                foreach (var user in users)
                {
                    var row = dataTable.NewRow();

                    row["ID"] = user.id;
                    row["Name"] = user.firstName + " " + user.middleName + " " + user.lastName;
                    row["Age"] = user.age;
                    row["Gender"] = user.gender;
                    row["Email"] = user.email;
                    row["Phone"] = user.phone;
                    row["Address"] = user.address;

                    dataTable.Rows.Add(row);
                }

                this.usersTable.DataSource = dataTable;
            }

            if (radioButtonAge.Checked)
            {
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("ID");
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Age");
                dataTable.Columns.Add("Gender");
                dataTable.Columns.Add("Email");
                dataTable.Columns.Add("Phone");
                dataTable.Columns.Add("Address");

                var repo = new UserRepository();
                List<User> users = repo.GetUsers();
                BubbleSortAge(users);

                foreach (var user in users)
                {
                    var row = dataTable.NewRow();

                    row["ID"] = user.id;
                    row["Name"] = user.firstName + " " + user.middleName + " " + user.lastName;
                    row["Age"] = user.age;
                    row["Gender"] = user.gender;
                    row["Email"] = user.email;
                    row["Phone"] = user.phone;
                    row["Address"] = user.address;

                    dataTable.Rows.Add(row);
                }

                this.usersTable.DataSource = dataTable;
            }
        }

        private void AdminDashboard_Load_1(object sender, EventArgs e)
        {
            usersTable.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.
                Bold);
        }
    }
}
