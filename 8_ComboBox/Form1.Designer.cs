namespace _8_ComboBox
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ShowSelectBtn = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.Simple;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kyiv", "Lviv", "Rivne", "Lutsk", "Dnipro", "Odessa", "Poltava" });
            comboBox1.Location = new Point(12, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 90);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Kyiv", "Lviv", "Rivne", "Lutsk", "Dnipro", "Odesa", "Poltava" });
            comboBox2.Location = new Point(208, 31);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Kyiv", "Lviv", "Rivne", "Lutsk", "Dnipro", "Odesa", "Poltava" });
            comboBox3.Location = new Point(416, 31);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 2;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(12, 386);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(231, 23);
            comboBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 6;
            label1.Text = "Select your city :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 9);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 7;
            label2.Text = "Select your city :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 9);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 8;
            label3.Text = "Select your city :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 368);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 9;
            label4.Text = "Select order :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 197);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 11;
            label6.Text = "Order price :";
            // 
            // button1
            // 
            button1.Location = new Point(264, 385);
            button1.Name = "button1";
            button1.Size = new Size(121, 53);
            button1.TabIndex = 12;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(413, 257);
            button2.Name = "button2";
            button2.Size = new Size(144, 23);
            button2.TabIndex = 13;
            button2.Text = "Add new order";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(413, 286);
            button3.Name = "button3";
            button3.Size = new Size(144, 23);
            button3.TabIndex = 14;
            button3.Text = "Remove selected order";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ShowSelectBtn
            // 
            ShowSelectBtn.Location = new Point(413, 315);
            ShowSelectBtn.Name = "ShowSelectBtn";
            ShowSelectBtn.Size = new Size(144, 23);
            ShowSelectBtn.TabIndex = 15;
            ShowSelectBtn.Text = "Show selected order";
            ShowSelectBtn.UseVisualStyleBackColor = true;
            ShowSelectBtn.Click += ShowSelectBtn_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(416, 215);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 16;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(ShowSelectBtn);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "w";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button ShowSelectBtn;
        private NumericUpDown numericUpDown1;
    }
}