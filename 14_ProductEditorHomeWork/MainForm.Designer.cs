namespace _14_ProductEditorHomeWork
{
    partial class MainForm
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
            listBox1 = new ListBox();
            EditBtn = new Button();
            InfoBtn = new Button();
            MinusBtn = new Button();
            PlusBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 27);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("SimSun", 17F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(12, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(300, 280);
            listBox1.TabIndex = 1;
            // 
            // EditBtn
            // 
            EditBtn.Font = new Font("SimSun", 17F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.Location = new Point(12, 325);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(71, 47);
            EditBtn.TabIndex = 2;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // InfoBtn
            // 
            InfoBtn.Font = new Font("SimSun", 17F, FontStyle.Bold, GraphicsUnit.Point);
            InfoBtn.Location = new Point(89, 325);
            InfoBtn.Name = "InfoBtn";
            InfoBtn.Size = new Size(71, 47);
            InfoBtn.TabIndex = 3;
            InfoBtn.Text = "Info";
            InfoBtn.UseVisualStyleBackColor = true;
            InfoBtn.Click += InfoBtn_Click_1;
            // 
            // MinusBtn
            // 
            MinusBtn.Font = new Font("SimSun", 17F, FontStyle.Bold, GraphicsUnit.Point);
            MinusBtn.Location = new Point(204, 325);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(51, 47);
            MinusBtn.TabIndex = 4;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = true;
            MinusBtn.Click += MinusBtn_Click;
            // 
            // PlusBtn
            // 
            PlusBtn.Font = new Font("SimSun", 17F, FontStyle.Bold, GraphicsUnit.Point);
            PlusBtn.Location = new Point(261, 325);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(51, 47);
            PlusBtn.TabIndex = 5;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            PlusBtn.Click += PlusBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 378);
            Controls.Add(PlusBtn);
            Controls.Add(MinusBtn);
            Controls.Add(InfoBtn);
            Controls.Add(EditBtn);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button EditBtn;
        private Button InfoBtn;
        private Button MinusBtn;
        private Button PlusBtn;
    }
}