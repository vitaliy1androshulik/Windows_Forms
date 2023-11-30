namespace _7_RageControlsHomeWorkk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            textBox1 = new TextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            CurrentLengthValue = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            MaxLengthValue = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            DigitValue = new ToolStripStatusLabel();
            toolStripStatusLabel6 = new ToolStripStatusLabel();
            LetterValue = new ToolStripStatusLabel();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            wordValue = new ToolStripStatusLabel();
            toolStripSplitButton1 = new ToolStripSplitButton();
            textColorToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            yellowToolStripMenuItem = new ToolStripMenuItem();
            blackToolStripMenuItem = new ToolStripMenuItem();
            cyanToolStripMenuItem = new ToolStripMenuItem();
            grayToolStripMenuItem = new ToolStripMenuItem();
            wordWrapToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            boldToolStripMenuItem = new ToolStripMenuItem();
            sizeToolStripMenuItem = new ToolStripMenuItem();
            sizeToolStripMenuItem1 = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            arialToolStripMenuItem = new ToolStripMenuItem();
            calibriToolStripMenuItem = new ToolStripMenuItem();
            comicSansMSToolStripMenuItem = new ToolStripMenuItem();
            georgiaToolStripMenuItem = new ToolStripMenuItem();
            microsoftHimalayaToolStripMenuItem = new ToolStripMenuItem();
            verdanaToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 40);
            textBox1.MaxLength = 1;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1153, 604);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1, toolStripStatusLabel2, CurrentLengthValue, toolStripStatusLabel3, MaxLengthValue, toolStripStatusLabel4, DigitValue, toolStripStatusLabel6, LetterValue, toolStripStatusLabel5, wordValue, toolStripSplitButton1 });
            statusStrip1.Location = new Point(0, 594);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1134, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.TextChanged += statusStrip1_TextChanged;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(58, 17);
            toolStripStatusLabel1.Text = "Symbols :";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(76, 17);
            toolStripStatusLabel2.Text = "Max length : ";
            // 
            // CurrentLengthValue
            // 
            CurrentLengthValue.Name = "CurrentLengthValue";
            CurrentLengthValue.Size = new Size(13, 17);
            CurrentLengthValue.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(12, 17);
            toolStripStatusLabel3.Text = "/";
            // 
            // MaxLengthValue
            // 
            MaxLengthValue.Name = "MaxLengthValue";
            MaxLengthValue.Size = new Size(13, 17);
            MaxLengthValue.Text = "1";
            MaxLengthValue.OwnerChanged += MaxLengthValue_OwnerChanged;
            MaxLengthValue.TextChanged += MaxLengthValue_TextChanged_1;
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(61, 17);
            toolStripStatusLabel4.Text = "     Digits : ";
            // 
            // DigitValue
            // 
            DigitValue.Name = "DigitValue";
            DigitValue.Size = new Size(13, 17);
            DigitValue.Text = "0";
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new Size(63, 17);
            toolStripStatusLabel6.Text = "     Letters :";
            // 
            // LetterValue
            // 
            LetterValue.Name = "LetterValue";
            LetterValue.Size = new Size(13, 17);
            LetterValue.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(62, 17);
            toolStripStatusLabel5.Text = "     Words :";
            // 
            // wordValue
            // 
            wordValue.Name = "wordValue";
            wordValue.Size = new Size(13, 17);
            wordValue.Text = "0";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { textColorToolStripMenuItem, wordWrapToolStripMenuItem, settingsToolStripMenuItem, fontToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(65, 20);
            toolStripSplitButton1.Text = "Settings";
            // 
            // textColorToolStripMenuItem
            // 
            textColorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { greenToolStripMenuItem, redToolStripMenuItem, blueToolStripMenuItem, yellowToolStripMenuItem, blackToolStripMenuItem, cyanToolStripMenuItem, grayToolStripMenuItem });
            textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            textColorToolStripMenuItem.Size = new Size(134, 22);
            textColorToolStripMenuItem.Text = "Text color";
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(108, 22);
            greenToolStripMenuItem.Text = "Green";
            greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(108, 22);
            redToolStripMenuItem.Text = "Red";
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(108, 22);
            blueToolStripMenuItem.Text = "Blue";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // yellowToolStripMenuItem
            // 
            yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            yellowToolStripMenuItem.Size = new Size(108, 22);
            yellowToolStripMenuItem.Text = "Yellow";
            yellowToolStripMenuItem.Click += yellowToolStripMenuItem_Click;
            // 
            // blackToolStripMenuItem
            // 
            blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            blackToolStripMenuItem.Size = new Size(108, 22);
            blackToolStripMenuItem.Text = "Black";
            blackToolStripMenuItem.Click += blackToolStripMenuItem_Click;
            // 
            // cyanToolStripMenuItem
            // 
            cyanToolStripMenuItem.Name = "cyanToolStripMenuItem";
            cyanToolStripMenuItem.Size = new Size(108, 22);
            cyanToolStripMenuItem.Text = "Cyan";
            cyanToolStripMenuItem.Click += cyanToolStripMenuItem_Click;
            // 
            // grayToolStripMenuItem
            // 
            grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            grayToolStripMenuItem.Size = new Size(108, 22);
            grayToolStripMenuItem.Text = "Gray";
            grayToolStripMenuItem.Click += grayToolStripMenuItem_Click;
            // 
            // wordWrapToolStripMenuItem
            // 
            wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            wordWrapToolStripMenuItem.Size = new Size(134, 22);
            wordWrapToolStripMenuItem.Text = "Word Wrap";
            wordWrapToolStripMenuItem.Click += wordWrapToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { boldToolStripMenuItem, sizeToolStripMenuItem, sizeToolStripMenuItem1 });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(134, 22);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.Size = new Size(113, 22);
            boldToolStripMenuItem.Text = "Bold";
            boldToolStripMenuItem.Click += boldToolStripMenuItem_Click;
            // 
            // sizeToolStripMenuItem
            // 
            sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            sizeToolStripMenuItem.Size = new Size(113, 22);
            sizeToolStripMenuItem.Text = "Size ++";
            sizeToolStripMenuItem.Click += sizeToolStripMenuItem_Click;
            // 
            // sizeToolStripMenuItem1
            // 
            sizeToolStripMenuItem1.Name = "sizeToolStripMenuItem1";
            sizeToolStripMenuItem1.Size = new Size(113, 22);
            sizeToolStripMenuItem1.Text = "Size --";
            sizeToolStripMenuItem1.Click += sizeToolStripMenuItem1_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arialToolStripMenuItem, calibriToolStripMenuItem, comicSansMSToolStripMenuItem, georgiaToolStripMenuItem, microsoftHimalayaToolStripMenuItem, verdanaToolStripMenuItem });
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(134, 22);
            fontToolStripMenuItem.Text = "Font";
            // 
            // arialToolStripMenuItem
            // 
            arialToolStripMenuItem.Name = "arialToolStripMenuItem";
            arialToolStripMenuItem.Size = new Size(178, 22);
            arialToolStripMenuItem.Text = "Arial";
            arialToolStripMenuItem.Click += arialToolStripMenuItem_Click;
            // 
            // calibriToolStripMenuItem
            // 
            calibriToolStripMenuItem.Name = "calibriToolStripMenuItem";
            calibriToolStripMenuItem.Size = new Size(178, 22);
            calibriToolStripMenuItem.Text = "Calibri";
            calibriToolStripMenuItem.Click += calibriToolStripMenuItem_Click;
            // 
            // comicSansMSToolStripMenuItem
            // 
            comicSansMSToolStripMenuItem.Name = "comicSansMSToolStripMenuItem";
            comicSansMSToolStripMenuItem.Size = new Size(178, 22);
            comicSansMSToolStripMenuItem.Text = "Comic Sans MS";
            comicSansMSToolStripMenuItem.Click += comicSansMSToolStripMenuItem_Click;
            // 
            // georgiaToolStripMenuItem
            // 
            georgiaToolStripMenuItem.Name = "georgiaToolStripMenuItem";
            georgiaToolStripMenuItem.Size = new Size(178, 22);
            georgiaToolStripMenuItem.Text = "Georgia";
            georgiaToolStripMenuItem.Click += georgiaToolStripMenuItem_Click;
            // 
            // microsoftHimalayaToolStripMenuItem
            // 
            microsoftHimalayaToolStripMenuItem.Name = "microsoftHimalayaToolStripMenuItem";
            microsoftHimalayaToolStripMenuItem.Size = new Size(178, 22);
            microsoftHimalayaToolStripMenuItem.Text = "Microsoft Himalaya";
            microsoftHimalayaToolStripMenuItem.Click += microsoftHimalayaToolStripMenuItem_Click;
            // 
            // verdanaToolStripMenuItem
            // 
            verdanaToolStripMenuItem.Name = "verdanaToolStripMenuItem";
            verdanaToolStripMenuItem.Size = new Size(178, 22);
            verdanaToolStripMenuItem.Text = "Verdana";
            verdanaToolStripMenuItem.Click += verdanaToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(221, 38);
            label1.TabIndex = 3;
            label1.Text = "Max symbols :";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Location = new Point(214, 1);
            numericUpDown1.Maximum = new decimal(new int[] { 280, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(72, 36);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 616);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(textBox1);
            Name = "MainForm";
            Text = "Form1";
            TextChanged += Form1_TextChanged;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel CurrentLengthValue;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel MaxLengthValue;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel DigitValue;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripStatusLabel LetterValue;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem textColorToolStripMenuItem;
        private ToolStripMenuItem wordWrapToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem yellowToolStripMenuItem;
        private ToolStripMenuItem blackToolStripMenuItem;
        private ToolStripMenuItem cyanToolStripMenuItem;
        private ToolStripMenuItem grayToolStripMenuItem;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem sizeToolStripMenuItem;
        private ToolStripMenuItem arialToolStripMenuItem;
        private ToolStripMenuItem calibriToolStripMenuItem;
        private ToolStripMenuItem comicSansMSToolStripMenuItem;
        private ToolStripMenuItem georgiaToolStripMenuItem;
        private ToolStripMenuItem microsoftHimalayaToolStripMenuItem;
        private ToolStripMenuItem verdanaToolStripMenuItem;
        private ToolStripMenuItem sizeToolStripMenuItem1;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel wordValue;
    }
}