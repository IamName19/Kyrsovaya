namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.Label();
            this.label_information = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(43, 633);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(902, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "ФГБОУ ВО «Сибирский государственный университет имени М.Ф. Решетнева» Лесосибирск" +
    "ий филиал";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label_exit);
            this.panel1.Controls.Add(this.label_information);
            this.panel1.Controls.Add(this.label_start);
            this.panel1.Location = new System.Drawing.Point(0, 470);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 105);
            this.panel1.TabIndex = 1;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exit.ForeColor = System.Drawing.Color.Transparent;
            this.label_exit.Location = new System.Drawing.Point(1044, 27);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(141, 49);
            this.label_exit.TabIndex = 2;
            this.label_exit.Text = "Выход";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // label_information
            // 
            this.label_information.AutoSize = true;
            this.label_information.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_information.ForeColor = System.Drawing.Color.Transparent;
            this.label_information.Location = new System.Drawing.Point(539, 27);
            this.label_information.Name = "label_information";
            this.label_information.Size = new System.Drawing.Size(258, 49);
            this.label_information.TabIndex = 1;
            this.label_information.Text = "Информация";
            this.label_information.Click += new System.EventHandler(this.label_information_Click);
            this.label_information.MouseEnter += new System.EventHandler(this.label_information_MouseEnter);
            this.label_information.MouseLeave += new System.EventHandler(this.label_information_MouseLeave);
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_start.ForeColor = System.Drawing.Color.Transparent;
            this.label_start.Location = new System.Drawing.Point(131, 27);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(129, 49);
            this.label_start.TabIndex = 0;
            this.label_start.Text = "Старт";
            this.label_start.Click += new System.EventHandler(this.label_start_Click);
            this.label_start.MouseEnter += new System.EventHandler(this.label_start_MouseEnter);
            this.label_start.MouseLeave += new System.EventHandler(this.label_start_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(419, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Каталог ноутбуков";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1307, 686);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Программа \"Каталог ноутбуков\"";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label_information;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label1;
    }
}

