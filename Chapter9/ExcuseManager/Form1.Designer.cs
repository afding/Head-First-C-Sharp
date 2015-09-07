namespace ExcuseManager
{
    partial class Form1
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
            this.lblExcuse = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblLastUsed = new System.Windows.Forms.Label();
            this.lblFileDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLastUsed = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.txtExcuse = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblFileDate2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExcuse
            // 
            this.lblExcuse.AutoSize = true;
            this.lblExcuse.Location = new System.Drawing.Point(3, 0);
            this.lblExcuse.Name = "lblExcuse";
            this.lblExcuse.Size = new System.Drawing.Size(42, 13);
            this.lblExcuse.TabIndex = 0;
            this.lblExcuse.Text = "Excuse";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(3, 27);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(42, 13);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "Results";
            // 
            // lblLastUsed
            // 
            this.lblLastUsed.AutoSize = true;
            this.lblLastUsed.Location = new System.Drawing.Point(3, 54);
            this.lblLastUsed.Name = "lblLastUsed";
            this.lblLastUsed.Size = new System.Drawing.Size(55, 13);
            this.lblLastUsed.TabIndex = 2;
            this.lblLastUsed.Text = "Last Used";
            // 
            // lblFileDate
            // 
            this.lblFileDate.AutoSize = true;
            this.lblFileDate.Location = new System.Drawing.Point(3, 81);
            this.lblFileDate.Name = "lblFileDate";
            this.lblFileDate.Size = new System.Drawing.Size(49, 13);
            this.lblFileDate.TabIndex = 3;
            this.lblFileDate.Text = "File Date";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtLastUsed, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtResults, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblExcuse, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblLastUsed, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblResults, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFileDate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtExcuse, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFileDate2, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 144);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txtLastUsed
            // 
            this.txtLastUsed.Enabled = false;
            this.txtLastUsed.Location = new System.Drawing.Point(282, 57);
            this.txtLastUsed.Name = "txtLastUsed";
            this.txtLastUsed.Size = new System.Drawing.Size(200, 20);
            this.txtLastUsed.TabIndex = 6;
            this.txtLastUsed.TextChanged += new System.EventHandler(this.txtLastUsed_TextChanged);
            // 
            // txtResults
            // 
            this.txtResults.Enabled = false;
            this.txtResults.Location = new System.Drawing.Point(282, 30);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(200, 20);
            this.txtResults.TabIndex = 5;
            this.txtResults.TextChanged += new System.EventHandler(this.txtResults_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.btnFolder);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnOpen);
            this.flowLayoutPanel1.Controls.Add(this.btnRandom);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 111);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(552, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(3, 3);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 23);
            this.btnFolder.TabIndex = 0;
            this.btnFolder.Text = "Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(84, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Enabled = false;
            this.btnOpen.Location = new System.Drawing.Point(165, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Enabled = false;
            this.btnRandom.Location = new System.Drawing.Point(246, 3);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // txtExcuse
            // 
            this.txtExcuse.Enabled = false;
            this.txtExcuse.Location = new System.Drawing.Point(282, 3);
            this.txtExcuse.Name = "txtExcuse";
            this.txtExcuse.Size = new System.Drawing.Size(200, 20);
            this.txtExcuse.TabIndex = 4;
            this.txtExcuse.TextChanged += new System.EventHandler(this.txtExcuse_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblFileDate2
            // 
            this.lblFileDate2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFileDate2.Location = new System.Drawing.Point(282, 81);
            this.lblFileDate2.Name = "lblFileDate2";
            this.lblFileDate2.Size = new System.Drawing.Size(200, 20);
            this.lblFileDate2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 144);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Excuse Manager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExcuse;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblLastUsed;
        private System.Windows.Forms.Label lblFileDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox txtLastUsed;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtExcuse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblFileDate2;
    }
}

