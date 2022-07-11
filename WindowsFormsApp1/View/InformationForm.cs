using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.View
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }
        private void InformationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label_back_Click(object sender, EventArgs e)
        {
            Form result = Application.OpenForms[0];
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }
        private void label_back_MouseEnter(object sender, EventArgs e)
        {
            label_back.ForeColor = Color.Gray;
        }
        private void label_back_MouseLeave(object sender, EventArgs e)
        {
            label_back.ForeColor = Color.Transparent;
        }


        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Gray;
        }
        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Transparent;
        }
    }
}
