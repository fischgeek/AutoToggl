using DesktopProjectDataHandler;
using System;
using System.Windows.Forms;
using SharedLibrary;
using TogglConnect;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace AutoToggl
{
    public partial class Menu : Form
    {
        DataHandler dh = DataHandler.GetInstance();
        TogglBase tb = TogglBase.GetInstance();
        BindingList<TrackedProject> trackedProjectsBindingList;
        Settings settings = new Settings();

        public Menu()
        {
            InitializeComponent();
            var settings = dh.GetSettings();
            trackedProjectsBindingList = new BindingList<TrackedProject>(dh.GetTrackedProjects());
            cbxStartWithWindows.Checked = settings.StartWithWindows;
            cbxShowOnStart.Checked = settings.ShowOnStart;
            cbxCloseToTray.Checked = settings.CloseToTray;
            txtCheckInterval.Text = settings.CheckInterval.ToString();
            txtTogglUsername.Text = settings.TogglUsername;
            txtTogglPassword.Text = settings.TogglPassword;
            txtTogglAPIKey.Text = settings.TogglAPIKey;
            txtTogglWorkspaceId.Text = settings.TogglWorkspaceId.ToString();
            lstProjects.DataSource = trackedProjectsBindingList;
            tb.Init(settings.TogglAPIKey, settings.TogglWorkspaceId);
            var me = tb.GetMe();
            if (me == null) {
                lblMessages.Text = "Toggl authentication was unsuccessful. Please check the Toggl Authentication section.";
            } else {
                lblMessages.Text = "Toggl authentication was successful. Welcome.";
                ddlTogglProjects.DataSource = tb.GetProjects();
                ddlTogglProjects.DisplayMember = "name";
                ddlTogglProjects.ValueMember = "id";
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
            var selectedItem = ddlTogglProjects.SelectedItem as Project;
            if (!trackedProjectsBindingList.Any(x => x.id == selectedItem.id)) {
                trackedProjectsBindingList.Add(new TrackedProject() {
                    id = selectedItem.id
                    , name = selectedItem.name
                    , position = 0
                    , wid = Convert.ToInt32(txtTogglWorkspaceId.Text)
                });
                dh.SaveTrackedProjects(trackedProjectsBindingList.ToList());
            }
        }

        private void lstProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var project = (lstProjects.SelectedItem as TrackedProject);
            Console.WriteLine(project.id);
            if (project.projectKeywords != null) {
                var keywords = project.projectKeywords.ToList();
                txtKeywordList.Text = string.Join("\r\n", keywords.ToArray());
            } else {
                txtKeywordList.Text = "";
            }
        }

        private void lnkSaveEdits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var keywordStrings = Regex.Replace(txtKeywordList.Text, "\r\n", ",", RegexOptions.IgnoreCase);
            var project = (lstProjects.SelectedItem as TrackedProject);
            project.projectKeywords = keywordStrings.ToLower().Split(',');
            dh.SaveTrackedProjects(trackedProjectsBindingList.ToList());
            KeywordDisplay(KeywordDisplayMode.Display);
        }

        private void lnkEditKeywords_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => KeywordDisplay(KeywordDisplayMode.Edit);

        private void lnkCancelEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => KeywordDisplay(KeywordDisplayMode.Display);

        private void KeywordDisplay(KeywordDisplayMode kdm)
        {
            switch (kdm) {
                case KeywordDisplayMode.Display:
                    lnkSaveEdits.Visible = false;
                    lnkCancelEdit.Visible = false;
                    lnkEditKeywords.Visible = true;
                    txtKeywordList.ReadOnly = true;
                    break;
                case KeywordDisplayMode.Edit:
                    lnkSaveEdits.Visible = true;
                    lnkCancelEdit.Visible = true;
                    lnkEditKeywords.Visible = false;
                    txtKeywordList.ReadOnly = false;
                    break;
                default:
                    lnkSaveEdits.Visible = false;
                    lnkCancelEdit.Visible = false;
                    lnkEditKeywords.Visible = true;
                    txtKeywordList.ReadOnly = true;
                    break;
            }
        }


    }

    public enum KeywordDisplayMode
    {
        Display,
        Edit
    }
}
