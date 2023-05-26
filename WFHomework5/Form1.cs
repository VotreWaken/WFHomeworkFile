using System.IO;
using System.Windows.Forms;

namespace WFHomework5
{
    public partial class Form1 : Form
    {
        string path = "Text.txt";
        public Form1()
        {
            InitializeComponent();
            SaveFile.Filter = "Text Files | *.txt";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;
            string path = OpenFile.FileName;
            this.Text = path;
            string fileText = File.ReadAllText(path);
            TBMainBox.Text = fileText;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = SaveFile.FileName;
            File.WriteAllText(path, TBMainBox.Text);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.Cancel)
                return;
            path = SaveFile.FileName;
            this.Text = path;
            File.WriteAllText(path, TBMainBox.Text);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TBMainBox.TextLength > 0)
            {
                TBMainBox.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TBMainBox.TextLength > 0)
            {
                TBMainBox.Paste();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TBMainBox.TextLength > 0)
            {
                TBMainBox.Cut();
            }
        }

        private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TBMainBox.TextLength > 0)
            {
                TBMainBox.SelectAll();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog.ShowDialog();
            TBMainBox.Font = FontDialog.Font;
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
            TBMainBox.BackColor = ColorDialog.Color;
        }
    }
}