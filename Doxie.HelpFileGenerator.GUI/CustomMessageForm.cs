using System.Windows.Forms;

namespace Doxie.HelpFileGenerator.GUI
{
    /// <summary>
    /// The form internally used by <see cref="CustomMessageBox"/> class.
    /// </summary>
    internal partial class CustomMessageForm : Form
    {
        /// <summary>
        /// This constructor is required for designer support.
        /// </summary>
        public CustomMessageForm()
        {
            InitializeComponent();
        }

        public CustomMessageForm(string description)
        {
            InitializeComponent();
            Globals.counter++;
            Globals.extended_description = Globals.extended_description + "Error " + Globals.counter + ":\r\n" + description + "\r\n";
            this.errorBox.Text = Globals.extended_description;
            Globals.errorMsg = null;
        }

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void copyBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(errorBox.Text);
            copiedTxt.Visible = true;
        }

        private void clearBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Globals.errorMsg = null;
            errorBox.Text = null;
            copyBtn.Enabled = false;
            clearBtn.Enabled = false;
            Globals.extended_description = null;
            Globals.counter = 0;
        }
    }

    /// <summary>
    /// Your custom message box helper.
    /// </summary>
    public static class CustomMessageBox
    {
        public static void Show(string description)
        {
            // using construct ensures the resources are freed when form is closed
            using (var form = new CustomMessageForm(description))
            {
                form.ShowDialog();
            }
        }
    }
}
