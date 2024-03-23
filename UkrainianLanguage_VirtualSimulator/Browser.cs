using System;
using System.Windows.Forms;

namespace UkrainianLanguage_VirtualSimulator
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }
        public string Link = "";

        private void Browser_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate(Link);
        }
    }
}
