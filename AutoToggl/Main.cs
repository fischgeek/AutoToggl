using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogglConnect;
using SharedLibrary;
//using DesktopProjectDataHandler;

namespace AutoToggl
{
    public partial class Main : _Base
    {
        private static TogglBase tb = TogglBase.GetInstance();
        Timer timer = new Timer();
        //DataHandler dh = DataHandler.GetInstance();

        public Main()
        {
            InitializeComponent();
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
            HideConsole();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var clr = Color.White;
            var win = GetActiveWindowTitle();
            if (win == "AutoToggl") {
                clr = Color.Green;
            }
            richTextBox1.AppendTimeStampedLine(win, clr);
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void lnkConfigureProjects_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConfigureProjects cp = new ConfigureProjects();
            cp.Show();
        }

        private void lnkToggleConsole_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox1.Visible = !richTextBox1.Visible;
            if (richTextBox1.Visible) {
                ShowConsole();
            } else {
                HideConsole();
            }
        }

        private void ShowConsole()
        {
            richTextBox1.Visible = true;
            lnkToggleConsole.Text = "Hide Console";
            this.Height = 710;
            richTextBox1.Height = 400;
            this.Refresh();
        }

        private void HideConsole()
        {
            richTextBox1.Visible = false;
            lnkToggleConsole.Text = "Show Console";
            this.Height = 300;
            richTextBox1.Height = 400;
            this.Refresh();
        }
    }

    public enum MatchType
    {
        NoMatch
        , Neutral
        , Match
    }
}
