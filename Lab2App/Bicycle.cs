using System;
using System.Windows.Forms;

namespace Lab2App
{
    public partial class Bicycle : Form
    {
        public Bicycle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1. Check if empty
            if (txtStart.Text == "" || txtEnd.Text == "")
            {
                MessageBox.Show("Please enter both start time and end time.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Parse numbers
            int start;
            int end;

            if (!int.TryParse(txtStart.Text, out start) || !int.TryParse(txtEnd.Text, out end))
            {
                MessageBox.Show("Decimal numbers are not accepted. Please enter whole numbers only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validate ranges
            if (start < 0 || start > 23)
            {
                MessageBox.Show("Start time must be between 0 and 23.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (end < 1 || end > 24)
            {
                MessageBox.Show("End time must be between 1 and 24.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (start >= end)
            {
                MessageBox.Show("Starting time must be less than ending time.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Calculate total cost based on the hourly rates
            int total = 0;
            for (int hour = start; hour < end; hour++)
            {
                if (hour < 7 || hour >= 21)
                {
                    total += 500;
                }
                else if ((hour >= 7 && hour < 14) || (hour >= 19 && hour < 21))
                {
                    total += 1000;
                }
                else if (hour >= 14 && hour < 19)
                {
                    total += 1500;
                }
            }

            // 5. Display total in the Total textbox and show MessageBox
            txtTotal.Text = total.ToString() + " RWF";
            MessageBox.Show("Total rental cost: " + total.ToString() + " RWF", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Choose chooseForm = new Choose();
            chooseForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
