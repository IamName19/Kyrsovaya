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
using WindowsFormsApp1.View;
using System.IO;

namespace WindowsFormsApp1.View
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Большее количество памяти")
            {
                richTextBox2.Text = TCatalog.ShowBestMemory();
            }
            if (comboBox1.Text == "Большее количество ОЗУ")
            {
                richTextBox2.Text = TCatalog.ShowBestRam();
            }
            if (comboBox1.Text == "Самый актуальный год выпуска")
            {
                richTextBox2.Text = TCatalog.ShowBestYear();
            }
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


        private void label_open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            TCatalog catalog = new TCatalog(filename);
            richTextBox1.Text = catalog.ShowCatalog();
            comboBox1.Enabled = true;
            richTextBox1.Text += catalog.NumCompany();
        }
        private void label_open_MouseEnter(object sender, EventArgs e)
        {
            label_open.ForeColor = Color.Gray;
        }
        private void label_open_MouseLeave(object sender, EventArgs e)
        {
            label_open.ForeColor = Color.Transparent;
        }
    }
}