using Microsoft.VisualBasic.Logging;
using System.DirectoryServices.ActiveDirectory;
using System.Runtime.Intrinsics.Arm;
using System;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.FileIO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Linq.Expressions;
using System.IO;
using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private ImageList tmpIList;
        private string rootPath;
        private readonly DialogForm dialog;

        private bool treeViewSelected = false;
        private bool listViewSelected = false;

        private bool listViewFocus = false;
        private bool treeViewFocus = true;
        private readonly TreeNode root;

        public MainForm()
        {
            tmpIList = new();
            rootPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog = new();
            InitializeComponent();
            root = new TreeNode(Path.GetFileNameWithoutExtension(rootPath))
            {
                Tag = rootPath,
                ImageIndex = 0
            };
            root.Expand();
            treeView.Nodes.Add(root);

            LoadFolders(rootPath, root.Nodes, 2);
            rootTextBox.Text = rootPath;

        }

        private void LoadFolders(string? path, TreeNodeCollection collection, int level)
        {
            if (path == null) return;
            DirectoryInfo[]? dInfos = null;
            DirectoryInfo currentDir = new(path);
            try { dInfos = currentDir.GetDirectories(); } catch { }
            if (dInfos?.Length > 0)
            {
                foreach (var dir in dInfos)
                {
                    if (!visibleCheckBox.Checked && dir.Attributes.HasFlag(FileAttributes.Hidden)) continue;
                    TreeNode node = new(dir.Name);
                    node.Tag = dir.FullName;
                    collection.Add(node);
                    try
                    {
                        if (level > 1 && dir.GetDirectories().Any())
                            LoadFolders(dir.FullName, node.Nodes, level - 1);
                    }
                    catch { }
                }
            }
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 1;
            e.Node.SelectedImageIndex = e.Node.ImageIndex;
            foreach (TreeNode item in e.Node.Nodes)
                LoadFolders(item.Tag.ToString(), item.Nodes, 1);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                root.Nodes.Clear();
                treeViewSelected = false;
                LoadFolders(fbd.SelectedPath, root.Nodes, 2);
                rootPath = fbd.SelectedPath;
                rootTextBox.Text = rootPath;
                string tmp = Path.GetFileNameWithoutExtension(rootPath);
                root.Text = tmp == "" ? rootPath : tmp;
                root.Tag = rootPath;
                treeView_AfterSelect(root, new TreeViewEventArgs(root));
            }
        }

        private void treeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node != null)
            {
                e.Node.ImageIndex = 0;
                e.Node.SelectedImageIndex = e.Node.ImageIndex;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fileListView.SelectedItems.Count > 0)
            {
                listViewSelected = true;
                ButtonsEnable();
                ListViewItem lvi = fileListView.SelectedItems[0];
                fileIconPictureBox.Image = fileImageListLarge.Images[lvi.ImageIndex];
                FileInfo fi = new(Path.Combine(lvi.Tag.ToString() ?? "", lvi.Text));
                nameLabel.Text = $"{nameLabel.Tag}  \"{Path.GetFileNameWithoutExtension(fi.Name)}\"";
                extLabel.Text = $"{extLabel.Tag}  \"{(Path.GetExtension(fi.Name).Length > 0 ? Path.GetExtension(fi.Name)[1..].ToUpper() : " ")}\"";
                pathLabel.Text = $"{pathLabel.Tag}  \"{fi.Directory?.FullName}\"";
                (double, string) val = getSizeFormat(fi.Length);
                sizeLabel.Text = $"{sizeLabel.Tag}  {val.Item1} {val.Item2}";
                lastATimeLabel.Text = $"{lastATimeLabel.Tag}  {fi.LastAccessTime}";
                lastMTimeLAble.Text = $"{lastMTimeLAble.Tag}  {fi.LastWriteTime}";
            }
            else clearInfoWindow();
        }

        private void addToolStripButton_Click(object sender, EventArgs e)
        {
            string tmpPath = treeView.SelectedNode.Tag.ToString() ?? "";
            if (dialog.ShowDialog(tmpPath, DialogAction.Create) == DialogResult.OK)
            {
                tmpPath = Path.Combine(tmpPath, dialog.Result ?? "");
                try
                {
                    Directory.CreateDirectory(tmpPath);
                    TreeNode tmp = new()
                    {
                        Text = dialog.Result,
                        Tag = tmpPath,
                        ImageIndex = 0
                    };
                    treeView.SelectedNode.Nodes.Add(tmp);
                }
                catch { MessageBox.Show("Unable to create folder"); }
            }

        }

        private void toolStripButtons_Click(object sender, EventArgs e)
        {
            string? name = null, tmpPath = null, mbString;
            ToolStripButton? toolStripButton = sender as ToolStripButton;
            Action? action, folderAction, fileAction;
            switch (toolStripButton?.Name)
            {
                case "delToolStripButton":
                    fileAction = () =>
                    {
                        File.Delete(Path.Combine(tmpPath ?? "", name ?? ""));
                        fileListView.Items.Remove(fileListView.SelectedItems[0]);
                    };
                    folderAction = () =>
                    {
                        Directory.Delete(tmpPath ?? "", true);
                        if (treeView.SelectedNode?.Parent?.Nodes.Count == 1)
                            treeView.SelectedNode.Parent.ImageIndex = 0;
                        treeView.SelectedNode?.Parent.Nodes.Remove(treeView.SelectedNode);
                    };
                    mbString = "Delete";
                    break;

                case "renameToolStripButton":
                    fileAction = () =>
                    {
                        if (dialog.ShowDialog(tmpPath, DialogAction.Rename) != DialogResult.OK) return;
                        File.Move(Path.Combine(tmpPath ?? "", name ?? ""), Path.Combine(tmpPath ?? "", dialog.Result ?? ""));
                        fileListView.SelectedItems[0].Text = dialog.Result;
                        fileListView.SelectedItems[0].ImageIndex = getImageIndex(Path.GetExtension(dialog.Result ?? ""));
                    };
                    folderAction = () =>
                    {
                        if (dialog.ShowDialog(tmpPath, DialogAction.Rename) != DialogResult.OK) return;
                        FileSystem.RenameDirectory(tmpPath ?? "", dialog.Result ?? "");
                        treeView.SelectedNode.Text = dialog.Result;
                        treeView.SelectedNode.Tag = Path.Combine(treeView.SelectedNode.Parent.Tag.ToString() ?? "", dialog.Result ?? "");
                    };
                    mbString = "Rename";
                    break;

                case "copyToolStripButton":
                    fileAction = () =>
                    {
                        string ext = Path.GetExtension(fileListView.SelectedItems[0].Text);
                        SaveFileDialog saveFileDialog = new()
                        {
                            Filter = $"{ext[1..]} files (*{ext})|*{ext}",
                            RestoreDirectory = true,
                            FileName = name
                        };
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            File.Copy(Path.Combine(tmpPath ?? "", name ?? ""), saveFileDialog.FileName ?? "", true);
                    };
                    folderAction = () =>
                    {
                        FolderBrowserDialog fbd = new();
                        if (fbd.ShowDialog() != DialogResult.OK) return;
                        FileSystem.CopyDirectory(tmpPath ?? "", Path.Combine(fbd.SelectedPath, name ?? ""), UIOption.AllDialogs, UICancelOption.DoNothing);
                    };
                    mbString = "Copy";
                    break;

                default: return;
            }


            if (treeViewFocus)
            {
                name = treeView.SelectedNode.Text;
                tmpPath = treeView.SelectedNode.Tag.ToString();
                action = folderAction;
            }
            else if (listViewFocus)
            {
                name = fileListView.SelectedItems[0].Text;
                tmpPath = fileListView.SelectedItems[0].Tag?.ToString();
                action = fileAction;
            }
            else return;


            if (MessageBox.Show($"Are you sure you want to {mbString} \"{name}\"", mbString, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try { action.Invoke(); }
                catch (Exception ex) { MessageBox.Show($"Unable to {mbString} \"{name}\"\n {ex.Message}", mbString); }
        }

        private void viewToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tileIconSizeToolStripComboBox.Enabled = viewToolStripComboBox.Text == "Tile";
            fileListView.LargeImageList = tileIconSizeToolStripComboBox.Enabled ? tmpIList : fileImageListLarge;
            if (viewToolStripComboBox.Text == "Details") detailsListSet();
            fileListView.View = Enum.Parse<View>(viewToolStripComboBox.Text);
        }

        private void fileListView_Enter(object sender, EventArgs e)
        {
            listViewFocus = true;
            treeViewFocus = false;
            ButtonsEnable();
        }

        private void treeView_Enter(object sender, EventArgs e)
        {
            treeViewFocus = true;
            listViewFocus = false;
            ButtonsEnable();
        }

        private void ButtonsEnable()
        {
            delToolStripButton.Enabled = (treeViewFocus && treeViewSelected)
                    || (listViewFocus && listViewSelected);
            renameToolStripButton.Enabled = delToolStripButton.Enabled;
        }

        private int getImageIndex(string ext)
        {
            return ext switch
            {
                ".csproj" or ".sln" or ".cs" or ".cpp" or ".c" => 10,
                ".fb2" => 6,
                ".doc" or ".docx" => 7,
                ".rtf" => 9,
                ".pdf" => 8,
                ".txt" => 1,
                ".rar" or ".zip" or ".7z" or ".cab" => 4,
                ".psd" => 5,
                ".jpg" or ".jpeg" or ".png" or ".bmp" => 2,
                ".mp4" or ".wmv" or ".mpeg" or ".avi" => 3,
                ".wma" or ".wav" or ".mp3" => 11,
                ".djvu" => 12,
                _ => 0,
            };
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeViewSelected = treeView.SelectedNode.Tag.ToString() != root.Tag.ToString();
            ButtonsEnable();
            e.Node.SelectedImageIndex = e.Node.ImageIndex;
            DirectoryInfo dInfo = new(e.Node.Tag.ToString() ?? "");
            try
            {
                FileInfo[] fInfo = dInfo.GetFiles();
                fileListView.Items.Clear();
                clearInfoWindow();
                listViewSelected = false;
                foreach (var item in fInfo)
                {
                    if (!visibleCheckBox.Checked && item.Attributes.HasFlag(FileAttributes.Hidden)) continue;
                    ListViewItem item2 = new(item.Name)
                    {
                        ImageIndex = getImageIndex(item.Extension),
                        Tag = item.Directory
                    };

                    fileListView.Items.Add(item2);
                }
            }
            catch { }
            if (viewToolStripComboBox.Text == "Details") detailsListSet();
        }

        private void visibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            DirectoryInfo dInfo = new(root.Tag.ToString() ?? "");
            if (dInfo.Exists && dInfo.GetDirectories().Any(n => n.Attributes.HasFlag(FileAttributes.Hidden)))
            {
                root.Nodes.Clear();
                LoadFolders(rootPath, root.Nodes, 2);
                treeView.SelectedNode = root;
                treeView.Select();
            }
            else
            {
                dInfo = new(treeView.SelectedNode.Tag.ToString() ?? "");
                if (!dInfo.Exists || !dInfo.GetFiles().Any(n => n.Attributes.HasFlag(FileAttributes.Hidden))) return;
            }
            treeView_AfterSelect(sender, new TreeViewEventArgs(treeView.SelectedNode));
        }

        private void detailsListSet()
        {
            string[] exp = { "B", "Kb", "Mb", "Gb" };
            int i;
            FileInfo fi;
            foreach (ListViewItem item in fileListView.Items)
            {
                fi = new FileInfo(Path.Combine(item.Tag.ToString() ?? "", item.Text));
                item.SubItems.Add($"File \"{(fi.Extension.Length > 0 ? fi.Extension[1..].ToUpper() : "")}\"");
                item.SubItems.Add($"{fi.LastWriteTime}");

                (double, string) val = getSizeFormat(fi.Length);
                item.SubItems.Add($"{val.Item1} {val.Item2}");
            }
        }

        private void tileIconSizeToolStripComboBox_TextChanged(object sender, EventArgs e)
        {
            tmpIList = new();
            tmpIList.ImageSize = new(tileIconSizeToolStripComboBox.SelectedIndex * 4 + 16, tileIconSizeToolStripComboBox.SelectedIndex * 4 + 16);
            tmpIList.ColorDepth = ColorDepth.Depth32Bit;
            foreach (Image item in fileImageListLarge.Images)
                tmpIList.Images.Add(item);
            fileListView.LargeImageList = tmpIList;
        }

        private void clearInfoWindow()
        {
            nameLabel.Text = nameLabel.Tag?.ToString();
            extLabel.Text = extLabel.Tag?.ToString();
            pathLabel.Text = pathLabel.Tag?.ToString();
            sizeLabel.Text = sizeLabel.Tag?.ToString();
            lastATimeLabel.Text = lastATimeLabel.Tag?.ToString();
            lastMTimeLAble.Text = lastMTimeLAble.Tag?.ToString();
        }

        private (double, string) getSizeFormat(decimal size)
        {
            string[] exp = { "B", "Kb", "Mb", "Gb" };
            int i;

            for (i = 0; i < exp.Length; i++)
            {
                if (size < 1024) break;
                else size = size / 1024;
            }
            return ((double)Math.Round(size, 2), exp[i]);
        }
    }
}