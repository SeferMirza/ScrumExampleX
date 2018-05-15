using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }
        int PageMeter = 1;

        private void RightButton_Click(object sender, EventArgs e)
        {
            PageMeter++;
            Page(PageMeter);

        }
        private void Page(int PageMeter)
        {
            if (PageMeter == 5)
                this.PageMeter = 1;
            if (PageMeter == 0)
                this.PageMeter = 4;
            NumberLabel.Text = this.PageMeter + "-";
            switch (PageMeter)
            {
                case 0: pcBox.BackgroundImage = Properties.Resources.Adsız4; break;
                case 1: pcBox.BackgroundImage = Properties.Resources.Adsız; break;
                case 2: pcBox.BackgroundImage = Properties.Resources.Adsız1; break;
                case 3: pcBox.BackgroundImage = Properties.Resources.Adsız3; break;
                case 4: pcBox.BackgroundImage = Properties.Resources.Adsız4; break;
                case 5: pcBox.BackgroundImage = Properties.Resources.Adsız; break;
            }

        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            PageMeter--;
            Page(PageMeter);
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
