using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TogglConnect;
using SharedLibrary;
using DesktopProjectDataHandler;
using System.Text.RegularExpressions;

namespace AutoToggl
{
    public partial class Main : _Base
    {
        private static TogglBase tb = TogglBase.GetInstance();
        Timer timer = new Timer();
        Timer secondTimer = new Timer();
        DataHandler dh = DataHandler.GetInstance();
        DesktopProjectDataHandler.Settings settings;
        public static string lastActive = string.Empty;
        public static bool idle = false;
        public static bool aTimerIsRunning = false;
        private static TimeEntry runningTimeEntry = new TimeEntry();

        public Main()
        {
            InitializeComponent();
            settings = dh.GetSettings();
            timer.Interval = settings.CheckInterval;
            secondTimer.Interval = 1000;
            timer.Tick += Timer_Tick;
            secondTimer.Tick += SecondTimer_Tick;
            HideConsole();
            tb.Init(settings.TogglAPIKey, settings.TogglWorkspaceId);
        }

        private void SecondTimer_Tick(object sender, EventArgs e)
        {
            var dur = "";
            if (aTimerIsRunning) {
                dur = tb.CalculateDuration(runningTimeEntry.duration).TotalSeconds.ToString();
            }
            lblTimer.Text = dur;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var clr = Color.White;
            var win = GetActiveWindowTitle();

            if (!idle) {
                var currentActive = GetActiveWindowTitle();
                if (CurrentActiveIsValid(currentActive)) {
                    var anyMatches = false;
                    foreach (var project in dh.GetTrackedProjects()) {
                        if (KeywordExistsInActiveWindowTitle(project, currentActive)) {
                            StartTimer(project, currentActive);
                            anyMatches = true;
                            break;
                        }
                    }
                    if (!anyMatches && aTimerIsRunning) {
                        win = "Window doesn't match any keywords in any projects. Stopping timer.";
                        clr = Color.Red;
                        lblTrackingProjectTitle.Text = "";
                        tb.StopRunningTimer();
                        secondTimer.Stop();
                        lblTimer.Text = "";
                        aTimerIsRunning = false;
                        runningTimeEntry = new TimeEntry();
                    }
                    lastActive = currentActive;
                } else {
                    //lblTimer.Text = tb.CalculateDuration(runningTimeEntry.duration).TotalSeconds.ToString();
                }
            }

            if (win == "AutoToggl") {
                clr = Color.Green;
            }
            txtConsole.AppendTimeStampedLine(win, clr);
        }

        private void StartTimer(TrackedProject project, string description = "")
        {
            var ct = tb.GetRunningTimer();
            if (ct != null && ct.pid == project.id && ct.description == description) {
                txtConsole.AppendTimeStampedLine($"A timer is already running for {project.name}.");
                runningTimeEntry = ct;
                if (!secondTimer.Enabled) {
                    secondTimer.Start();
                }
            } else {
                TimeEntryWrapper wrapper = new TimeEntryWrapper();
                wrapper.time_entry = new TimeEntry() {
                    description = description
                    , wid = project.wid
                    , pid = project.id
                    , created_with = ".net"
                };
                var ted = tb.UnwrapWebResult<TimeEntryData>(tb.StartTimer(wrapper)).data;
                //lblTimer.Text = tb.CalculateDuration(ted.duration).TotalSeconds.ToString();
                secondTimer.Start();
                txtConsole.AppendTimeStampedLine($"Tracking started for {project.name}.", Color.Green);
                runningTimeEntry = ted;
            }
            aTimerIsRunning = true;
            lblTrackingProjectTitle.Text = project.name;

        }

        private static bool CurrentActiveIsValid(string currentActive) => lastActive != currentActive && currentActive.JFIsNotNull() && !IsNeutralWindow(currentActive);

        public static bool IsNeutralWindow(string title) => false; // Regex.IsMatch(title, "", RegexOptions.IgnoreCase);

        private static bool KeywordExistsInActiveWindowTitle(TrackedProject project, string currentActive)
        {
            foreach (var keyword in project.projectKeywords) {
                var match = Regex.Match(currentActive, keyword, RegexOptions.IgnoreCase);
                if (match.Success) {
                    return true;
                }
            }
            return false;
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
