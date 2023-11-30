namespace _3_BaseControls
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
            OrderMeal = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label2 = new Label();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            textBox4 = new TextBox();
            label10 = new Label();
            monthCalendar1 = new MonthCalendar();
            label11 = new Label();
            numericUpDown1 = new NumericUpDown();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // OrderMeal
            // 
            OrderMeal.BackColor = Color.FromArgb(128, 255, 128);
            OrderMeal.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 0);
            OrderMeal.FlatAppearance.BorderSize = 3;
            OrderMeal.FlatAppearance.MouseDownBackColor = Color.Red;
            OrderMeal.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            OrderMeal.FlatStyle = FlatStyle.Flat;
            OrderMeal.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            OrderMeal.Location = new Point(568, 402);
            OrderMeal.Name = "OrderMeal";
            OrderMeal.Size = new Size(133, 38);
            OrderMeal.TabIndex = 0;
            OrderMeal.Text = "Order Meal";
            OrderMeal.UseVisualStyleBackColor = false;
            OrderMeal.Click += label11_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(69, 192);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(76, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "BreakFast";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(69, 217);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(59, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Lunch";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(69, 242);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(61, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Dinner";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 140);
            label1.Name = "label1";
            label1.Size = new Size(178, 37);
            label1.TabIndex = 5;
            label1.Text = "Select meal :";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 52);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Econom";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(3, 76);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Standart";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(3, 102);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(46, 19);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Fast";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(208, 37);
            label2.TabIndex = 9;
            label2.Text = "Delivery Type :";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(17, 101);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(130, 32);
            radioButton4.TabIndex = 12;
            radioButton4.TabStop = true;
            radioButton4.Text = "CreditCard";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(17, 75);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(93, 32);
            radioButton5.TabIndex = 11;
            radioButton5.TabStop = true;
            radioButton5.Text = "PayPal";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(17, 51);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(102, 32);
            radioButton6.TabIndex = 10;
            radioButton6.TabStop = true;
            radioButton6.Text = "By cash";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton3);
            panel1.Location = new Point(242, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 147);
            panel1.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(460, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(165, 147);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Yellow;
            label3.Font = new Font("SimSun-ExtB", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(311, 53);
            label3.Name = "label3";
            label3.Size = new Size(185, 33);
            label3.TabIndex = 16;
            label3.Text = "Order meal";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 324);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 353);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(140, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(116, 382);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(140, 23);
            textBox3.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 327);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 20;
            label4.Text = "Login:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 361);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 21;
            label5.Text = "Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 385);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 22;
            label6.Text = "Confirm Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 414);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 24;
            label7.Text = "Phone:";
            label7.Click += label7_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(116, 415);
            maskedTextBox1.Mask = "+38(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(140, 23);
            maskedTextBox1.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(100, 284);
            label8.Name = "label8";
            label8.Size = new Size(113, 37);
            label8.TabIndex = 26;
            label8.Text = "Details:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(348, 415);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(311, 418);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 28;
            label9.Text = "Date:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(348, 353);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 49);
            textBox4.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(278, 382);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 30;
            label10.Text = "Comment:";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(637, 1);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.SelectionRange = new SelectionRange(new DateTime(2023, 11, 18, 0, 0, 0, 0), new DateTime(2023, 11, 24, 0, 0, 0, 0));
            monthCalendar1.ShowToday = false;
            monthCalendar1.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(554, 361);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 32;
            label11.Text = "Count meals:";
            label11.Click += label11_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(637, 359);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(50, 23);
            numericUpDown1.TabIndex = 33;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(label11);
            Controls.Add(monthCalendar1);
            Controls.Add(label10);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(maskedTextBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(OrderMeal);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OrderMeal;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label2;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private MaskedTextBox maskedTextBox1;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private TextBox textBox4;
        private Label label10;
        private MonthCalendar monthCalendar1;
        private Label label11;
        private NumericUpDown numericUpDown1;
    }
}