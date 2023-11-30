namespace _14_ProductEditorHomeWork
{
    partial class EditInfoForm
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
            button1 = new Button();
            CountryCombo = new ComboBox();
            DiscountNumeric = new NumericUpDown();
            CountNumeric = new NumericUpDown();
            PriceNumeric = new NumericUpDown();
            NameTextBox = new TextBox();
            OkBtn = new Button();
            CancelBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DiscountNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CountNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumeric).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("SimSun", 17F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(117, 253);
            button1.Name = "button1";
            button1.Size = new Size(91, 42);
            button1.TabIndex = 27;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CountryCombo
            // 
            CountryCombo.FormattingEnabled = true;
            CountryCombo.Items.AddRange(new object[] { "Ukraine", "USA", "Poland", "Germany", "France", "Greece", "Egypt", "Turkey", "Hungary", "Norway", "Scotland", "Switzerland", "England", "Spain", "Portugal" });
            CountryCombo.Location = new Point(167, 173);
            CountryCombo.Name = "CountryCombo";
            CountryCombo.Size = new Size(150, 23);
            CountryCombo.TabIndex = 26;
            // 
            // DiscountNumeric
            // 
            DiscountNumeric.Location = new Point(167, 211);
            DiscountNumeric.Name = "DiscountNumeric";
            DiscountNumeric.Size = new Size(150, 23);
            DiscountNumeric.TabIndex = 25;
            // 
            // CountNumeric
            // 
            CountNumeric.Location = new Point(167, 132);
            CountNumeric.Name = "CountNumeric";
            CountNumeric.Size = new Size(150, 23);
            CountNumeric.TabIndex = 24;
            // 
            // PriceNumeric
            // 
            PriceNumeric.Location = new Point(167, 94);
            PriceNumeric.Name = "PriceNumeric";
            PriceNumeric.Size = new Size(150, 23);
            PriceNumeric.TabIndex = 23;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(167, 56);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(150, 23);
            NameTextBox.TabIndex = 22;
            // 
            // OkBtn
            // 
            OkBtn.FlatAppearance.BorderSize = 0;
            OkBtn.Font = new Font("SimSun", 17F, FontStyle.Regular, GraphicsUnit.Point);
            OkBtn.Location = new Point(218, 253);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(91, 42);
            OkBtn.TabIndex = 21;
            OkBtn.Text = "OK";
            OkBtn.UseVisualStyleBackColor = true;
            OkBtn.Click += button2_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.Font = new Font("SimSun", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            CancelBtn.Location = new Point(12, 253);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(99, 42);
            CancelBtn.TabIndex = 20;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(2, 207);
            label6.Name = "label6";
            label6.Size = new Size(166, 27);
            label6.TabIndex = 19;
            label6.Text = "Discount ::";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 169);
            label5.Name = "label5";
            label5.Size = new Size(152, 27);
            label5.TabIndex = 18;
            label5.Text = "Country ::";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 128);
            label4.Name = "label4";
            label4.Size = new Size(124, 27);
            label4.TabIndex = 17;
            label4.Text = "Count ::";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 90);
            label3.Name = "label3";
            label3.Size = new Size(124, 27);
            label3.TabIndex = 16;
            label3.Text = "Price ::";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(58, 52);
            label2.Name = "label2";
            label2.Size = new Size(110, 27);
            label2.TabIndex = 15;
            label2.Text = "Name ::";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(124, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 27);
            label1.TabIndex = 14;
            label1.Text = "INFO";
            // 
            // EditInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 306);
            Controls.Add(button1);
            Controls.Add(CountryCombo);
            Controls.Add(DiscountNumeric);
            Controls.Add(CountNumeric);
            Controls.Add(PriceNumeric);
            Controls.Add(NameTextBox);
            Controls.Add(OkBtn);
            Controls.Add(CancelBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditInfoForm";
            Text = "EditInfoForm";
            ((System.ComponentModel.ISupportInitialize)DiscountNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)CountNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox CountryCombo;
        private NumericUpDown DiscountNumeric;
        private NumericUpDown CountNumeric;
        private NumericUpDown PriceNumeric;
        private TextBox NameTextBox;
        private Button OkBtn;
        private Button CancelBtn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}