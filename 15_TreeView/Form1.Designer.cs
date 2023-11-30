namespace _15_TreeView
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
            TreeNode treeNode1 = new TreeNode("Node6");
            TreeNode treeNode2 = new TreeNode("Node5", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Child", new TreeNode[] { treeNode2 });
            TreeNode treeNode4 = new TreeNode("Node3");
            TreeNode treeNode5 = new TreeNode("Node4");
            TreeNode treeNode6 = new TreeNode("Node9");
            TreeNode treeNode7 = new TreeNode("Root", new TreeNode[] { treeNode3, treeNode4, treeNode5, treeNode6 });
            dirTree = new TreeView();
            fileList = new ListView();
            CreateFolderBtn = new Button();
            DeleteFolderBtn = new Button();
            CreateTextFileBtn = new Button();
            DeleteFileBtn = new Button();
            EditTextFileBtn = new Button();
            SuspendLayout();
            // 
            // dirTree
            // 
            dirTree.Location = new Point(0, -1);
            dirTree.Name = "dirTree";
            treeNode1.Name = "Node6";
            treeNode1.Text = "Node6";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Node5";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Child";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Node3";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Node4";
            treeNode6.Name = "Node9";
            treeNode6.Text = "Node9";
            treeNode7.BackColor = Color.FromArgb(255, 224, 192);
            treeNode7.ForeColor = Color.White;
            treeNode7.Name = "Node0";
            treeNode7.Text = "Root";
            dirTree.Nodes.AddRange(new TreeNode[] { treeNode7 });
            dirTree.Size = new Size(363, 451);
            dirTree.TabIndex = 0;
            dirTree.AfterSelect += dirTree_AfterSelect;
            // 
            // fileList
            // 
            fileList.Location = new Point(369, -1);
            fileList.Name = "fileList";
            fileList.Size = new Size(431, 451);
            fileList.TabIndex = 1;
            fileList.UseCompatibleStateImageBehavior = false;
            fileList.View = View.Tile;
            // 
            // CreateFolderBtn
            // 
            CreateFolderBtn.Location = new Point(12, 415);
            CreateFolderBtn.Name = "CreateFolderBtn";
            CreateFolderBtn.Size = new Size(170, 23);
            CreateFolderBtn.TabIndex = 2;
            CreateFolderBtn.Text = "CREATE FOLDER";
            CreateFolderBtn.UseVisualStyleBackColor = true;
            CreateFolderBtn.Click += CreateFolderBtn_Click;
            // 
            // DeleteFolderBtn
            // 
            DeleteFolderBtn.Location = new Point(188, 415);
            DeleteFolderBtn.Name = "DeleteFolderBtn";
            DeleteFolderBtn.Size = new Size(162, 23);
            DeleteFolderBtn.TabIndex = 3;
            DeleteFolderBtn.Text = "DELETE FOLDER";
            DeleteFolderBtn.UseVisualStyleBackColor = true;
            DeleteFolderBtn.Click += DeleteFolderBtn_Click;
            // 
            // CreateTextFileBtn
            // 
            CreateTextFileBtn.Location = new Point(385, 415);
            CreateTextFileBtn.Name = "CreateTextFileBtn";
            CreateTextFileBtn.Size = new Size(136, 23);
            CreateTextFileBtn.TabIndex = 4;
            CreateTextFileBtn.Text = "CREATE TXT. FILE";
            CreateTextFileBtn.UseVisualStyleBackColor = true;
            CreateTextFileBtn.Click += CreateTextFileBtn_Click;
            // 
            // DeleteFileBtn
            // 
            DeleteFileBtn.Location = new Point(666, 415);
            DeleteFileBtn.Name = "DeleteFileBtn";
            DeleteFileBtn.Size = new Size(122, 23);
            DeleteFileBtn.TabIndex = 5;
            DeleteFileBtn.Text = "DELETE FILE";
            DeleteFileBtn.UseVisualStyleBackColor = true;
            DeleteFileBtn.Click += DeleteFileBtn_Click;
            // 
            // EditTextFileBtn
            // 
            EditTextFileBtn.Location = new Point(527, 415);
            EditTextFileBtn.Name = "EditTextFileBtn";
            EditTextFileBtn.Size = new Size(133, 23);
            EditTextFileBtn.TabIndex = 6;
            EditTextFileBtn.Text = "EDIT TXT. FILE";
            EditTextFileBtn.UseVisualStyleBackColor = true;
            EditTextFileBtn.Click += EditTextFileBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EditTextFileBtn);
            Controls.Add(DeleteFileBtn);
            Controls.Add(CreateTextFileBtn);
            Controls.Add(DeleteFolderBtn);
            Controls.Add(CreateFolderBtn);
            Controls.Add(fileList);
            Controls.Add(dirTree);
            Name = "Form1";
            Text = "File";
            ResumeLayout(false);
        }

        #endregion

        private TreeView dirTree;
        private ListView fileList;
        private Button CreateFolderBtn;
        private Button DeleteFolderBtn;
        private Button CreateTextFileBtn;
        private Button DeleteFileBtn;
        private Button EditTextFileBtn;
    }
}