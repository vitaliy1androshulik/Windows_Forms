﻿namespace _19_Paint
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
            DrawBtn = new Button();
            SuspendLayout();
            // 
            // DrawBtn
            // 
            DrawBtn.Location = new Point(697, 400);
            DrawBtn.Name = "DrawBtn";
            DrawBtn.Size = new Size(91, 38);
            DrawBtn.TabIndex = 0;
            DrawBtn.Text = "Draw";
            DrawBtn.UseVisualStyleBackColor = true;
            DrawBtn.Click += DrawBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DrawBtn);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
            ResumeLayout(false);
        }

        #endregion

        private Button DrawBtn;
    }
}