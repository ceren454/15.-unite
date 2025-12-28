using System;
using System.Windows.Forms;

namespace LinkLabelTest
{
    public partial class LinkLabelTestForm : Form
    {
        public LinkLabelTestForm()
        {
            InitializeComponent();
        }

        private void cDriveLinkLabel_LinkClicked(
            object sender, LinkLabelLinkClickedEventArgs e)
        {
            cDriveLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(@"C:\");
        }

        private void deitelLinkLabel_LinkClicked(
            object sender, LinkLabelLinkClickedEventArgs e)
        {
            deitelLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.deitel.com");
        }

        private void notepadLinkLabel_LinkClicked(
            object sender, LinkLabelLinkClickedEventArgs e)
        {
            notepadLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("notepad");
        }
    }
}
