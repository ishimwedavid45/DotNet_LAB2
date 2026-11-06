using System;
using System.Windows.Forms;

namespace Lab2App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Username and Password cannot be empty
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username and Password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Go to Choose form
                Choose chooseForm = new Choose();
                chooseForm.Show();
                this.Hide();
            }
        }
    }
}
