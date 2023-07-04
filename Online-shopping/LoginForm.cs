using Online_shopping.Dashboards;
using Online_shopping.Dashboards.UserDashboard;
using Online_shopping.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_shopping
{
    public partial class LoginForm : Form
    {
        private SqlConnection connection;
        public LoginForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }
        private void InitializeDatabaseConnection()
        {
            try
            {
                // Set the connection string to your database
                string connectionString = "Data Source=Windows-f07og7q;Initial Catalog=db_online_shopping;Integrated Security=True;Pooling=False";
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to database: " + ex.Message);
                MessageBox.Show("Error connecting to database. Please contact support.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = uname.Text.Trim();
            string password = passwordTxt.Text;

            // Validate that the username and password fields are not empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check the login credentials using the DatabaseHelper class
            bool isValidCredentials = CheckLoginCredentials(username, password);

            if (isValidCredentials)
            {
                
                // Navigate to the appropriate dashboard based on the user's role
                string role = GetUserRole(username);
                if (role == "admin")
                {
                    // Navigate to the admin dashboard
                    AdminDashboardForm adminDashboard = new AdminDashboardForm();
                    adminDashboard.Show();
                    this.Hide();
                }
                else if (role == "user")
                {
                    // Navigate to the user dashboard form
                    UserDashboard dashboardForm = new UserDashboard();
                    PlaceOrder placeOrder = new PlaceOrder();
                    placeOrder.username = username; // Pass the username value to the PlaceOrder form
                    dashboardForm.PlaceOrderForm = placeOrder; // Assign the PlaceOrder form to a property in the UserDashboard form
                    dashboardForm.Show();
                    this.Hide();
                }
            }
            else
            {
                // Show an error message and give the option to reset the login credentials
                DialogResult result = MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK,MessageBoxIcon.Error);

                if (result == DialogResult.OK)
                {
                    // Reset the login credentials
                    uname.Text = "";
                    passwordTxt.Text = "";
                }
            }
        }


        // Check login credentials 
        private bool CheckLoginCredentials(string username, string password)
        {
            {
                // Construct a SQL query to check the login credentials
                string query = "SELECT COUNT(*) FROM Users WHERE Uname = @username AND pass = @password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set the username and password parameters for the SQL query
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int result = (int)command.ExecuteScalar();

                    // Check if the username and password are valid
                    if (result == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

        }

        private string GetUserRole(string usernameOrId)
        {
            // Construct a SQL query to retrieve the user's role based on their username or ID
            string query = "SELECT Urole FROM Users WHERE Uname = @usernameOrId";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Set the username or ID parameter for the SQL query
                command.Parameters.AddWithValue("@usernameOrId", usernameOrId);

                object result = command.ExecuteScalar();

                // Check if the user's role was retrieved successfully
                if (result != null)
                {
                    return (string)result;
                }
                else
                {
                    throw new Exception("User role not found");
                }
            }
        }
    }
}
