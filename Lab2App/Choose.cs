using System;
using System.Windows.Forms;

namespace Lab2App
{
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            Bicycle bicycleForm = new Bicycle();
            bicycleForm.Show();
            this.Hide();
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            Mushroom mushroomForm = new Mushroom();
            mushroomForm.Show();
            this.Hide();
        }
    }
}
