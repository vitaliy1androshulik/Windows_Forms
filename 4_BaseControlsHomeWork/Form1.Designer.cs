namespace _4_BaseControlsHomeWork
{
    partial class HotelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelForm));
            HotelName = new Label();
            NameName = new Label();
            SurnameTextBox = new TextBox();
            label1 = new Label();
            NameTextBox = new TextBox();
            PhoneNumber = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            CountOfPeople = new NumericUpDown();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            TypeOfHotelRationButton = new Panel();
            label5 = new Label();
            BigTextBox = new TextBox();
            label6 = new Label();
            Order = new Button();
            Vidminity = new Button();
            Ymovi_CheckBox = new CheckBox();
            monthCalendar1 = new MonthCalendar();
            LoadButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CountOfPeople).BeginInit();
            TypeOfHotelRationButton.SuspendLayout();
            SuspendLayout();
            // 
            // HotelName
            // 
            HotelName.AutoSize = true;
            HotelName.BackColor = Color.White;
            HotelName.Font = new Font("Gabriola", 30F, FontStyle.Bold, GraphicsUnit.Point);
            HotelName.ForeColor = Color.DarkSeaGreen;
            HotelName.Location = new Point(121, -22);
            HotelName.Name = "HotelName";
            HotelName.Size = new Size(215, 74);
            HotelName.TabIndex = 0;
            HotelName.Text = "Сант-Де-Прі";
            // 
            // NameName
            // 
            NameName.AutoSize = true;
            NameName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameName.Location = new Point(46, 71);
            NameName.Name = "NameName";
            NameName.Size = new Size(86, 21);
            NameName.TabIndex = 1;
            NameName.Text = "Прізвище :";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(138, 69);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(149, 23);
            SurnameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(88, 100);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 3;
            label1.Text = "Ім'я :";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(138, 98);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(149, 23);
            NameTextBox.TabIndex = 4;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Location = new Point(138, 129);
            PhoneNumber.Mask = "+38(999) 000-0000";
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(150, 23);
            PhoneNumber.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 129);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 6;
            label2.Text = "Контакт  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(-3, 160);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 7;
            label3.Text = "Кількість людей  :";
            // 
            // CountOfPeople
            // 
            CountOfPeople.Location = new Point(138, 158);
            CountOfPeople.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            CountOfPeople.Name = "CountOfPeople";
            CountOfPeople.Size = new Size(149, 23);
            CountOfPeople.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 215);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 9;
            label4.Text = "Тип готелю :";
            label4.Click += label4_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(0, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Econom";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(0, 28);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 19);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Standart";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(0, 52);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(61, 19);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "Luxury";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // TypeOfHotelRationButton
            // 
            TypeOfHotelRationButton.Controls.Add(radioButton3);
            TypeOfHotelRationButton.Controls.Add(radioButton1);
            TypeOfHotelRationButton.Controls.Add(radioButton2);
            TypeOfHotelRationButton.Location = new Point(138, 187);
            TypeOfHotelRationButton.Name = "TypeOfHotelRationButton";
            TypeOfHotelRationButton.Size = new Size(150, 80);
            TypeOfHotelRationButton.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(39, 355);
            label5.Name = "label5";
            label5.Size = new Size(93, 21);
            label5.TabIndex = 15;
            label5.Text = "Тривалість :";
            // 
            // BigTextBox
            // 
            BigTextBox.Location = new Point(138, 453);
            BigTextBox.Multiline = true;
            BigTextBox.Name = "BigTextBox";
            BigTextBox.Size = new Size(149, 52);
            BigTextBox.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(32, 453);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 17;
            label6.Text = "Побажання :";
            // 
            // Order
            // 
            Order.BackColor = Color.FromArgb(192, 255, 192);
            Order.BackgroundImageLayout = ImageLayout.None;
            Order.Enabled = false;
            Order.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Order.Location = new Point(203, 591);
            Order.Name = "Order";
            Order.Size = new Size(116, 46);
            Order.TabIndex = 18;
            Order.Text = "Замовити";
            Order.UseVisualStyleBackColor = false;
            Order.Click += Order_Click;
            // 
            // Vidminity
            // 
            Vidminity.BackColor = Color.FromArgb(255, 128, 128);
            Vidminity.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Vidminity.Location = new Point(325, 591);
            Vidminity.Name = "Vidminity";
            Vidminity.Size = new Size(116, 46);
            Vidminity.TabIndex = 19;
            Vidminity.Text = "Відмінити";
            Vidminity.UseVisualStyleBackColor = false;
            Vidminity.Click += Vidminity_Click;
            // 
            // Ymovi_CheckBox
            // 
            Ymovi_CheckBox.AutoSize = true;
            Ymovi_CheckBox.Location = new Point(138, 527);
            Ymovi_CheckBox.Name = "Ymovi_CheckBox";
            Ymovi_CheckBox.Size = new Size(140, 19);
            Ymovi_CheckBox.TabIndex = 20;
            Ymovi_CheckBox.Text = "Підтвердження умов";
            Ymovi_CheckBox.UseVisualStyleBackColor = true;
            Ymovi_CheckBox.Click += Ymovi_CheckBox_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(138, 279);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 14;
            // 
            // LoadButton
            // 
            LoadButton.BackColor = Color.FromArgb(255, 192, 128);
            LoadButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoadButton.Location = new Point(12, 591);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(78, 53);
            LoadButton.TabIndex = 21;
            LoadButton.Text = "Вигрузити з файлу";
            LoadButton.UseVisualStyleBackColor = false;
            LoadButton.Click += LoadButton_Click;
            // 
            // HotelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(453, 649);
            Controls.Add(LoadButton);
            Controls.Add(Ymovi_CheckBox);
            Controls.Add(Vidminity);
            Controls.Add(Order);
            Controls.Add(label6);
            Controls.Add(BigTextBox);
            Controls.Add(label5);
            Controls.Add(monthCalendar1);
            Controls.Add(TypeOfHotelRationButton);
            Controls.Add(label4);
            Controls.Add(CountOfPeople);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PhoneNumber);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Controls.Add(SurnameTextBox);
            Controls.Add(NameName);
            Controls.Add(HotelName);
            Name = "HotelForm";
            Text = "Hotel";
            Load += HotelForm_Load;
            ((System.ComponentModel.ISupportInitialize)CountOfPeople).EndInit();
            TypeOfHotelRationButton.ResumeLayout(false);
            TypeOfHotelRationButton.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HotelName;
        private Label NameName;
        private TextBox SurnameTextBox;
        private Label label1;
        private TextBox NameTextBox;
        private MaskedTextBox PhoneNumber;
        private Label label2;
        private Label label3;
        private NumericUpDown CountOfPeople;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Panel TypeOfHotelRationButton;
        private Label label5;
        private TextBox BigTextBox;
        private Label label6;
        private Button Order;
        private Button Vidminity;
        private CheckBox Ymovi_CheckBox;
        private MonthCalendar monthCalendar1;
        private Button LoadButton;
    }
}