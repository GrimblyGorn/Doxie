using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Doxie.Core.Services;
using Extenso.Collections;

namespace Doxie.HelpFileGenerator.GUI
{
    /// <summary>
    /// The main form.
    /// </summary>
    public partial class MainForm : Form
    {
        private string assembliesPath;
        private SearchOption search = SearchOption.TopDirectoryOnly;
        private string outLocation = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btns the browse_ click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (dlgFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                assembliesPath = dlgFolderBrowser.SelectedPath;
                txtPath.Text = assembliesPath;

                clbFiles.Items.Clear();
                cbPaths.Items.Clear();
                var files = from fullFilename in Directory.EnumerateFiles(assembliesPath, "*.dll", search).OrderBy(x => x) select Path.GetFileName(fullFilename);
                var filePaths = Directory.EnumerateFiles(assembliesPath, "*.dll", search).OrderBy(x => x);
                foreach (string file in files)
                {
                    clbFiles.Items.Add(file);
                }
                foreach (string paths in filePaths)
                {
                    cbPaths.Items.Add(paths);
                }

                resetBtn.Enabled = true;
                resetBtn.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
                recursiveBtn.Enabled = false;
                clbFiles.Enabled = true;
                btnGenerate.Enabled = true;
                btnGenerate.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                if (clbFiles.Items.Count >= 1)
                {
                    Select_All.Enabled = true;
                    clearAllBtn.Enabled = true;
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            foreach (int index in clbFiles.CheckedIndices)
            {
                cbPaths.SetItemChecked(index, true);
            }
            var selectedFiles = cbPaths.CheckedItems.OfType<object>().Select(x => x.ToString());

            if (selectedFiles.IsNullOrEmpty())
            {
                MessageBox.Show("You must select at least one assembly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = fileName.Text;
            string val = assembliesPath;
            if (outLocation != null) { val = outLocation; }
            JsonHelpFileGenerator.Generate(selectedFiles, val, name);
            MessageBox.Show("The " + name + ".json has been generated in the specified folder.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AppDomain.CurrentDomain.AssemblyResolve -= CurrentDomain_AssemblyResolve;
        }

        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            var assemblyName = new AssemblyName(args.Name);
            string path = Path.Combine(assembliesPath, assemblyName.Name + ".dll");

            if (File.Exists(path))
            {
                return Assembly.Load(path);
            }

            return null;
        }

        private void txtFolderPath_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (Directory.Exists(files[0]))
                {
                    this.txtPath.Text = files[0];
                    assembliesPath = txtPath.Text;

                    clbFiles.Items.Clear();
                    cbPaths.Items.Clear();
                    var files2 = from fullFilename in Directory.EnumerateFiles(assembliesPath, "*.dll", search).OrderBy(x => x) select Path.GetFileName(fullFilename);
                    var filePaths = Directory.EnumerateFiles(assembliesPath, "*.dll", search).OrderBy(x => x);
                    foreach (string file in files2)
                    {
                        clbFiles.Items.Add(file);
                    }
                    foreach (string paths in filePaths)
                    {
                        cbPaths.Items.Add(paths);
                    }

                    resetBtn.Enabled = true;
                    resetBtn.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
                    recursiveBtn.Enabled = false;
                    clbFiles.Enabled = true;
                    btnGenerate.Enabled = true;
                    btnGenerate.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                    if (clbFiles.Items.Count >= 1)
                    {
                        Select_All.Enabled = true;
                        clearAllBtn.Enabled = true;
                    }
                }
            }
        }

        private void txtFolderPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtPath_CausesValidationChanged(object sender, EventArgs e)
        {
            assembliesPath = txtPath.Text;

            clbFiles.Items.Clear();
            cbPaths.Items.Clear();
            var files = from fullFilename in Directory.EnumerateFiles(assembliesPath, "*.dll", search).OrderBy(x => x) select Path.GetFileName(fullFilename);
            var filePaths = Directory.EnumerateFiles(assembliesPath, "*.dll", search).OrderBy(x => x);
            foreach (string file in files)
            {
                clbFiles.Items.Add(file);
            }
            foreach (string paths in filePaths)
            {
                cbPaths.Items.Add(paths);
            }

            resetBtn.Enabled = true;
            resetBtn.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            recursiveBtn.Enabled = false;
            clbFiles.Enabled = true;
            btnGenerate.Enabled = true;
            btnGenerate.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            if (clbFiles.Items.Count >= 1)
            {
                Select_All.Enabled = true;
                clearAllBtn.Enabled = true;
            }
        }

        private void Select_All_MouseClick(object sender, MouseEventArgs e)
        {
            if (clbFiles.Items.Count >= 1)
            {
                for (int i = 0; i < clbFiles.Items.Count; i++)
                {
                    clbFiles.SetItemChecked(i, true);
                }
                //Select_All.Enabled = false;
                //clearAllBtn.Enabled = true;
            }
        }

        private void recursiveBtn_MouseClick(object sender, MouseEventArgs e)
        {
            resetBtn.Enabled = true;
            resetBtn.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            recursiveBtn.Enabled = false;
            true_false_txt.Text = "True";
            true_false_txt.ForeColor = System.Drawing.Color.YellowGreen;
            search = SearchOption.AllDirectories;
        }

        private void resetBtn_MouseClick(object sender, MouseEventArgs e)
        {
            // Reset
            resetBtn.Enabled = false;
            resetBtn.BackColor = System.Drawing.Color.LightGray;
            recursiveBtn.Enabled = true;
            true_false_txt.Text = "False";
            true_false_txt.ForeColor = System.Drawing.Color.Firebrick;
            search = SearchOption.TopDirectoryOnly;
            clearAllBtn.Enabled = false;
            Select_All.Enabled = false;
            clbFiles.Items.Clear();
            cbPaths.Items.Clear();
            clbFiles.Enabled = false;
            fileName.Text = "docs";
            txtPath.Text = null;
            assembliesPath = null;
            btnGenerate.Enabled = false;
            btnGenerate.BackColor = System.Drawing.Color.LightGray;

        }

        private void clearAllBtn_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < clbFiles.Items.Count; i++)
            {
                clbFiles.SetItemChecked(i, false);
            }
            //clearAllBtn.Enabled = false;
        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {
            if (outputBox.Text != null) {
                outLocation = outputBox.Text;
            }
        }
    }
}