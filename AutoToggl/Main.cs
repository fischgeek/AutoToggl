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
using DesktopProjectDataHandler;

namespace AutoToggl
{
    public partial class Main : _Base
    {
        private static TogglBase tb = TogglBase.GetInstance();
        Timer timer = new Timer();
        DataHandler dh = DataHandler.GetInstance();
        Settings settings;

        public Main()
        {
            InitializeComponent();
            settings = dh.GetSettings();
            timer.Interval = settings.CheckInterval;
            timer.Tick += Timer_Tick;
            HideConsole();
            tb.Init(settings.TogglAPIKey, settings.TogglWorkspaceId);
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

        private void picMenu_MouseEnter(object sender, EventArgs e)
        {
            picMenu.Image = Properties.Resources.menu_hover;
        }

        private void picMenu_MouseLeave(object sender, EventArgs e)
        {
            picMenu.Image = Properties.Resources.menu;
        }

        private void picMenu_MouseHover(object sender, EventArgs e)
        {
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            FormProvider.Menu.Show();
            //ConfigureProjects cp = new ConfigureProjects();
            //cp.Show();
        }
    }

    public enum MatchType
    {
        NoMatch
        , Neutral
        , Match
    }
}
