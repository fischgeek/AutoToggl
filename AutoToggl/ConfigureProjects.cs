using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoToggl
{
    public partial class ConfigureProjects : Form
    {
        public ConfigureProjects()
        {
            InitializeComponent();
            txtKeywordList.Visible = false;
            lstKeywords.Visible = true;
            lnkCancelEdit.Visible = false;
            lnkSaveEdits.Visible = false;
            lstKeywords.Items.Add("Hello");
            lstKeywords.Items.Add("Hello");
            lstKeywords.Items.Add("Hello");
            lstKeywords.SetSelected(1, true);
        }

        private void lnkEditKeywords_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtKeywordList.Visible = true;
            lstKeywords.Visible = false;
            lnkCancelEdit.Visible = true;
            lnkSaveEdits.Visible = true;
            this.Refresh();
        }

        private void lnkCancelEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtKeywordList.Visible = false;
            lnkCancelEdit.Visible = false;
            lnkEditKeywords.Text = "Edit";
            lstKeywords.Visible = true;
            this.Refresh();
        }

        private void lnkSaveEdits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtKeywordList.Visible = false;
            lstKeywords.Visible = true;
            lnkCancelEdit.Visible = false;
            lnkSaveEdits.Visible = false;
            this.Refresh();
        }

        private void btnUpProjectListItem_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void btnDownProjectListItem_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        public void MoveUp()
        {
            MoveItem(-1);
        }

        public void MoveDown()
        {
            MoveItem(1);
        }

        public void MoveItem(int direction)
        {
            // Checking selected item
            if (lstProjects.SelectedItem == null || lstProjects.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = lstProjects.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= lstProjects.Items.Count)
                return; // Index out of range - nothing to do

            object selected = lstProjects.SelectedItem;

            // Removing removable element
            lstProjects.Items.Remove(selected);
            // Insert it in new position
            lstProjects.Items.Insert(newIndex, selected);
            // Restore selection
            lstProjects.SetSelected(newIndex, true);
        }
    }
}
