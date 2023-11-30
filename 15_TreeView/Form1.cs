using Microsoft.VisualBasic;
using System.Xml.Linq;

namespace _15_TreeView
{
    public partial class Form1 : Form
    {
        string DirPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Form1()
        {
            InitializeComponent();
            dirTree.Nodes.Clear();
            fileList.View = View.Details;
            fileList.Columns.Add("Name").Width = 150;
            fileList.Columns.Add("Extencion", 150);
            fileList.Columns.Add("Ctreate Time", 150);
            //Load directories
            LoadDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), dirTree.Nodes);

        }
        void LoadDirectories(string dirPath, TreeNodeCollection nodes)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(dirPath);

            foreach (var subDir in directoryInfo.GetDirectories())
            {
                TreeNode newNode = new TreeNode(subDir.Name);
                newNode.Tag = subDir.FullName;
                nodes.Add(newNode);
                //dirTree.Nodes.Add(subDir.Name);
                if (subDir.GetDirectories().Length > 0)
                {
                    LoadDirectories(subDir.FullName, newNode.Nodes);
                }
            }
        }

        private void dirTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(e.Node.Tag.ToString());
            fileList.Items.Clear();
            DirectoryInfo directory = new DirectoryInfo(e.Node.Tag.ToString());
            foreach (var item in directory.GetFiles())
            {
                ListViewItem items = new ListViewItem(item.Name);
                items.SubItems.Add(item.Extension);
                items.SubItems.Add(item.CreationTime.ToString());

                fileList.Items.Add(items);
            }
            //fileList.Items.Add();
        }

        private void CreateFolderBtn_Click(object sender, EventArgs e)
        {

            string selectedDir = dirTree.SelectedNode?.Tag as string;

            if (!string.IsNullOrEmpty(selectedDir))
            {
                string newFolderName = "NewFolder";
                string newFolderPath = Path.Combine(selectedDir, newFolderName);
                if (!Directory.Exists(newFolderPath))
                {
                    Directory.CreateDirectory(newFolderPath);

                    dirTree.SelectedNode.Nodes.Clear();
                    LoadDirectories(selectedDir, dirTree.SelectedNode.Nodes);

                    fileList.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Folder already exists!");
                }
            }
            else
            {
                MessageBox.Show("Please select a directory in the tree view.");
            }
        }

        private void DeleteFolderBtn_Click(object sender, EventArgs e)
        {
            string selectedDir = dirTree.SelectedNode?.Tag as string;
            if (!string.IsNullOrEmpty(selectedDir))
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the folder '{selectedDir}' and its contents?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Directory.Delete(selectedDir, true);
                        dirTree.SelectedNode.Remove();
                        fileList.Items.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a directory in the tree view.");
            }
        }

        private void CreateTextFileBtn_Click(object sender, EventArgs e)
        {
            string selectedDir = dirTree.SelectedNode?.Tag as string;
            if (!string.IsNullOrEmpty(selectedDir))
            {
                string newFileName = "NewTextFile.txt";
                string newFilePath = Path.Combine(selectedDir, newFileName);
                if (!File.Exists(newFilePath))
                {
                    try
                    {
                        File.WriteAllText(newFilePath, "Hello");
                        fileList.Items.Clear();
                        DirectoryInfo directory = new DirectoryInfo(selectedDir);
                        foreach (var item in directory.GetFiles())
                        {
                            ListViewItem items = new ListViewItem(item.Name);
                            items.SubItems.Add(item.Extension);
                            items.SubItems.Add(item.CreationTime.ToString());

                            fileList.Items.Add(items);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error creating text file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Text file already exists!");
                }
            }
            else
            {
                MessageBox.Show("Please select a directory in the tree view.");
            }
        }

        private void EditTextFileBtn_Click(object sender, EventArgs e)
        {
            string selectedDir = dirTree.SelectedNode?.Tag as string;
            ListViewItem selectedItem = fileList.SelectedItems.Count > 0 ? fileList.SelectedItems[0] : null;

            if (!string.IsNullOrEmpty(selectedDir) && selectedItem != null)
            {
                string fileName = selectedItem.SubItems[0].Text;
                string filePath = Path.Combine(selectedDir, fileName);

                if (File.Exists(filePath))
                {
                    try
                    {
                        string existingContent = File.ReadAllText(filePath);
                        string editedContent = Interaction.InputBox("Edit the text:", "Edit Text", existingContent);
                        File.WriteAllText(filePath, editedContent);
                        fileList.Items.Clear();
                        DirectoryInfo directory = new DirectoryInfo(selectedDir);
                        foreach (var item in directory.GetFiles())
                        {
                            ListViewItem items = new ListViewItem(item.Name);
                            items.SubItems.Add(item.Extension);
                            items.SubItems.Add(item.CreationTime.ToString());

                            fileList.Items.Add(items);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error editing text file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selected file does not exist!");
                }
            }
            else
            {
                MessageBox.Show("Please select a directory in the tree view and a file in the list.");
            }
        }

        private void DeleteFileBtn_Click(object sender, EventArgs e)
        {
            string selectedDir = dirTree.SelectedNode?.Tag as string;
            ListViewItem selectedItem = fileList.SelectedItems.Count > 0 ? fileList.SelectedItems[0] : null;
            if (!string.IsNullOrEmpty(selectedDir) && selectedItem != null)
            {
                string fileName = selectedItem.SubItems[0].Text;
                string filePath = Path.Combine(selectedDir, fileName);

                if (File.Exists(filePath))
                {
                    try
                    {
                        File.Delete(filePath);
                        fileList.Items.Clear();
                        DirectoryInfo directory = new DirectoryInfo(selectedDir);
                        foreach (var item in directory.GetFiles())
                        {
                            ListViewItem items = new ListViewItem(item.Name);
                            items.SubItems.Add(item.Extension);
                            items.SubItems.Add(item.CreationTime.ToString());

                            fileList.Items.Add(items);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selected file does not exist!");
                }
            }
            else
            {
                MessageBox.Show("Please select a directory in the tree view and a file in the list.");
            }
        }
        //void LoadImageList()
        //{
        //    ImageList images = new ImageList(); 
        //    images.Images.Add(new Bitmap("filename.format"));
        //    images.Images.Add(new Bitmap("filename.format"));
        //    images.Images.Add(new Bitmap("filename.format"));
        //    images.Images.Add(new Bitmap("filename.format"));
        //    images.Images.Add(new Bitmap("filename.format"));

        //    dirTree.ImageList = images;
        //}
    }
}