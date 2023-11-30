namespace _12_Dialogs
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
            OpenBtn = new Button();
            SaveBtn = new Button();
            OpenFolderBtn = new Button();
            BackgroundBtn = new Button();
            FontBtn = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // OpenBtn
            // 
            OpenBtn.Location = new Point(29, 12);
            OpenBtn.Name = "OpenBtn";
            OpenBtn.Size = new Size(147, 35);
            OpenBtn.TabIndex = 0;
            OpenBtn.Text = "Open File";
            OpenBtn.UseVisualStyleBackColor = true;
            OpenBtn.Click += OpenBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(296, 12);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(128, 35);
            SaveBtn.TabIndex = 1;
            SaveBtn.Text = "Save File";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // OpenFolderBtn
            // 
            OpenFolderBtn.Location = new Point(611, 12);
            OpenFolderBtn.Name = "OpenFolderBtn";
            OpenFolderBtn.Size = new Size(158, 35);
            OpenFolderBtn.TabIndex = 2;
            OpenFolderBtn.Text = "Open Folder";
            OpenFolderBtn.UseVisualStyleBackColor = true;
            OpenFolderBtn.Click += OpenFolderBtn_Click;
            // 
            // BackgroundBtn
            // 
            BackgroundBtn.Location = new Point(29, 392);
            BackgroundBtn.Name = "BackgroundBtn";
            BackgroundBtn.Size = new Size(201, 33);
            BackgroundBtn.TabIndex = 3;
            BackgroundBtn.Text = "BackGround color";
            BackgroundBtn.UseVisualStyleBackColor = true;
            BackgroundBtn.Click += BackgroundBtn_Click;
            // 
            // FontBtn
            // 
            FontBtn.Location = new Point(304, 392);
            FontBtn.Name = "FontBtn";
            FontBtn.Size = new Size(120, 33);
            FontBtn.TabIndex = 4;
            FontBtn.Text = "Font";
            FontBtn.UseVisualStyleBackColor = true;
            FontBtn.Click += FontBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 53);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(395, 333);
            textBox1.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(477, 53);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(292, 334);
            listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(FontBtn);
            Controls.Add(BackgroundBtn);
            Controls.Add(OpenFolderBtn);
            Controls.Add(SaveBtn);
            Controls.Add(OpenBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenBtn;
        private Button SaveBtn;
        private Button OpenFolderBtn;
        private Button BackgroundBtn;
        private Button FontBtn;
        private TextBox textBox1;
        private ListBox listBox1;
    }
}