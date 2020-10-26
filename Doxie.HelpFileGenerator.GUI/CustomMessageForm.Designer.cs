namespace Doxie.HelpFileGenerator.GUI
{
    partial class CustomMessageForm
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.errorBox = new System.Windows.Forms.RichTextBox();
            this.copiedTxt = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Location = new System.Drawing.Point(466, 327);
            this.exitBtn.MaximumSize = new System.Drawing.Size(75, 23);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseClick);
            // 
            // copyBtn
            // 
            this.copyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyBtn.Location = new System.Drawing.Point(12, 327);
            this.copyBtn.MaximumSize = new System.Drawing.Size(75, 23);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(75, 23);
            this.copyBtn.TabIndex = 1;
            this.copyBtn.Text = "Copy Error";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.copyBtn_MouseClick);
            // 
            // errorBox
            // 
            this.errorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorBox.CausesValidation = false;
            this.errorBox.Location = new System.Drawing.Point(0, 0);
            this.errorBox.MaximumSize = new System.Drawing.Size(783, 1200);
            this.errorBox.MinimumSize = new System.Drawing.Size(552, 321);
            this.errorBox.Name = "errorBox";
            this.errorBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.errorBox.Size = new System.Drawing.Size(552, 321);
            this.errorBox.TabIndex = 2;
            this.errorBox.Text = "";
            // 
            // copiedTxt
            // 
            this.copiedTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copiedTxt.AutoSize = true;
            this.copiedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiedTxt.ForeColor = System.Drawing.Color.YellowGreen;
            this.copiedTxt.Location = new System.Drawing.Point(90, 328);
            this.copiedTxt.MaximumSize = new System.Drawing.Size(148, 20);
            this.copiedTxt.Name = "copiedTxt";
            this.copiedTxt.Size = new System.Drawing.Size(148, 20);
            this.copiedTxt.TabIndex = 3;
            this.copiedTxt.Text = "Copied to Clipboard";
            this.copiedTxt.Visible = false;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.Location = new System.Drawing.Point(385, 328);
            this.clearBtn.MaximumSize = new System.Drawing.Size(71, 23);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(71, 23);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear Errors";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearBtn_MouseClick);
            // 
            // CustomMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(553, 362);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.copiedTxt);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.exitBtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 675);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(569, 400);
            this.Name = "CustomMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Something went wrong...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.RichTextBox errorBox;
        private System.Windows.Forms.Label copiedTxt;
        private System.Windows.Forms.Button clearBtn;
    }
}