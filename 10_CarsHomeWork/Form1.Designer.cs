namespace _10_CarsHomeWork
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ModelTextBox = new TextBox();
            YearNumericUpDown = new NumericUpDown();
            ColorComboBox = new ComboBox();
            ProbigNumericUpDown = new NumericUpDown();
            VolumeNumericupDown = new NumericUpDown();
            AddNewCarBtn = new Button();
            DeleteCarBtn = new Button();
            ShowCarBtn = new Button();
            CarList = new ListBox();
            label7 = new Label();
            SaveBtn = new Button();
            LoadBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)YearNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProbigNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VolumeNumericupDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 34);
            label1.TabIndex = 0;
            label1.Text = "NEW CAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 48);
            label2.Name = "label2";
            label2.Size = new Size(119, 34);
            label2.TabIndex = 1;
            label2.Text = "Model :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 116);
            label3.Name = "label3";
            label3.Size = new Size(108, 34);
            label3.TabIndex = 2;
            label3.Text = "Color :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 82);
            label4.Name = "label4";
            label4.Size = new Size(100, 34);
            label4.TabIndex = 3;
            label4.Text = "Year :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 150);
            label5.Name = "label5";
            label5.Size = new Size(124, 34);
            label5.TabIndex = 4;
            label5.Text = "Probig :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(-6, 184);
            label6.Name = "label6";
            label6.Size = new Size(136, 34);
            label6.TabIndex = 5;
            label6.Text = "Volume :";
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(136, 60);
            ModelTextBox.Multiline = true;
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(154, 21);
            ModelTextBox.TabIndex = 6;
            ModelTextBox.Text = " ";
            // 
            // YearNumericUpDown
            // 
            YearNumericUpDown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            YearNumericUpDown.Location = new Point(136, 93);
            YearNumericUpDown.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            YearNumericUpDown.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            YearNumericUpDown.Name = "YearNumericUpDown";
            YearNumericUpDown.Size = new Size(154, 23);
            YearNumericUpDown.TabIndex = 7;
            YearNumericUpDown.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // ColorComboBox
            // 
            ColorComboBox.FormattingEnabled = true;
            ColorComboBox.Items.AddRange(new object[] { "Green", "Red", "White", "Black", "Blue", "Cyan", "Gray", "Purple", "Pink", "Dark blue" });
            ColorComboBox.Location = new Point(136, 127);
            ColorComboBox.Name = "ColorComboBox";
            ColorComboBox.Size = new Size(154, 23);
            ColorComboBox.TabIndex = 8;
            // 
            // ProbigNumericUpDown
            // 
            ProbigNumericUpDown.Location = new Point(136, 161);
            ProbigNumericUpDown.Name = "ProbigNumericUpDown";
            ProbigNumericUpDown.Size = new Size(154, 23);
            ProbigNumericUpDown.TabIndex = 9;
            // 
            // VolumeNumericupDown
            // 
            VolumeNumericupDown.DecimalPlaces = 1;
            VolumeNumericupDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            VolumeNumericupDown.Location = new Point(136, 190);
            VolumeNumericupDown.Name = "VolumeNumericupDown";
            VolumeNumericupDown.Size = new Size(154, 23);
            VolumeNumericupDown.TabIndex = 10;
            // 
            // AddNewCarBtn
            // 
            AddNewCarBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewCarBtn.Location = new Point(11, 244);
            AddNewCarBtn.Name = "AddNewCarBtn";
            AddNewCarBtn.Size = new Size(279, 41);
            AddNewCarBtn.TabIndex = 11;
            AddNewCarBtn.Text = "ADD NEW CAR";
            AddNewCarBtn.UseVisualStyleBackColor = true;
            AddNewCarBtn.Click += AddNewCarBtn_Click;
            // 
            // DeleteCarBtn
            // 
            DeleteCarBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteCarBtn.Location = new Point(11, 300);
            DeleteCarBtn.Name = "DeleteCarBtn";
            DeleteCarBtn.Size = new Size(279, 41);
            DeleteCarBtn.TabIndex = 12;
            DeleteCarBtn.Text = "DELETE SELECTED CAR";
            DeleteCarBtn.UseVisualStyleBackColor = true;
            DeleteCarBtn.Click += DeleteCarBtn_Click;
            // 
            // ShowCarBtn
            // 
            ShowCarBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShowCarBtn.Location = new Point(11, 359);
            ShowCarBtn.Name = "ShowCarBtn";
            ShowCarBtn.Size = new Size(279, 41);
            ShowCarBtn.TabIndex = 13;
            ShowCarBtn.Text = "SHOW CAR";
            ShowCarBtn.UseVisualStyleBackColor = true;
            ShowCarBtn.Click += ShowCarBtn_Click;
            // 
            // CarList
            // 
            CarList.FormattingEnabled = true;
            CarList.ItemHeight = 15;
            CarList.Location = new Point(318, 48);
            CarList.Name = "CarList";
            CarList.Size = new Size(375, 289);
            CarList.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MV Boli", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(440, 9);
            label7.Name = "label7";
            label7.Size = new Size(148, 34);
            label7.TabIndex = 15;
            label7.Text = "CAR LIST";
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveBtn.Location = new Point(318, 359);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(151, 41);
            SaveBtn.TabIndex = 16;
            SaveBtn.Text = "SAVE ";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LoadBtn
            // 
            LoadBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoadBtn.Location = new Point(542, 359);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(151, 41);
            LoadBtn.TabIndex = 17;
            LoadBtn.Text = "LOAD";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 420);
            Controls.Add(LoadBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label7);
            Controls.Add(CarList);
            Controls.Add(ShowCarBtn);
            Controls.Add(DeleteCarBtn);
            Controls.Add(AddNewCarBtn);
            Controls.Add(VolumeNumericupDown);
            Controls.Add(ProbigNumericUpDown);
            Controls.Add(ColorComboBox);
            Controls.Add(YearNumericUpDown);
            Controls.Add(ModelTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)YearNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProbigNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)VolumeNumericupDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ModelTextBox;
        private NumericUpDown YearNumericUpDown;
        private ComboBox ColorComboBox;
        private NumericUpDown ProbigNumericUpDown;
        private NumericUpDown VolumeNumericupDown;
        private Button AddNewCarBtn;
        private Button DeleteCarBtn;
        private Button ShowCarBtn;
        private ListBox CarList;
        private Label label7;
        private Button SaveBtn;
        private Button LoadBtn;
    }
}