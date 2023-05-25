namespace WinFormsApp1
{
    partial class DialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            okButton = new Button();
            cancelButton = new Button();
            label1 = new Label();
            rootPath = new TextBox();
            label2 = new Label();
            nameTextBox = new TextBox();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(47, 106);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 0;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(213, 106);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 2;
            label1.Text = "Path :";
            // 
            // rootPath
            // 
            rootPath.Location = new Point(64, 17);
            rootPath.Name = "rootPath";
            rootPath.ReadOnly = true;
            rootPath.Size = new Size(224, 23);
            rootPath.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 59);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 4;
            label2.Text = "New  name : ";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(116, 56);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(172, 23);
            nameTextBox.TabIndex = 5;
            // 
            // DialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 136);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(rootPath);
            Controls.Add(label1);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            MaximizeBox = false;
            MaximumSize = new Size(355, 175);
            MinimizeBox = false;
            MinimumSize = new Size(355, 175);
            Name = "DialogForm";
            ShowIcon = false;
            Text = "New Folder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Button cancelButton;
        private Label label1;
        private TextBox rootPath;
        private Label label2;
        private TextBox nameTextBox;
    }
}