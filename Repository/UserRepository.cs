using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sortify.Models;

namespace Sortify.Repository
{
    public class UserRepository
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=SortifyDB;Integrated Security=True;Trust Server Certificate=True";

        public void ValidateUser(string email, string password)
        {
            var repo = new UserRepository();
            List<User> users = repo.GetUsers();

            foreach (User user in users)
            {
                if (user.email == email && user.password == password)
                {
                    UserDashboard userDashboard = new UserDashboard(user);
                    userDashboard.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Failed");
        }

        public List<User> GetUsers()
        {
            var users = new List<User>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM users";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User user = new User();
                                user.id = reader.GetInt32(0);
                                user.firstName = reader.GetString(1);
                                user.middleName = reader.GetString(2);
                                user.lastName = reader.GetString(3);
                                user.age = reader.GetString(4);
                                user.gender = reader.GetString(5);
                                user.email = reader.GetString(6);
                                user.password = reader.GetString(7);
                                user.phone = reader.GetString(8);
                                user.address = reader.GetString(9);

                                users.Add(user);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return users;
        }

        public void DeleteUser(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM users WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE users " +
                        "SET firstName=@firstName, middleName=@middleName, lastName=@lastName, " +
                        "gender=@gender, age=@age, email=@email, password=@password, phone=@phone, address=@address " +
                        "WHERE id=@id";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", user.id);
                        cmd.Parameters.AddWithValue("@firstName", user.firstName);
                        cmd.Parameters.AddWithValue("@middleName", user.middleName);
                        cmd.Parameters.AddWithValue("@age", user.age);
                        cmd.Parameters.AddWithValue("@lastName", user.lastName);
                        cmd.Parameters.AddWithValue("@gender", user.gender);
                        cmd.Parameters.AddWithValue("@email", user.email);
                        cmd.Parameters.AddWithValue("@password", user.password);
                        cmd.Parameters.AddWithValue("@phone", user.phone);
                        cmd.Parameters.AddWithValue("@address", user.address);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void CreateUser(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO users " +
                        "(firstName, middleName, lastName, age, gender, email, password, phone, address) VALUES " +
                        "(@firstName, @middleName, @lastName, @age, @gender, @email, @password, @phone, @address);";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@firstName", user.firstName);
                        cmd.Parameters.AddWithValue("@middleName", user.middleName);
                        cmd.Parameters.AddWithValue("@lastName", user.lastName);
                        cmd.Parameters.AddWithValue("@age", user.age);
                        cmd.Parameters.AddWithValue("@gender", user.gender);
                        cmd.Parameters.AddWithValue("@email", user.email);
                        cmd.Parameters.AddWithValue("@password", user.password);
                        cmd.Parameters.AddWithValue("@phone", user.phone);
                        cmd.Parameters.AddWithValue("@address", user.address);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exeception: " + ex.ToString());
            }
        }

        public User? GetUser(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM users WHERE id=@id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                User user = new User();
                                user.id = reader.GetInt32(0);
                                user.firstName = reader.GetString(1);
                                user.middleName = reader.GetString(2);
                                user.lastName = reader.GetString(3);
                                user.age = reader.GetString(4);
                                user.gender = reader.GetString(5);
                                user.email = reader.GetString(6);
                                user.password = reader.GetString(7);
                                user.phone = reader.GetString(8);
                                user.address = reader.GetString(9);

                                return user;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exeception: " + ex.ToString());
            }

            return null;
        }
    }
}
