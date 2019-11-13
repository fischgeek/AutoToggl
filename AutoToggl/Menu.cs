using DesktopProjectDataHandler;
using System;
using System.Windows.Forms;
using SharedLibrary;
using TogglConnect;
using System.Collections.Generic;

namespace AutoToggl
{
    public partial class Menu : Form
    {
        DataHandler dh = DataHandler.GetInstance();
        TogglBase tb = TogglBase.GetInstance();
        List<Project> projects = new List<Project>();
        Settings settings = new Settings();

        public Menu()
        {
            InitializeComponent();
            var settings = dh.GetSettings();
            cbxStartWithWindows.Checked = settings.StartWithWindows;
            cbxShowOnStart.Checked = settings.ShowOnStart;
            cbxCloseToTray.Checked = settings.CloseToTray;
            txtCheckInterval.Text = settings.CheckInterval.ToString();
            txtTogglUsername.Text = settings.TogglUsername;
            txtTogglPassword.Text = settings.TogglPassword;
            txtTogglAPIKey.Text = settings.TogglAPIKey;
            txtTogglWorkspaceId.Text = settings.TogglWorkspaceId.ToString();
            lstProjects.DataSource = settings.TrackedProjects;
            tb.Init(settings.TogglAPIKey, settings.TogglWorkspaceId);
            var me = tb.GetMe();
            if (me == null) {
                lblMessages.Text = "Toggl authentication was unsuccessful. Please check the Toggl Authentication section.";
            } else {
                lblMessages.Text = "Toggl authentication was successful. Welcome.";
                projects = tb.GetProjects();
                ddlTogglProjects.DataSource = projects;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settings.StartWithWindows = cbxStartWithWindows.Checked;
            settings.ShowOnStart =      cbxShowOnStart.Checked;
            settings.CloseToTray =      cbxCloseToTray.Checked;
            settings.CheckInterval =    txtCheckInterval.Text.JFStringToInt();
            settings.TogglUsername =    txtTogglUsername.Text;
            settings.TogglPassword =    txtTogglPassword.Text;
            settings.TogglAPIKey =      txtTogglAPIKey.Text;
            settings.TogglWorkspaceId = txtTogglWorkspaceId.Text.JFStringToInt();
            dh.UpdateSettings(settings);
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            if (settings.TrackedProjects == null) {
                settings.TrackedProjects = new List<TrackedProject>();
            }
            settings.TrackedProjects.Add(new TrackedProject() {
                Name = (ddlTogglProjects.SelectedItem as TrackedProject).Name
                , Position = 0
            });
            dh.UpdateSettings(settings);

        }
    }
}
