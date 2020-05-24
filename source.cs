using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace PR_Map_Gallery
{
    public partial class Form1 : Form
    {
        public string _url = "";

        public string _mgurl = "https://realitymod.com/mapgallery";
        public string _prfurl = "https://www.realitymod.com/forum/";
        public string _vgurl = "https://veterans-gaming.com/";
        public string _vgfurl = "https://veterans-gaming.com/index.php?/forums/";

        public Form1()
        {
            InitializeComponent();
        }

        ChromiumWebBrowser chrome;
        private void Form1_Load(object sender, EventArgs e)
        {

            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This was made by the ULTIMATE SOFTWARE DEVELOPER!!! (aka Beast)\nVersion: 0.0 Alpha");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For help contact Callsign_Beast on the =VG= Forum");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pRBF2MapGalleryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clearer();
            chrome = new ChromiumWebBrowser(_mgurl);
            this.panel1.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
        }

        private void pRBF2ForumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clearer();
            chrome = new ChromiumWebBrowser(_prfurl);
            this.panel1.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
        }

        private void vGWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clearer();
            chrome = new ChromiumWebBrowser(_vgurl);
            this.panel1.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
        }

        private void vGForumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clearer();
            chrome = new ChromiumWebBrowser(_vgfurl);
            this.panel1.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
        }
        public void Clearer()
        {
            panel1.Controls.Clear();
        }


        private void removeUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void gETITBACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ControlBox = true;
        }
    }
}
