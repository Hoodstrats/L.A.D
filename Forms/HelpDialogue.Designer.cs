namespace Hoodstrats.Core
{
    partial class HelpDialogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpDialogue));
            this._helpText = new System.Windows.Forms.TextBox();
            this._twitterLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // _helpText
            // 
            this._helpText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._helpText.CausesValidation = false;
            this._helpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._helpText.Location = new System.Drawing.Point(13, 5);
            this._helpText.Multiline = true;
            this._helpText.Name = "_helpText";
            this._helpText.ReadOnly = true;
            this._helpText.Size = new System.Drawing.Size(352, 226);
            this._helpText.TabIndex = 0;
            this._helpText.Text = resources.GetString("_helpText.Text");
            this._helpText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _twitterLink
            // 
            this._twitterLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._twitterLink.AutoSize = true;
            this._twitterLink.Location = new System.Drawing.Point(165, 235);
            this._twitterLink.Name = "_twitterLink";
            this._twitterLink.Size = new System.Drawing.Size(39, 13);
            this._twitterLink.TabIndex = 16;
            this._twitterLink.TabStop = true;
            this._twitterLink.Text = "Twitter";
            this._twitterLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._twitterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._twitterLink_LinkClicked);
            // 
            // HelpDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 251);
            this.Controls.Add(this._twitterLink);
            this.Controls.Add(this._helpText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpDialogue";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HelpDialogue";
            this.Load += new System.EventHandler(this.HelpDialogue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _helpText;
        private System.Windows.Forms.LinkLabel _twitterLink;
    }
}