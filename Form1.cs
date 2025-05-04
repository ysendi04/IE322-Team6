using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace LoginForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtPass.UseSystemPasswordChar = true;
        }

        public bool IsLoggedIn { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SWEET_1\\TEW_SQLEXPRESS;Initial Catalog=LoginApp;Integrated Security=True;TrustServerCertificate=True");
            con.Open();


            string usernameQuery = "SELECT COUNT(*) FROM loginapp WHERE username=@username";
            SqlCommand usernameCmd = new SqlCommand(usernameQuery, con);
            usernameCmd.Parameters.AddWithValue("@username", txtUser.Text);
            int usernameCount = (int)usernameCmd.ExecuteScalar();

            if (usernameCount == 0)
            {
                MessageBox.Show("The username does not exist. Please check your username.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }

            string passwordQuery = "SELECT COUNT(*) FROM loginapp WHERE username=@username AND password=@password";
            SqlCommand passwordCmd = new SqlCommand(passwordQuery, con);
            passwordCmd.Parameters.AddWithValue("@username", txtUser.Text);
            passwordCmd.Parameters.AddWithValue("@password", txtPass.Text);
            int passwordCount = (int)passwordCmd.ExecuteScalar();

            con.Close();

            if (passwordCount > 0)
            {
                IsLoggedIn = true;
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect password. Please check your password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {

            txtPass.UseSystemPasswordChar = !chkShow.Checked;
        }
    }
}