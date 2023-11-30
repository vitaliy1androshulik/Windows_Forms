namespace _6_ProgressBarTrackBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            progressBar1 = new ProgressBar();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            TopBtn = new Button();
            StartTimerBtn = new Button();
            StopTImerBtn = new Button();
            trackBar1 = new TrackBar();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            trackBar3 = new TrackBar();
            trackBar2 = new TrackBar();
            panel2 = new Panel();
            trackBar4 = new TrackBar();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSplitButton1 = new ToolStripSplitButton();
            infoToolStripMenuItem = new ToolStripMenuItem();
            numberOfProjectToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem1 = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            howAreYouToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(31, 23);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(321, 23);
            progressBar1.TabIndex = 0;
            progressBar1.Value = 40;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(314, 70);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(38, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 72);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Top value: ";
            // 
            // TopBtn
            // 
            TopBtn.Location = new Point(118, 90);
            TopBtn.Name = "TopBtn";
            TopBtn.Size = new Size(140, 35);
            TopBtn.TabIndex = 3;
            TopBtn.Text = "Go to TOP value";
            TopBtn.UseVisualStyleBackColor = true;
            TopBtn.Click += TopBtn_Click;
            // 
            // StartTimerBtn
            // 
            StartTimerBtn.Location = new Point(31, 141);
            StartTimerBtn.Name = "StartTimerBtn";
            StartTimerBtn.Size = new Size(88, 28);
            StartTimerBtn.TabIndex = 4;
            StartTimerBtn.Text = "Start Timer";
            StartTimerBtn.UseVisualStyleBackColor = true;
            StartTimerBtn.Click += button2_Click;
            // 
            // StopTImerBtn
            // 
            StopTImerBtn.Location = new Point(264, 141);
            StopTImerBtn.Name = "StopTImerBtn";
            StopTImerBtn.Size = new Size(88, 28);
            StopTImerBtn.TabIndex = 5;
            StopTImerBtn.Text = "Stop Timer";
            StopTImerBtn.UseVisualStyleBackColor = true;
            StopTImerBtn.Click += button3_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(76, 69);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(256, 45);
            trackBar1.TabIndex = 6;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(trackBar3);
            panel1.Controls.Add(trackBar2);
            panel1.Controls.Add(trackBar1);
            panel1.Location = new Point(413, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 305);
            panel1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 194);
            label5.Name = "label5";
            label5.Size = new Size(51, 25);
            label5.TabIndex = 12;
            label5.Text = "Blue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 131);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 11;
            label4.Text = "Green";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 69);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 10;
            label3.Text = "RED";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(73, 23);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 9;
            label2.Text = "Change color phone";
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(76, 194);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(256, 45);
            trackBar3.TabIndex = 8;
            trackBar3.TickStyle = TickStyle.None;
            trackBar3.Scroll += trackBar3_Scroll;
            trackBar3.ValueChanged += trackBar1_ValueChanged;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(73, 131);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(256, 45);
            trackBar2.TabIndex = 7;
            trackBar2.TickStyle = TickStyle.None;
            trackBar2.ValueChanged += trackBar1_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(trackBar4);
            panel2.Location = new Point(781, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(82, 305);
            panel2.TabIndex = 8;
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(19, 0);
            trackBar4.Maximum = 100;
            trackBar4.Minimum = 5;
            trackBar4.Name = "trackBar4";
            trackBar4.Orientation = Orientation.Vertical;
            trackBar4.Size = new Size(45, 302);
            trackBar4.TabIndex = 9;
            trackBar4.Value = 100;
            trackBar4.ValueChanged += trackBar4_ValueChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1, toolStripDropDownButton1, toolStripSplitButton1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1052, 22);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(53, 17);
            toolStripStatusLabel1.Text = "Time : 3s";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(50, 16);
            toolStripProgressBar1.Value = 40;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripSeparator1 });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(38, 20);
            toolStripDropDownButton1.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(67, 22);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(64, 6);
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { infoToolStripMenuItem, settingsToolStripMenuItem, helpToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(54, 20);
            toolStripSplitButton1.Text = "Menu";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { numberOfProjectToolStripMenuItem });
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(180, 22);
            infoToolStripMenuItem.Text = "Info";
            // 
            // numberOfProjectToolStripMenuItem
            // 
            numberOfProjectToolStripMenuItem.Name = "numberOfProjectToolStripMenuItem";
            numberOfProjectToolStripMenuItem.Size = new Size(172, 22);
            numberOfProjectToolStripMenuItem.Text = "Number of project";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem1 });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(180, 22);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // settingsToolStripMenuItem1
            // 
            settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            settingsToolStripMenuItem1.Size = new Size(116, 22);
            settingsToolStripMenuItem1.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { howAreYouToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(180, 22);
            helpToolStripMenuItem.Text = "Help";
            // 
            // howAreYouToolStripMenuItem
            // 
            howAreYouToolStripMenuItem.Name = "howAreYouToolStripMenuItem";
            howAreYouToolStripMenuItem.Size = new Size(146, 22);
            howAreYouToolStripMenuItem.Text = "How are you?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 450);
            Controls.Add(statusStrip1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(StopTImerBtn);
            Controls.Add(StartTimerBtn);
            Controls.Add(TopBtn);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Button TopBtn;
        private Button StartTimerBtn;
        private Button StopTImerBtn;
        private TrackBar trackBar1;
        private Panel panel1;
        private TrackBar trackBar3;
        private TrackBar trackBar2;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TrackBar trackBar4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem howAreYouToolStripMenuItem;
        private ToolStripMenuItem numberOfProjectToolStripMenuItem;
    }
}