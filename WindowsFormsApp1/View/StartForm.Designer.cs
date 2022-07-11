
namespace WindowsFormsApp1.View
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.Label();
            this.label_back = new System.Windows.Forms.Label();
            this.label_open = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(71, 57);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(271, 402);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(933, 113);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(303, 214);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Большее количество ОЗУ",
            "Большее количество памяти",
            "Самый актуальный год выпуска"});
            this.comboBox1.Location = new System.Drawing.Point(933, 57);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 27);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Каталог ноутбуков";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(949, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выбор лучшего ноутбука";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label_exit);
            this.panel1.Controls.Add(this.label_back);
            this.panel1.Controls.Add(this.label_open);
            this.panel1.Location = new System.Drawing.Point(0, 470);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 105);
            this.panel1.TabIndex = 6;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exit.ForeColor = System.Drawing.Color.Transparent;
            this.label_exit.Location = new System.Drawing.Point(1059, 30);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(141, 49);
            this.label_exit.TabIndex = 3;
            this.label_exit.Text = "Выход";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // label_back
            // 
            this.label_back.AutoSize = true;
            this.label_back.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_back.ForeColor = System.Drawing.Color.Transparent;
            this.label_back.Location = new System.Drawing.Point(611, 30);
            this.label_back.Name = "label_back";
            this.label_back.Size = new System.Drawing.Size(130, 49);
            this.label_back.TabIndex = 1;
            this.label_back.Text = "Назад";
            this.label_back.Click += new System.EventHandler(this.label_back_Click);
            this.label_back.MouseEnter += new System.EventHandler(this.label_back_MouseEnter);
            this.label_back.MouseLeave += new System.EventHandler(this.label_back_MouseLeave);
            // 
            // label_open
            // 
            this.label_open.AutoSize = true;
            this.label_open.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_open.ForeColor = System.Drawing.Color.Transparent;
            this.label_open.Location = new System.Drawing.Point(103, 30);
            this.label_open.Name = "label_open";
            this.label_open.Size = new System.Drawing.Size(194, 49);
            this.label_open.TabIndex = 0;
            this.label_open.Text = "Открыть ";
            this.label_open.Click += new System.EventHandler(this.label_open_Click);
            this.label_open.MouseEnter += new System.EventHandler(this.label_open_MouseEnter);
            this.label_open.MouseLeave += new System.EventHandler(this.label_open_MouseLeave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(43, 633);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(902, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "ФГБОУ ВО «Сибирский государственный университет имени М.Ф. Решетнева» Лесосибирск" +
    "ий филиал";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1307, 686);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StartForm";
            this.Text = "Каталог ноутбуков";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_open;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label_back;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
    }
}