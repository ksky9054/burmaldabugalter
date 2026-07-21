namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            button4 = new Button();
            button3 = new Button();
            label9 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            label10 = new Label();
            button6 = new Button();
            label6 = new Label();
            panel5 = new Panel();
            textBox2 = new TextBox();
            label11 = new Label();
            label7 = new Label();
            panel6 = new Panel();
            button5 = new Button();
            textBox3 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1092, 44);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(825, 7);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 2;
            label3.Text = "Профиль: {}";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(392, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(32, 9);
            label2.Name = "label2";
            label2.Size = new Size(195, 23);
            label2.TabIndex = 0;
            label2.Text = "Бухгалтер-Помощник";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 46);
            label1.Name = "label1";
            label1.Size = new Size(176, 28);
            label1.TabIndex = 0;
            label1.Text = "Здравствуйте, {}\r\n";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 161);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.Location = new Point(257, 80);
            button2.Name = "button2";
            button2.Size = new Size(180, 52);
            button2.TabIndex = 3;
            button2.Text = "Сверка выписок";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Location = new Point(63, 80);
            button1.Name = "button1";
            button1.Size = new Size(188, 52);
            button1.TabIndex = 2;
            button1.Text = "Загрузить документ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 53);
            label8.Name = "label8";
            label8.Size = new Size(374, 15);
            label8.TabIndex = 1;
            label8.Text = "Распознавание документов, создание проводок и сверка выписок.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.No;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(63, 32);
            label4.Name = "label4";
            label4.Size = new Size(211, 21);
            label4.TabIndex = 0;
            label4.Text = "РАБОТА С ДОКУМЕНТАМИ";
            label4.Click += label4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(552, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(524, 161);
            panel3.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.WhiteSmoke;
            button4.Location = new Point(261, 80);
            button4.Name = "button4";
            button4.Size = new Size(188, 52);
            button4.TabIndex = 5;
            button4.Text = "Проверить ошибки";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.WhiteSmoke;
            button3.Location = new Point(67, 80);
            button3.Name = "button3";
            button3.Size = new Size(188, 52);
            button3.TabIndex = 4;
            button3.Text = "Сформировать отчёт";
            button3.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(67, 57);
            label9.Name = "label9";
            label9.Size = new Size(431, 15);
            label9.TabIndex = 1;
            label9.Text = "Заполнение деклараций (ФНС, ПФР, ФСС), контроль сроков, поиск ошибок.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.Location = new Point(67, 33);
            label5.Name = "label5";
            label5.Size = new Size(183, 20);
            label5.TabIndex = 0;
            label5.Text = "ОТЧЁТНОСТЬ И НАЛОГИ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(12, 272);
            panel4.Name = "panel4";
            panel4.Size = new Size(516, 161);
            panel4.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(73, 35);
            label10.Name = "label10";
            label10.Size = new Size(219, 15);
            label10.TabIndex = 4;
            label10.Text = "Анализ доходов и расходов компании.";
            // 
            // button6
            // 
            button6.BackColor = Color.WhiteSmoke;
            button6.Location = new Point(73, 63);
            button6.Name = "button6";
            button6.Size = new Size(188, 52);
            button6.TabIndex = 4;
            button6.Text = "Открыть отчёт";
            button6.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label6.Location = new Point(73, 15);
            label6.Name = "label6";
            label6.Size = new Size(165, 20);
            label6.TabIndex = 0;
            label6.Text = "БИЗНЕС-АНАЛИТИКА";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(552, 272);
            panel5.Name = "panel5";
            panel5.Size = new Size(524, 161);
            panel5.TabIndex = 2;
            panel5.Paint += panel5_Paint;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.Location = new Point(91, 63);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(341, 52);
            textBox2.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(91, 35);
            label11.Name = "label11";
            label11.Size = new Size(184, 15);
            label11.TabIndex = 5;
            label11.Text = "Быстрая проверка по базе ФНС.";
            label11.Click += label11_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label7.Location = new Point(91, 15);
            label7.Name = "label7";
            label7.Size = new Size(198, 20);
            label7.TabIndex = 0;
            label7.Text = "ПРОВЕРКА КОНТРАГЕНТОВ";
            label7.Click += label7_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(button5);
            panel6.Controls.Add(textBox3);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label12);
            panel6.Location = new Point(12, 451);
            panel6.Name = "panel6";
            panel6.Size = new Size(1063, 115);
            panel6.TabIndex = 3;
            // 
            // button5
            // 
            button5.BackColor = Color.WhiteSmoke;
            button5.Location = new Point(831, 48);
            button5.Name = "button5";
            button5.Size = new Size(188, 36);
            button5.TabIndex = 5;
            button5.Text = "Получить ответ с ссылками";
            button5.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.Location = new Point(146, 50);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(677, 34);
            textBox3.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(145, 32);
            label13.Name = "label13";
            label13.Size = new Size(155, 15);
            label13.TabIndex = 5;
            label13.Text = "Задать вопрос базе знаний";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label12.Location = new Point(145, 12);
            label12.Name = "label12";
            label12.Size = new Size(194, 20);
            label12.TabIndex = 6;
            label12.Text = "ЮРИДИЧЕСКАЯ СПРАВКА";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1087, 578);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Бизнес-учёт (альфа версия)";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private Label label8;
        private Label label4;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private Panel panel5;
        private Label label7;
        private Panel panel6;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button3;
        private Label label9;
        private Label label10;
        private Button button6;
        private TextBox textBox2;
        private Label label11;
        private TextBox textBox3;
        private Label label13;
        private Label label12;
        private Button button5;
    }
}
