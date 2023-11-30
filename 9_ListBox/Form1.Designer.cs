namespace _9_ListBox
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
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            checkedListBox1 = new CheckedListBox();
            MoveLeftBtn = new Button();
            MoveRightBtn = new Button();
            textBox1 = new TextBox();
            AddBtn = new Button();
            ShowBtn = new Button();
            button5 = new Button();
            DeleteBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 64);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "List box";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(460, 64);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 1;
            label2.Text = "Checked list box";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Red", "Green", "Blue", "Yellow", "Cyan", "Purple", "Brown", "Black", "White", "Gray" });
            listBox1.Location = new Point(25, 82);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(228, 379);
            listBox1.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Red", "Green", "Blue", "Yellow", "Cyan", "Purple", "Brown", "Black", "White", "Gray" });
            checkedListBox1.Location = new Point(451, 82);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(283, 310);
            checkedListBox1.TabIndex = 3;
            // 
            // MoveLeftBtn
            // 
            MoveLeftBtn.Location = new Point(312, 255);
            MoveLeftBtn.Name = "MoveLeftBtn";
            MoveLeftBtn.Size = new Size(75, 23);
            MoveLeftBtn.TabIndex = 4;
            MoveLeftBtn.Text = "<---";
            MoveLeftBtn.UseVisualStyleBackColor = true;
            MoveLeftBtn.Click += MoveLeftBtn_Click;
            // 
            // MoveRightBtn
            // 
            MoveRightBtn.Location = new Point(312, 352);
            MoveRightBtn.Name = "MoveRightBtn";
            MoveRightBtn.Size = new Size(75, 23);
            MoveRightBtn.TabIndex = 5;
            MoveRightBtn.Text = "---->";
            MoveRightBtn.UseVisualStyleBackColor = true;
            MoveRightBtn.Click += MoveRightBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 477);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 6;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(229, 477);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(24, 23);
            AddBtn.TabIndex = 7;
            AddBtn.Text = "+";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // ShowBtn
            // 
            ShowBtn.Location = new Point(25, 513);
            ShowBtn.Name = "ShowBtn";
            ShowBtn.Size = new Size(109, 23);
            ShowBtn.TabIndex = 8;
            ShowBtn.Text = "Show selection";
            ShowBtn.UseVisualStyleBackColor = true;
            ShowBtn.Click += ShowBtn_Click;
            // 
            // button5
            // 
            button5.Location = new Point(140, 513);
            button5.Name = "button5";
            button5.Size = new Size(113, 23);
            button5.TabIndex = 9;
            button5.Text = "Remove selection";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(615, 416);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(119, 23);
            DeleteBtn.TabIndex = 10;
            DeleteBtn.Text = "Delete selection";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 551);
            Controls.Add(DeleteBtn);
            Controls.Add(button5);
            Controls.Add(ShowBtn);
            Controls.Add(AddBtn);
            Controls.Add(textBox1);
            Controls.Add(MoveRightBtn);
            Controls.Add(MoveLeftBtn);
            Controls.Add(checkedListBox1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private CheckedListBox checkedListBox1;
        private Button MoveLeftBtn;
        private Button MoveRightBtn;
        private TextBox textBox1;
        private Button AddBtn;
        private Button ShowBtn;
        private Button button5;
        private Button DeleteBtn;
    }
}