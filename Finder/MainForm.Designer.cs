﻿namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            folderImageList = new ImageList(components);
            fileImageListLarge = new ImageList(components);
            fileImageListSmall = new ImageList(components);
            treeView = new TreeView();
            fileListView = new ListView();
            NameColumnHeader = new ColumnHeader();
            extColumnHeader = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            sizeColumnHeader = new ColumnHeader();
            fileIconPictureBox = new PictureBox();
            groupBox1 = new GroupBox();
            lastATimeLabel = new Label();
            lastMTimeLAble = new Label();
            sizeLabel = new Label();
            pathLabel = new Label();
            extLabel = new Label();
            nameLabel = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            toolStrip1 = new ToolStrip();
            openToolStripButton = new ToolStripButton();
            addToolStripButton = new ToolStripButton();
            delToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            renameToolStripButton = new ToolStripButton();
            copyToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            viewToolStripComboBox = new ToolStripComboBox();
            toolStripSeparator3 = new ToolStripSeparator();
            tileSizetoolStripLabel = new ToolStripLabel();
            tileIconSizeToolStripComboBox = new ToolStripComboBox();
            label1 = new Label();
            rootTextBox = new TextBox();
            visibleCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)fileIconPictureBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // folderImageList
            // 
            folderImageList.ColorDepth = ColorDepth.Depth8Bit;
            folderImageList.ImageStream = (ImageListStreamer)resources.GetObject("folderImageList.ImageStream");
            folderImageList.TransparentColor = Color.Transparent;
            folderImageList.Images.SetKeyName(0, "folder.png");
            folderImageList.Images.SetKeyName(1, "opened_folder.png");
            // 
            // fileImageListLarge
            // 
            fileImageListLarge.ColorDepth = ColorDepth.Depth8Bit;
            fileImageListLarge.ImageStream = (ImageListStreamer)resources.GetObject("fileImageListLarge.ImageStream");
            fileImageListLarge.TransparentColor = Color.Transparent;
            fileImageListLarge.Images.SetKeyName(0, "icons8-file-48.png");
            fileImageListLarge.Images.SetKeyName(1, "icons8-edit-text-file-48.png");
            fileImageListLarge.Images.SetKeyName(2, "icons8-image-file-48.png");
            fileImageListLarge.Images.SetKeyName(3, "icons8-video-file-48.png");
            fileImageListLarge.Images.SetKeyName(4, "icons8-archive-48.png");
            fileImageListLarge.Images.SetKeyName(5, "icons8-adobe-photoshop-48.png");
            fileImageListLarge.Images.SetKeyName(6, "icons8-fb2-48.png");
            fileImageListLarge.Images.SetKeyName(7, "icons8-microsoft-word-2019-48.png");
            fileImageListLarge.Images.SetKeyName(8, "icons8-pdf-48.png");
            fileImageListLarge.Images.SetKeyName(9, "icons8-rtf-document-48.png");
            fileImageListLarge.Images.SetKeyName(10, "icons8-visual-studio-code-2019-48.png");
            fileImageListLarge.Images.SetKeyName(11, "Music_29918.png");
            fileImageListLarge.Images.SetKeyName(12, "icons8-book-48.png");
            // 
            // fileImageListSmall
            // 
            fileImageListSmall.ColorDepth = ColorDepth.Depth8Bit;
            fileImageListSmall.ImageStream = (ImageListStreamer)resources.GetObject("fileImageListSmall.ImageStream");
            fileImageListSmall.TransparentColor = Color.Transparent;
            fileImageListSmall.Images.SetKeyName(0, "icons8-file-48.png");
            fileImageListSmall.Images.SetKeyName(1, "icons8-edit-text-file-48.png");
            fileImageListSmall.Images.SetKeyName(2, "icons8-image-file-48.png");
            fileImageListSmall.Images.SetKeyName(3, "icons8-video-file-48.png");
            fileImageListSmall.Images.SetKeyName(4, "icons8-archive-48.png");
            fileImageListSmall.Images.SetKeyName(5, "icons8-adobe-photoshop-48.png");
            fileImageListSmall.Images.SetKeyName(6, "icons8-fb2-48.png");
            fileImageListSmall.Images.SetKeyName(7, "icons8-microsoft-word-2019-48.png");
            fileImageListSmall.Images.SetKeyName(8, "icons8-pdf-48.png");
            fileImageListSmall.Images.SetKeyName(9, "icons8-rtf-document-48.png");
            fileImageListSmall.Images.SetKeyName(10, "icons8-visual-studio-code-2019-48.png");
            fileImageListSmall.Images.SetKeyName(11, "Music_29918.png");
            fileImageListSmall.Images.SetKeyName(12, "icons8-book-48.png");
            // 
            // treeView
            // 
            treeView.HideSelection = false;
            treeView.ImageIndex = 0;
            treeView.ImageList = folderImageList;
            treeView.Location = new Point(24, 104);
            treeView.Name = "treeView";
            treeView.SelectedImageIndex = 0;
            treeView.Size = new Size(235, 365);
            treeView.StateImageList = fileImageListSmall;
            treeView.TabIndex = 0;
            treeView.BeforeCollapse += treeView_BeforeCollapse;
            treeView.BeforeExpand += treeView_BeforeExpand;
            treeView.AfterSelect += treeView_AfterSelect;
            treeView.Enter += treeView_Enter;
            // 
            // fileListView
            // 
            fileListView.Columns.AddRange(new ColumnHeader[] { NameColumnHeader, extColumnHeader, columnHeader1, sizeColumnHeader });
            fileListView.GridLines = true;
            fileListView.GroupImageList = fileImageListLarge;
            fileListView.LargeImageList = fileImageListLarge;
            fileListView.Location = new Point(6, 24);
            fileListView.MultiSelect = false;
            fileListView.Name = "fileListView";
            fileListView.Size = new Size(243, 365);
            fileListView.SmallImageList = fileImageListSmall;
            fileListView.Sorting = SortOrder.Ascending;
            fileListView.TabIndex = 1;
            fileListView.UseCompatibleStateImageBehavior = false;
            fileListView.View = View.Tile;
            fileListView.SelectedIndexChanged += listView1_SelectedIndexChanged;
            fileListView.Enter += fileListView_Enter;
            // 
            // NameColumnHeader
            // 
            NameColumnHeader.Text = "Name";
            NameColumnHeader.Width = 150;
            // 
            // extColumnHeader
            // 
            extColumnHeader.Text = "Type";
            extColumnHeader.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 3;
            columnHeader1.Text = "Last Change";
            columnHeader1.Width = 150;
            // 
            // sizeColumnHeader
            // 
            sizeColumnHeader.DisplayIndex = 2;
            sizeColumnHeader.Text = "Size";
            sizeColumnHeader.Width = 100;
            // 
            // fileIconPictureBox
            // 
            fileIconPictureBox.Location = new Point(97, 24);
            fileIconPictureBox.Name = "fileIconPictureBox";
            fileIconPictureBox.Size = new Size(48, 48);
            fileIconPictureBox.TabIndex = 4;
            fileIconPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lastATimeLabel);
            groupBox1.Controls.Add(lastMTimeLAble);
            groupBox1.Controls.Add(sizeLabel);
            groupBox1.Controls.Add(pathLabel);
            groupBox1.Controls.Add(extLabel);
            groupBox1.Controls.Add(nameLabel);
            groupBox1.Controls.Add(fileIconPictureBox);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(532, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 395);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "File information";
            // 
            // lastATimeLabel
            // 
            lastATimeLabel.AutoSize = true;
            lastATimeLabel.Location = new Point(11, 316);
            lastATimeLabel.Name = "lastATimeLabel";
            lastATimeLabel.Size = new Size(105, 17);
            lastATimeLabel.TabIndex = 10;
            lastATimeLabel.Tag = "Last access time:";
            lastATimeLabel.Text = "Last access time:";
            // 
            // lastMTimeLAble
            // 
            lastMTimeLAble.AutoSize = true;
            lastMTimeLAble.Location = new Point(11, 273);
            lastMTimeLAble.Name = "lastMTimeLAble";
            lastMTimeLAble.Size = new Size(107, 17);
            lastMTimeLAble.TabIndex = 9;
            lastMTimeLAble.Tag = "Last modify time:";
            lastMTimeLAble.Text = "Last modify time:";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new Point(11, 187);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(38, 17);
            sizeLabel.TabIndex = 8;
            sizeLabel.Tag = "Size :";
            sizeLabel.Text = "Size :";
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new Point(11, 230);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(40, 17);
            pathLabel.TabIndex = 7;
            pathLabel.Tag = "Path :";
            pathLabel.Text = "Path :";
            // 
            // extLabel
            // 
            extLabel.AutoSize = true;
            extLabel.Location = new Point(11, 144);
            extLabel.Name = "extLabel";
            extLabel.Size = new Size(70, 17);
            extLabel.TabIndex = 6;
            extLabel.Tag = "Extension :";
            extLabel.Text = "Extension :";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(11, 101);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(70, 17);
            nameLabel.TabIndex = 5;
            nameLabel.Tag = "File name :";
            nameLabel.Text = "File name :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(fileListView);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(271, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(255, 395);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Files";
            // 
            // groupBox3
            // 
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 80);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(253, 395);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Directories";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { openToolStripButton, addToolStripButton, delToolStripButton, toolStripSeparator1, renameToolStripButton, copyToolStripButton, toolStripSeparator2, toolStripLabel1, viewToolStripComboBox, toolStripSeparator3, tileSizetoolStripLabel, tileIconSizeToolStripComboBox });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(811, 39);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = Properties.Resources.folderaccess;
            openToolStripButton.ImageTransparentColor = Color.Magenta;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(36, 36);
            openToolStripButton.Text = "OpenFolder";
            openToolStripButton.Click += LoadButton_Click;
            // 
            // addToolStripButton
            // 
            addToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            addToolStripButton.Image = Properties.Resources.folderadd;
            addToolStripButton.ImageTransparentColor = Color.Magenta;
            addToolStripButton.Name = "addToolStripButton";
            addToolStripButton.Size = new Size(36, 36);
            addToolStripButton.Text = "Create Folder";
            addToolStripButton.Click += addToolStripButton_Click;
            // 
            // delToolStripButton
            // 
            delToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            delToolStripButton.Image = Properties.Resources.folderdelete;
            delToolStripButton.ImageTransparentColor = Color.Magenta;
            delToolStripButton.Name = "delToolStripButton";
            delToolStripButton.Size = new Size(36, 36);
            delToolStripButton.Text = "Delete Selected";
            delToolStripButton.Click += toolStripButtons_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // renameToolStripButton
            // 
            renameToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            renameToolStripButton.Image = Properties.Resources.rename;
            renameToolStripButton.ImageTransparentColor = Color.Magenta;
            renameToolStripButton.Name = "renameToolStripButton";
            renameToolStripButton.Size = new Size(36, 36);
            renameToolStripButton.Text = "Rename Selected";
            renameToolStripButton.Click += toolStripButtons_Click;
            // 
            // copyToolStripButton
            // 
            copyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyToolStripButton.Image = Properties.Resources._16;
            copyToolStripButton.ImageTransparentColor = Color.Magenta;
            copyToolStripButton.Name = "copyToolStripButton";
            copyToolStripButton.Size = new Size(36, 36);
            copyToolStripButton.Text = "Copy Selected";
            copyToolStripButton.Click += toolStripButtons_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 39);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(42, 36);
            toolStripLabel1.Text = "View";
            // 
            // viewToolStripComboBox
            // 
            viewToolStripComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            viewToolStripComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            viewToolStripComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            viewToolStripComboBox.Items.AddRange(new object[] { "Details", "LargeIcon", "List", "SmallIcon", "Tile" });
            viewToolStripComboBox.Name = "viewToolStripComboBox";
            viewToolStripComboBox.Size = new Size(121, 39);
            viewToolStripComboBox.Sorted = true;
            viewToolStripComboBox.Text = "Tile";
            viewToolStripComboBox.ToolTipText = "Files window view stile\r\n";
            viewToolStripComboBox.SelectedIndexChanged += viewToolStripComboBox_SelectedIndexChanged;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 39);
            // 
            // tileSizetoolStripLabel
            // 
            tileSizetoolStripLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tileSizetoolStripLabel.Name = "tileSizetoolStripLabel";
            tileSizetoolStripLabel.Size = new Size(85, 36);
            tileSizetoolStripLabel.Text = "Tile Icon Size";
            // 
            // tileIconSizeToolStripComboBox
            // 
            tileIconSizeToolStripComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            tileIconSizeToolStripComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            tileIconSizeToolStripComboBox.Items.AddRange(new object[] { "16 x 16", "20 x 20", "24 x 24", "28 x 28", "32 x 32", "36 x 36", "40 x 40", "44 x 44", "48 x 48" });
            tileIconSizeToolStripComboBox.Name = "tileIconSizeToolStripComboBox";
            tileIconSizeToolStripComboBox.Size = new Size(75, 39);
            tileIconSizeToolStripComboBox.Text = "48 x 48";
            tileIconSizeToolStripComboBox.TextChanged += tileIconSizeToolStripComboBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 60);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 9;
            label1.Text = "RootDir : ";
            // 
            // rootTextBox
            // 
            rootTextBox.Location = new Point(80, 57);
            rootTextBox.Name = "rootTextBox";
            rootTextBox.ReadOnly = true;
            rootTextBox.Size = new Size(185, 23);
            rootTextBox.TabIndex = 10;
            // 
            // visibleCheckBox
            // 
            visibleCheckBox.AutoSize = true;
            visibleCheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            visibleCheckBox.Location = new Point(277, 57);
            visibleCheckBox.Name = "visibleCheckBox";
            visibleCheckBox.Size = new Size(98, 21);
            visibleCheckBox.TabIndex = 11;
            visibleCheckBox.Text = "Show hiden ";
            visibleCheckBox.UseVisualStyleBackColor = true;
            visibleCheckBox.CheckedChanged += visibleCheckBox_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 505);
            Controls.Add(visibleCheckBox);
            Controls.Add(rootTextBox);
            Controls.Add(label1);
            Controls.Add(treeView);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(toolStrip1);
            Name = "MainForm";
            Text = "NotePad";
            ((System.ComponentModel.ISupportInitialize)fileIconPictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList folderImageList;
        private ImageList fileImageListLarge;
        private ImageList fileImageListSmall;
        private ListView fileListView;
        private PictureBox fileIconPictureBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ToolStrip toolStrip1;
        private ToolStripButton addToolStripButton;
        private ToolStripButton renameToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton delToolStripButton;
        private ToolStripButton copyToolStripButton;
        private ToolStripComboBox viewToolStripComboBox;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel1;
        private Label label1;
        private TextBox rootTextBox;
        private TreeView treeView;
        private CheckBox visibleCheckBox;
        private ColumnHeader NameColumnHeader;
        private ColumnHeader extColumnHeader;
        private ColumnHeader sizeColumnHeader;
        private ColumnHeader columnHeader1;
        private ToolStripLabel tileSizetoolStripLabel;
        private ToolStripComboBox tileIconSizeToolStripComboBox;
        private ToolStripSeparator toolStripSeparator3;
        private Label nameLabel;
        private Label extLabel;
        private Label pathLabel;
        private Label lastMTimeLAble;
        private Label sizeLabel;
        private Label lastATimeLabel;
    }
}