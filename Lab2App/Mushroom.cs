using System;
using System.Windows.Forms;

namespace Lab2App
{
    public partial class Mushroom : Form
    {
        public Mushroom()
        {
            InitializeComponent();
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            // Question 1: Gills
            DialogResult q1 = MessageBox.Show("Does your mushroom have gills?", "Question 1", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (q1 == DialogResult.No)
            {
                txtResult.Text = "Cepe de bordeaux";
                MessageBox.Show("Your mushroom is: Cepe de bordeaux", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Question 2: Forest
                DialogResult q2 = MessageBox.Show("Does your mushroom grow in a forest?", "Question 2", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (q2 == DialogResult.No)
                {
                    // Meadow mushrooms: Agaric Jaunissant or Coprin chevelu
                    DialogResult q3 = MessageBox.Show("Does your mushroom have a convex cup?", "Question 3", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (q3 == DialogResult.Yes)
                    {
                        txtResult.Text = "Agaric Jaunissant";
                        MessageBox.Show("Your mushroom is: Agaric Jaunissant", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtResult.Text = "Coprin chevelu";
                        MessageBox.Show("Your mushroom is: Coprin chevelu", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Forest mushrooms: Amanite tue-mouche, Girolle, or Pied bleu
                    DialogResult q3 = MessageBox.Show("Does your mushroom have a ring?", "Question 3", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (q3 == DialogResult.Yes)
                    {
                        txtResult.Text = "Amanite tue-mouche";
                        MessageBox.Show("Your mushroom is: Amanite tue-mouche", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult q4 = MessageBox.Show("Does your mushroom have a convex cup?", "Question 4", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (q4 == DialogResult.Yes)
                        {
                            txtResult.Text = "Pied bleu";
                            MessageBox.Show("Your mushroom is: Pied bleu", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            txtResult.Text = "Girolle";
                            MessageBox.Show("Your mushroom is: Girolle", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
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
