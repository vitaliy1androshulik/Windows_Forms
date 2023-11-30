namespace _11_AdditionalsForm
{
    partial class SecondForm
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            ShowBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(309, 20);
            label1.Name = "label1";
            label1.Size = new Size(184, 37);
            label1.TabIndex = 0;
            label1.Text = "Second Form";
            // 
            // button1
            // 
            button1.Location = new Point(309, 273);
            button1.Name = "button1";
            button1.Size = new Size(184, 38);
            button1.TabIndex = 1;
            button1.Text = "Close this form";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(323, 122);
            label2.Name = "label2";
            label2.Size = new Size(142, 37);
            label2.TabIndex = 2;
            label2.Text = "Hello, ......";
            // 
            // ShowBtn
            // 
            ShowBtn.Location = new Point(308, 206);
            ShowBtn.Name = "ShowBtn";
            ShowBtn.Size = new Size(184, 38);
            ShowBtn.TabIndex = 3;
            ShowBtn.Text = "Show user";
            ShowBtn.UseVisualStyleBackColor = true;
            ShowBtn.Click += ShowBtn_Click;
            // 
            // SecondForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShowBtn);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "SecondForm";
            Text = "SecondForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Button ShowBtn;
    }
}