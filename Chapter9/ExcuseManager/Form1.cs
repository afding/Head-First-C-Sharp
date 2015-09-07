using System;
using System.IO;
using System.Windows.Forms;

namespace ExcuseManager
{
    public partial class Form1 : Form
    {
        public Excuse currentExcuse;
        private string selectedFolder = "";
        private bool formChanged = false;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            currentExcuse = new Excuse();
            //currentExcuse.LastUsed = lblFileDate2.Value;
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.txtExcuse.Text = currentExcuse.Description;
                this.txtResults.Text = currentExcuse.Results;
                this.txtLastUsed.Text = currentExcuse.LastUsed.ToString();
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    lblFileDate2.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                    this.Text = "Excuse Manager";
                }
                else
                {
                    this.Text = "Excuse Manager*";
                }
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                UpdateForm(false);
                btnOpen.Enabled = true;
                btnSave.Enabled = true;
                btnRandom.Enabled = true;
                txtExcuse.Enabled = true;
                txtResults.Enabled = true;
                txtLastUsed.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtExcuse.Text) || String.IsNullOrEmpty(txtResults.Text))
            {
                MessageBox.Show("Please specify an excuse and a result.", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.FileName = txtExcuse.Text + ".txt";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Excuse Written");
            }
            return;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog1.FileName = txtExcuse.Text + ".txt";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                }
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show("The current excuse has not been saved. Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        private void txtExcuse_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = txtExcuse.Text;
            UpdateForm(true);
        }

        private void txtResults_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = txtResults.Text;
            UpdateForm(true);
        }

        private void txtLastUsed_TextChanged(object sender, EventArgs e)
        {
            //currentExcuse.LastUsed = lblLastUsed.Value;
            UpdateForm(true);
        }
    }
}
