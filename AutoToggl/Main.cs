using System;
using System.Drawing;
using System.Linq;
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
            txtConsole.AppendTimeStampedLine(win, clr);
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void lnkToggleConsole_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtConsole.Visible = !txtConsole.Visible;
            if (txtConsole.Visible) {
                ShowConsole();
            } else {
                HideConsole();
            }
        }

        private void ShowConsole()
        {
            txtConsole.Visible = true;
            lnkToggleConsole.Text = "Hide Console";
            this.Height = 710;
            txtConsole.Height = 400;
            this.Refresh();
        }

        private void HideConsole()
        {
            txtConsole.Visible = false;
            lnkToggleConsole.Text = "Show Console";
            this.Height = 300;
            txtConsole.Height = 400;
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

        private void txtConsole_TextChanged(object sender, EventArgs e)
        {
            if (txtConsole.Lines.Count() >= 100) {
                txtConsole.SelectionStart = txtConsole.GetFirstCharIndexFromLine(0);
                txtConsole.SelectionLength = this.txtConsole.Lines[0].Length + 1;
                this.txtConsole.SelectedText = String.Empty;
            }
        }
    }

    public enum MatchType
    {
        NoMatch
        , Neutral
        , Match
    }
}
