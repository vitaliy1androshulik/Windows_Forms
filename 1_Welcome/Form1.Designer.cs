namespace _1_Welcome
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
            btnClick = new Button();
            label1 = new Label();
            btn2 = new Button();
            MoveLeft = new Button();
            MoveRight = new Button();
            cs = new Button();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.BackColor = Color.Crimson;
            btnClick.Font = new Font("Sitka Display", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnClick.Location = new Point(24, 158);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(285, 89);
            btnClick.TabIndex = 0;
            btnClick.Text = "Click";
            btnClick.UseVisualStyleBackColor = false;
            btnClick.Click += button1_Click;
            btnClick.MouseEnter += button1_MouseEnter;
            btnClick.MouseLeave += button1_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(270, 35);
            label1.Name = "label1";
            label1.Size = new Size(227, 47);
            label1.TabIndex = 1;
            label1.Text = "Hello forems!";
            label1.Click += label1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Crimson;
            btn2.Font = new Font("Sitka Display", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(482, 158);
            btn2.Name = "btn2";
            btn2.Size = new Size(285, 89);
            btn2.TabIndex = 2;
            btn2.Text = "Close";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += label1_Click;
            btn2.MouseClick += button2_MouseClick;
            // 
            // MoveLeft
            // 
            MoveLeft.Location = new Point(91, 332);
            MoveLeft.Name = "MoveLeft";
            MoveLeft.Size = new Size(75, 23);
            MoveLeft.TabIndex = 3;
            MoveLeft.Text = "MoveLeft";
            MoveLeft.UseVisualStyleBackColor = true;
            MoveLeft.Click += MoveLeft_Click;
            // 
            // MoveRight
            // 
            MoveRight.Location = new Point(624, 332);
            MoveRight.Name = "MoveRight";
            MoveRight.Size = new Size(75, 23);
            MoveRight.TabIndex = 4;
            MoveRight.Text = "Moveright";
            MoveRight.UseVisualStyleBackColor = true;
            MoveRight.Click += MoveRight_Click;
            // 
            // cs
            // 
            cs.Location = new Point(368, 332);
            cs.Name = "cs";
            cs.Size = new Size(75, 23);
            cs.TabIndex = 5;
            cs.Text = "C#";
            cs.UseVisualStyleBackColor = true;
            cs.Click += cs_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cs);
            Controls.Add(MoveRight);
            Controls.Add(MoveLeft);
            Controls.Add(btn2);
            Controls.Add(label1);
            Controls.Add(btnClick);
            Name = "Form1";
            Text = "Form1";
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClick;
        private Label label1;
        private Button button2;
        private Button btn2;
        private Button MoveLeft;
        private Button MoveRight;
        private Button cs;
    }
}