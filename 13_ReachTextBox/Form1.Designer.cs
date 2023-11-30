namespace _13_ReachTextBox
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
            richTextBox1 = new RichTextBox();
            ChangeSelectedFontBtn = new Button();
            ChangeSelectedColorBtn = new Button();
            ChangeSelectedBackgroundColorBtn = new Button();
            IndentLeftBtn = new Button();
            IndentRightBtn = new Button();
            checkBox1 = new CheckBox();
            SaveBtn = new Button();
            LoadBtn = new Button();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            projectToolStripMenuItem = new ToolStripMenuItem();
            solutionToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            openAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            makeBulletToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            backgroundColorToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 120);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(799, 330);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // ChangeSelectedFontBtn
            // 
            ChangeSelectedFontBtn.Location = new Point(0, 46);
            ChangeSelectedFontBtn.Name = "ChangeSelectedFontBtn";
            ChangeSelectedFontBtn.Size = new Size(75, 67);
            ChangeSelectedFontBtn.TabIndex = 1;
            ChangeSelectedFontBtn.Text = "Change Selected font";
            ChangeSelectedFontBtn.UseVisualStyleBackColor = true;
            ChangeSelectedFontBtn.Click += ChangeSelectedFontBtn_Click;
            // 
            // ChangeSelectedColorBtn
            // 
            ChangeSelectedColorBtn.Location = new Point(81, 46);
            ChangeSelectedColorBtn.Name = "ChangeSelectedColorBtn";
            ChangeSelectedColorBtn.Size = new Size(75, 67);
            ChangeSelectedColorBtn.TabIndex = 2;
            ChangeSelectedColorBtn.Text = "Change Selected Color";
            ChangeSelectedColorBtn.UseVisualStyleBackColor = true;
            ChangeSelectedColorBtn.Click += ChangeSelectedColorBtn_Click;
            // 
            // ChangeSelectedBackgroundColorBtn
            // 
            ChangeSelectedBackgroundColorBtn.Location = new Point(162, 36);
            ChangeSelectedBackgroundColorBtn.Name = "ChangeSelectedBackgroundColorBtn";
            ChangeSelectedBackgroundColorBtn.Size = new Size(75, 77);
            ChangeSelectedBackgroundColorBtn.TabIndex = 3;
            ChangeSelectedBackgroundColorBtn.Text = "Change Selected Background Color";
            ChangeSelectedBackgroundColorBtn.UseVisualStyleBackColor = true;
            ChangeSelectedBackgroundColorBtn.Click += ChangeSelectedBackgroundColorBtn_Click;
            // 
            // IndentLeftBtn
            // 
            IndentLeftBtn.Location = new Point(243, 64);
            IndentLeftBtn.Name = "IndentLeftBtn";
            IndentLeftBtn.Size = new Size(75, 49);
            IndentLeftBtn.TabIndex = 4;
            IndentLeftBtn.Text = "Indent left";
            IndentLeftBtn.UseVisualStyleBackColor = true;
            IndentLeftBtn.Click += IndentLeftBtn_Click;
            // 
            // IndentRightBtn
            // 
            IndentRightBtn.Location = new Point(324, 64);
            IndentRightBtn.Name = "IndentRightBtn";
            IndentRightBtn.Size = new Size(75, 49);
            IndentRightBtn.TabIndex = 5;
            IndentRightBtn.Text = "Ident Right";
            IndentRightBtn.UseVisualStyleBackColor = true;
            IndentRightBtn.Click += IndentRightBtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(435, 80);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Make bullet";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(654, 64);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(62, 49);
            SaveBtn.TabIndex = 7;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(722, 64);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(66, 46);
            LoadBtn.TabIndex = 8;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, openToolStripMenuItem, openAsToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, projectToolStripMenuItem, solutionToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(190, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(118, 22);
            fileToolStripMenuItem1.Text = "File";
            // 
            // projectToolStripMenuItem
            // 
            projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            projectToolStripMenuItem.Size = new Size(118, 22);
            projectToolStripMenuItem.Text = "Project";
            // 
            // solutionToolStripMenuItem
            // 
            solutionToolStripMenuItem.Name = "solutionToolStripMenuItem";
            solutionToolStripMenuItem.Size = new Size(118, 22);
            solutionToolStripMenuItem.Text = "Solution";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(190, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(190, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(190, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // openAsToolStripMenuItem
            // 
            openAsToolStripMenuItem.Name = "openAsToolStripMenuItem";
            openAsToolStripMenuItem.Size = new Size(190, 22);
            openAsToolStripMenuItem.Text = "Open as";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(187, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.Shift | Keys.A;
            exitToolStripMenuItem.Size = new Size(190, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, copyToolStripMenuItem, cutToolStripMenuItem, deleteToolStripMenuItem, pasteToolStripMenuItem, makeBulletToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(180, 22);
            undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(180, 22);
            redoToolStripMenuItem.Text = "Redo";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(180, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(180, 22);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(180, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // makeBulletToolStripMenuItem
            // 
            makeBulletToolStripMenuItem.CheckOnClick = true;
            makeBulletToolStripMenuItem.Name = "makeBulletToolStripMenuItem";
            makeBulletToolStripMenuItem.Size = new Size(180, 22);
            makeBulletToolStripMenuItem.Text = "Make Bullet";
            makeBulletToolStripMenuItem.CheckedChanged += makeBulletToolStripMenuItem_CheckedChanged;
            makeBulletToolStripMenuItem.Click += makeBulletToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, colorToolStripMenuItem, backgroundColorToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "Format";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(168, 22);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += toolStripButton1_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(168, 22);
            colorToolStripMenuItem.Text = "Color";
            // 
            // backgroundColorToolStripMenuItem
            // 
            backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            backgroundColorToolStripMenuItem.Size = new Size(168, 22);
            backgroundColorToolStripMenuItem.Text = "Background color";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(LoadBtn);
            Controls.Add(SaveBtn);
            Controls.Add(checkBox1);
            Controls.Add(IndentRightBtn);
            Controls.Add(IndentLeftBtn);
            Controls.Add(ChangeSelectedBackgroundColorBtn);
            Controls.Add(ChangeSelectedColorBtn);
            Controls.Add(ChangeSelectedFontBtn);
            Controls.Add(richTextBox1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button ChangeSelectedFontBtn;
        private Button ChangeSelectedColorBtn;
        private Button ChangeSelectedBackgroundColorBtn;
        private Button IndentLeftBtn;
        private Button IndentRightBtn;
        private CheckBox checkBox1;
        private Button SaveBtn;
        private Button LoadBtn;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem solutionToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem openAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem backgroundColorToolStripMenuItem;
        private ToolStripMenuItem makeBulletToolStripMenuItem;
    }
}