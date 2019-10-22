using DesktopProjectDataHandler;
using System;
using System.Windows.Forms;
using SharedLibrary;

namespace AutoToggl
{
    public partial class Menu : Form
    {
        DataHandler dh = DataHandler.GetInstance();

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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
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
    }
}
