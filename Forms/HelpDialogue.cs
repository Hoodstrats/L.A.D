/* https://twitter.com/HoodStrats || https://github.com/Hoodstrats */

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Hood.Core
{
    public partial class HelpDialogue : Form
    {
        public HelpDialogue()
        {
            InitializeComponent();
        }

        private void HelpDialogue_Load(object sender, EventArgs e)
        {
            _helpText.Enabled = false;
            CenterToParent();
        }

        private void _twitterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitter.com/hoodstrats");
        }
    }
}
