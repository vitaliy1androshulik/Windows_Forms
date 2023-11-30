namespace _11_AdditionalsForm
{
    partial class LoginForm
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
            Login = new TextBox();
            Password = new TextBox();
            label2 = new Label();
            label3 = new Label();
            LoginBtn = new Button();
            CloseBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 20);
            label1.Name = "label1";
            label1.Size = new Size(163, 37);
            label1.TabIndex = 0;
            label1.Text = "Login Form";
            // 
            // Login
            // 
            Login.Location = new Point(136, 95);
            Login.Name = "Login";
            Login.Size = new Size(100, 23);
            Login.TabIndex = 1;
            // 
            // Password
            // 
            Password.Location = new Point(136, 124);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(100, 23);
            Password.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 90);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 3;
            label2.Text = "Login :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 4;
            label3.Text = "Password : ";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(25, 217);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(91, 29);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.Location = new Point(145, 217);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(91, 29);
            CloseBtn.TabIndex = 6;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 303);
            Controls.Add(CloseBtn);
            Controls.Add(LoginBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Password);
            Controls.Add(Login);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Login;
        private TextBox Password;
        private Label label2;
        private Label label3;
        private Button LoginBtn;
        private Button CloseBtn;
    }
}