using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.NewFolder1;
using System.IO;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
        private void label_start_Click(object sender, EventArgs e)
        {
            StartForm result = new StartForm();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        } 
        private void label_start_MouseEnter(object sender, EventArgs e)
        {
            label_start.ForeColor = Color.Gray;
        }
        private void label_start_MouseLeave(object sender, EventArgs e)
        {
            label_start.ForeColor = Color.Transparent;
        }


        private void label_information_Click(object sender, EventArgs e)
        {
            InformationForm result = new InformationForm();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }   
        private void label_information_MouseEnter(object sender, EventArgs e)
        {
            label_information.ForeColor = Color.Gray;
        }
        private void label_information_MouseLeave(object sender, EventArgs e)
        {
            label_information.ForeColor = Color.Transparent;
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
