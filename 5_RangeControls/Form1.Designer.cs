namespace _5_RangeControls
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            OrderButton = new Button();
            ClearButton = new Button();
            textBox1 = new TextBox();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            toolTip5 = new ToolTip(components);
            toolTip6 = new ToolTip(components);
            toolTip7 = new ToolTip(components);
            toolTip8 = new ToolTip(components);
            toolTip9 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(7, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select meal :";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 74);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 8;
            label3.Text = "10$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 49);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 7;
            label2.Text = "2$";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 24);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 6;
            label1.Text = "4$";
            label1.Click += label1_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(51, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Tag = "10";
            radioButton3.Text = "Pizza";
            toolTip3.SetToolTip(radioButton3, "Danger");
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Tag = "2";
            radioButton2.Text = "Sandwich";
            toolTip2.SetToolTip(radioButton2, "Sandwich, top");
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Tag = "4";
            radioButton1.Text = "Hot dog";
            toolTip1.SetToolTip(radioButton1, "Bread, sasouge, ketchup");
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Location = new Point(224, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 150);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select drink :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(108, 74);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 11;
            label6.Text = "2$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 49);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 10;
            label5.Text = "1$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 24);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 9;
            label4.Tag = "1,5";
            label4.Text = "1.5$";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 72);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(53, 19);
            radioButton4.TabIndex = 2;
            radioButton4.TabStop = true;
            radioButton4.Tag = "2";
            radioButton4.Text = "Pepsi";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 47);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(51, 19);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Tag = "1";
            radioButton5.Text = "Juice";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(6, 22);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(49, 19);
            radioButton6.TabIndex = 0;
            radioButton6.TabStop = true;
            radioButton6.Tag = "1,5";
            radioButton6.Text = "Cola";
            toolTip1.SetToolTip(radioButton6, "Many sugar");
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // OrderButton
            // 
            OrderButton.Enabled = false;
            OrderButton.Location = new Point(62, 163);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(92, 33);
            OrderButton.TabIndex = 4;
            OrderButton.Text = "Order";
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += OrderButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(278, 163);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(92, 33);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "Clear";
            toolTip4.SetToolTip(ClearButton, "Clearning");
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(490, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 128);
            textBox1.TabIndex = 6;
            toolTip5.SetToolTip(textBox1, "Save file");
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Hot-Dog receipt";
            // 
            // toolTip2
            // 
            toolTip2.ToolTipIcon = ToolTipIcon.Warning;
            toolTip2.ToolTipTitle = "Don`t eat this";
            // 
            // toolTip3
            // 
            toolTip3.ToolTipIcon = ToolTipIcon.Error;
            toolTip3.ToolTipTitle = "With fine pineapple";
            // 
            // toolTip4
            // 
            toolTip4.ToolTipIcon = ToolTipIcon.Warning;
            toolTip4.ToolTipTitle = "Clear";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(ClearButton);
            Controls.Add(OrderButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button OrderButton;
        private Button ClearButton;
        private TextBox textBox1;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private ToolTip toolTip5;
        private ToolTip toolTip6;
        private ToolTip toolTip7;
        private ToolTip toolTip8;
        private ToolTip toolTip9;
    }
}