namespace _20_PaintHomeWork
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
            ShapeType = new ComboBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            LineType = new ComboBox();
            ColorBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // ShapeType
            // 
            ShapeType.FormattingEnabled = true;
            ShapeType.Location = new Point(84, 3);
            ShapeType.Name = "ShapeType";
            ShapeType.Size = new Size(121, 23);
            ShapeType.TabIndex = 1;
            ShapeType.Text = "-------Shape--------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(338, 3);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 2;
            label1.Text = "Size  :";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(393, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(40, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(439, 3);
            button1.Name = "button1";
            button1.Size = new Size(55, 24);
            button1.TabIndex = 6;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LineType
            // 
            LineType.FormattingEnabled = true;
            LineType.Items.AddRange(new object[] { "Default", "Dot", "Line Dot", "Line Dot Dot", "Dash" });
            LineType.Location = new Point(211, 3);
            LineType.Name = "LineType";
            LineType.Size = new Size(121, 23);
            LineType.TabIndex = 7;
            LineType.Text = "------Line Type------";
            // 
            // ColorBtn
            // 
            ColorBtn.BackColor = Color.Lime;
            ColorBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ColorBtn.Location = new Point(3, 2);
            ColorBtn.Name = "ColorBtn";
            ColorBtn.Size = new Size(75, 24);
            ColorBtn.TabIndex = 8;
            ColorBtn.Text = "Color";
            ColorBtn.UseVisualStyleBackColor = false;
            ColorBtn.Click += ColorBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 641);
            Controls.Add(ColorBtn);
            Controls.Add(LineType);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(ShapeType);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox ShapeType;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private ComboBox LineType;
        private Button ColorBtn;
    }
}