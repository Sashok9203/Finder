using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public enum DialogAction
    {
        Create,
        Rename
    }
    public partial class DialogForm : Form
    {
        public string? Result { get; private set; }

        public DialogForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(string? path, DialogAction action)
        {
            Text = action.ToString();
            okButton.Text = action.ToString();
            rootPath.Text = path;
            return this.ShowDialog();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                nameTextBox.Text = "";
                return;
            }
            else
            {
                Result = nameTextBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            }

        }
    }
}
