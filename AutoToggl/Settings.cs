﻿using DesktopProjectDataHandler;
using System;
using System.Windows.Forms;
using SharedLibrary;
using TogglConnect;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AutoToggl
{
    public partial class Settings : Form
    {
        DataHandler dh = DataHandler.GetInstance();
        TogglBase tb = TogglBase.GetInstance();
        BindingList<TrackedProject> trackedProjectsBindingList;
        DesktopProjectDataHandler.Settings settings = new DesktopProjectDataHandler.Settings();

        public Settings()
        {
            InitializeComponent();
            var settings = dh.GetSettings();
            trackedProjectsBindingList = new BindingList<TrackedProject>(dh.GetTrackedProjects());
            ApplySettingsToUI(settings);
            lstProjects.DataSource = trackedProjectsBindingList;
            tb.Init(settings.TogglAPIKey, settings.TogglWorkspaceId);
            ddlTogglProjects.DataSource = tb.GetProjects();
            ddlTogglProjects.DisplayMember = "name";
            ddlTogglProjects.ValueMember = "id";
        }

        private void ApplySettingsToUI(DesktopProjectDataHandler.Settings settings)
        {
            cbxStartWithWindows.Checked = settings.StartWithWindows;
            cbxShowOnStart.Checked = settings.ShowOnStart;
            cbxCloseToTray.Checked = settings.CloseToTray;
            cbxShowFancyTimer.Checked = settings.ShowFancyTimer;
            txtCheckInterval.Text = settings.CheckInterval.ToString();
            txtTogglUsername.Text = settings.TogglUsername;
            txtTogglPassword.Text = settings.TogglPassword;
            txtTogglAPIKey.Text = settings.TogglAPIKey;
            txtTogglWorkspaceId.Text = settings.TogglWorkspaceId.ToString();
            txtNeutralWindows.Text = settings.NeutralWindows.ArrayToStr();
            cbxStopOnNeutral.Checked = settings.StopOnNeutral;
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
            settings.NeutralWindows = txtNeutralWindows.Text.StrToArray();
            settings.StopOnNeutral = cbxStopOnNeutral.Checked;
            settings.ShowFancyTimer = cbxShowFancyTimer.Checked;
            dh.UpdateSettings(settings);
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            var selectedItem = ddlTogglProjects.SelectedItem as Project;
            if (!trackedProjectsBindingList.Any(x => x.id == selectedItem.id)) {
                trackedProjectsBindingList.Add(new TrackedProject() {
                    id = selectedItem.id
                    , name = selectedItem.name
                    , position = trackedProjectsBindingList.Count()
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

        private void lnkTestAuth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkTestAuth.Visible = false;
            lblConnectionStatus.Visible = true;
            tb.Init(txtTogglAPIKey.Text, Convert.ToInt32(txtTogglWorkspaceId.Text));
            var me = tb.GetMe();
            if (me == null) {
                lblConnectionStatus.ForeColor = Color.Red;
                lblConnectionStatus.Text = "Toggl authentication was unsuccessful.";
            } else {
                lblConnectionStatus.ForeColor = Color.Green;
                lblConnectionStatus.Text = "Toggl authentication was successful.";
            }
        }

        private void lnkDeleteTrackedProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ci = lstProjects.SelectedItem as TrackedProject;
            var diagResult = MessageBox.Show($"Removing project {ci.name}.\r\n\r\nAre you sure you want to remove this project from AutoToggl? You can add it again later.", "AutoToggl", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (diagResult == DialogResult.Yes) {
                trackedProjectsBindingList.Remove(ci);
                dh.SaveTrackedProjects(trackedProjectsBindingList.ToList());
            }
        }

        private void btnUpProjectListItem_Click(object sender, EventArgs e) => MoveProjectPosition(-1);

        private void btnDownProjectListItem_Click(object sender, EventArgs e) => MoveProjectPosition(1);

        private void MoveProjectPosition(int direction)
        {
            if (lstProjects.SelectedItem == null || lstProjects.SelectedIndex < 0)
                return;
            var newIndex = lstProjects.SelectedIndex + direction;
            if (newIndex < 0 || newIndex >= lstProjects.Items.Count)
                return;
            var proj = lstProjects.SelectedItem as TrackedProject;
            trackedProjectsBindingList.Remove(proj);
            trackedProjectsBindingList.Insert(newIndex, proj);
            var pos = 0;
            foreach(var item in lstProjects.Items) {
                var p = item as TrackedProject;
                p.position = pos;
                pos++;
            }
            dh.SaveTrackedProjects(trackedProjectsBindingList.ToList());
            lstProjects.SetSelected(newIndex, true);
        }

        private void lnkRegisterNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start($"https://toggl.com/app/projects/{txtTogglWorkspaceId.Text}/list");
        }

        private void picRefreshButton_MouseEnter(object sender, EventArgs e)
        {
            picRefreshButton.Image = Properties.Resources.refresh_hover;
        }

        private void picRefreshButton_MouseLeave(object sender, EventArgs e)
        {
            picRefreshButton.Image = Properties.Resources.refresh;
        }

        private void picRefreshButton_Click(object sender, EventArgs e)
        {
            ddlTogglProjects.DataSource = tb.GetProjects();
            ddlTogglProjects.DisplayMember = "name";
            ddlTogglProjects.ValueMember = "id";
        }

        private void txtTogglAPIKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            lnkTestAuth.Visible = true;
            lblConnectionStatus.Visible = false;
        }
    }

    public enum MoveProject
    {
        Up,
        Down
    }

    public enum KeywordDisplayMode
    {
        Display,
        Edit
    }
}
