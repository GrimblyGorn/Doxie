namespace Doxie.HelpFileGenerator.GUI
{
    partial class MainForm
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dlgFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.clbFiles = new System.Windows.Forms.CheckedListBox();
            this.Select_All = new System.Windows.Forms.Button();
            this.recursiveBtn = new System.Windows.Forms.Button();
            this.true_false_txt = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.clearAllBtn = new System.Windows.Forms.Button();
            this.cbPaths = new System.Windows.Forms.CheckedListBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outFolder = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(467, 58);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.Control;
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(467, 590);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtPath
            // 
            this.txtPath.AllowDrop = true;
            this.txtPath.HideSelection = false;
            this.txtPath.Location = new System.Drawing.Point(12, 60);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(449, 20);
            this.txtPath.TabIndex = 3;
            this.txtPath.ModifiedChanged += new System.EventHandler(this.txtPath_CausesValidationChanged);
            this.txtPath.CausesValidationChanged += new System.EventHandler(this.txtPath_CausesValidationChanged);
            this.txtPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.Doxie_DragDrop);
            this.txtPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.Doxie_DragEnter);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(9, 9);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(347, 39);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "- Select if Recursion should be used on the Directory. Then..\r\n- Browse to, Paste" +
    ", or Drag-n-Drop a directory with .NET assemblies in it.\r\n- Ensure the XML docum" +
    "entationon files are present as well.";
            // 
            // clbFiles
            // 
            this.clbFiles.AllowDrop = true;
            this.clbFiles.CheckOnClick = true;
            this.clbFiles.FormattingEnabled = true;
            this.clbFiles.Location = new System.Drawing.Point(12, 86);
            this.clbFiles.Name = "clbFiles";
            this.clbFiles.Size = new System.Drawing.Size(530, 469);
            this.clbFiles.TabIndex = 5;
            this.clbFiles.SelectedIndexChanged += new System.EventHandler(this.clbFiles_SelectedIndexChanged);
            this.clbFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.Doxie_DragDrop);
            this.clbFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.Doxie_DragEnter);
            // 
            // Select_All
            // 
            this.Select_All.Enabled = false;
            this.Select_All.Location = new System.Drawing.Point(12, 561);
            this.Select_All.Name = "Select_All";
            this.Select_All.Size = new System.Drawing.Size(75, 23);
            this.Select_All.TabIndex = 7;
            this.Select_All.Text = "Select All";
            this.Select_All.UseVisualStyleBackColor = true;
            this.Select_All.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_All_MouseClick);
            // 
            // recursiveBtn
            // 
            this.recursiveBtn.Location = new System.Drawing.Point(386, 12);
            this.recursiveBtn.Name = "recursiveBtn";
            this.recursiveBtn.Size = new System.Drawing.Size(75, 23);
            this.recursiveBtn.TabIndex = 8;
            this.recursiveBtn.Text = "Recursive";
            this.recursiveBtn.UseVisualStyleBackColor = true;
            this.recursiveBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.recursiveBtn_MouseClick);
            // 
            // true_false_txt
            // 
            this.true_false_txt.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.true_false_txt.AutoSize = true;
            this.true_false_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.true_false_txt.ForeColor = System.Drawing.Color.Firebrick;
            this.true_false_txt.Location = new System.Drawing.Point(467, 11);
            this.true_false_txt.Name = "true_false_txt";
            this.true_false_txt.Size = new System.Drawing.Size(56, 24);
            this.true_false_txt.TabIndex = 9;
            this.true_false_txt.Text = "False";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.SystemColors.Control;
            this.resetBtn.Enabled = false;
            this.resetBtn.Location = new System.Drawing.Point(467, 561);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 10;
            this.resetBtn.Text = "Reset All";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.resetBtn_MouseClick);
            // 
            // clearAllBtn
            // 
            this.clearAllBtn.Enabled = false;
            this.clearAllBtn.Location = new System.Drawing.Point(12, 590);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(75, 23);
            this.clearAllBtn.TabIndex = 11;
            this.clearAllBtn.Text = "Clear All";
            this.clearAllBtn.UseVisualStyleBackColor = true;
            this.clearAllBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearAllBtn_MouseClick);
            // 
            // cbPaths
            // 
            this.cbPaths.AllowDrop = true;
            this.cbPaths.CheckOnClick = true;
            this.cbPaths.FormattingEnabled = true;
            this.cbPaths.Location = new System.Drawing.Point(12, 86);
            this.cbPaths.Name = "cbPaths";
            this.cbPaths.Size = new System.Drawing.Size(530, 469);
            this.cbPaths.TabIndex = 12;
            this.cbPaths.Visible = false;
            // 
            // fileName
            // 
            this.fileName.AllowDrop = true;
            this.fileName.HideSelection = false;
            this.fileName.Location = new System.Drawing.Point(225, 592);
            this.fileName.MaxLength = 150;
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(236, 20);
            this.fileName.TabIndex = 13;
            this.fileName.Text = "docs";
            this.fileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Save As...";
            // 
            // outFolder
            // 
            this.outFolder.AutoSize = true;
            this.outFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outFolder.Location = new System.Drawing.Point(110, 626);
            this.outFolder.Name = "outFolder";
            this.outFolder.Size = new System.Drawing.Size(109, 13);
            this.outFolder.TabIndex = 15;
            this.outFolder.Text = "Alternate Output Path";
            // 
            // outputBox
            // 
            this.outputBox.AllowDrop = true;
            this.outputBox.HideSelection = false;
            this.outputBox.Location = new System.Drawing.Point(225, 623);
            this.outputBox.MaxLength = 150;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(317, 20);
            this.outputBox.TabIndex = 16;
            this.outputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.outputBox.TextChanged += new System.EventHandler(this.outputBox_TextChanged);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 648);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.outFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.clearAllBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.true_false_txt);
            this.Controls.Add(this.recursiveBtn);
            this.Controls.Add(this.Select_All);
            this.Controls.Add(this.clbFiles);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cbPaths);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doxie Help File Generator";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Doxie_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Doxie_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.FolderBrowserDialog dlgFolderBrowser;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.CheckedListBox clbFiles;
        public System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button Select_All;
        private System.Windows.Forms.Button recursiveBtn;
        private System.Windows.Forms.Label true_false_txt;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button clearAllBtn;
        private System.Windows.Forms.CheckedListBox cbPaths;
        public System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outFolder;
        public System.Windows.Forms.TextBox outputBox;
    }
}

