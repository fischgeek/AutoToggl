namespace AutoToggl
{
    partial class ConfigureProjects
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDownProjectListItem = new System.Windows.Forms.Button();
            this.btnUpProjectListItem = new System.Windows.Forms.Button();
            this.lstProjects = new System.Windows.Forms.ListBox();
            this.lnkSaveEdits = new System.Windows.Forms.LinkLabel();
            this.lstKeywords = new System.Windows.Forms.ListBox();
            this.lnkCancelEdit = new System.Windows.Forms.LinkLabel();
            this.lnkEditKeywords = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKeywordList = new System.Windows.Forms.TextBox();
            this.lblTogglProjects = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(792, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 41);
            this.button3.TabIndex = 29;
            this.button3.Text = "\\/";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(793, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 41);
            this.button4.TabIndex = 28;
            this.button4.Text = "/\\";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnDownProjectListItem
            // 
            this.btnDownProjectListItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDownProjectListItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownProjectListItem.ForeColor = System.Drawing.Color.White;
            this.btnDownProjectListItem.Location = new System.Drawing.Point(321, 155);
            this.btnDownProjectListItem.Name = "btnDownProjectListItem";
            this.btnDownProjectListItem.Size = new System.Drawing.Size(57, 41);
            this.btnDownProjectListItem.TabIndex = 27;
            this.btnDownProjectListItem.Text = "\\/";
            this.btnDownProjectListItem.UseVisualStyleBackColor = false;
            this.btnDownProjectListItem.Click += new System.EventHandler(this.btnDownProjectListItem_Click);
            // 
            // btnUpProjectListItem
            // 
            this.btnUpProjectListItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpProjectListItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpProjectListItem.ForeColor = System.Drawing.Color.White;
            this.btnUpProjectListItem.Location = new System.Drawing.Point(322, 108);
            this.btnUpProjectListItem.Name = "btnUpProjectListItem";
            this.btnUpProjectListItem.Size = new System.Drawing.Size(56, 41);
            this.btnUpProjectListItem.TabIndex = 26;
            this.btnUpProjectListItem.Text = "/\\";
            this.btnUpProjectListItem.UseVisualStyleBackColor = false;
            this.btnUpProjectListItem.Click += new System.EventHandler(this.btnUpProjectListItem_Click);
            // 
            // lstProjects
            // 
            this.lstProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProjects.ForeColor = System.Drawing.Color.White;
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.ItemHeight = 18;
            this.lstProjects.Items.AddRange(new object[] {
            "project a",
            "project b",
            "project c",
            "project d"});
            this.lstProjects.Location = new System.Drawing.Point(12, 29);
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(303, 256);
            this.lstProjects.TabIndex = 25;
            // 
            // lnkSaveEdits
            // 
            this.lnkSaveEdits.AutoSize = true;
            this.lnkSaveEdits.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkSaveEdits.Location = new System.Drawing.Point(526, 10);
            this.lnkSaveEdits.Name = "lnkSaveEdits";
            this.lnkSaveEdits.Size = new System.Drawing.Size(32, 13);
            this.lnkSaveEdits.TabIndex = 24;
            this.lnkSaveEdits.TabStop = true;
            this.lnkSaveEdits.Text = "Save";
            this.lnkSaveEdits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSaveEdits_LinkClicked);
            // 
            // lstKeywords
            // 
            this.lstKeywords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstKeywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstKeywords.ForeColor = System.Drawing.Color.White;
            this.lstKeywords.FormattingEnabled = true;
            this.lstKeywords.ItemHeight = 18;
            this.lstKeywords.Location = new System.Drawing.Point(418, 30);
            this.lstKeywords.Name = "lstKeywords";
            this.lstKeywords.Size = new System.Drawing.Size(368, 256);
            this.lstKeywords.TabIndex = 23;
            // 
            // lnkCancelEdit
            // 
            this.lnkCancelEdit.AutoSize = true;
            this.lnkCancelEdit.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkCancelEdit.Location = new System.Drawing.Point(564, 11);
            this.lnkCancelEdit.Name = "lnkCancelEdit";
            this.lnkCancelEdit.Size = new System.Drawing.Size(40, 13);
            this.lnkCancelEdit.TabIndex = 22;
            this.lnkCancelEdit.TabStop = true;
            this.lnkCancelEdit.Text = "Cancel";
            this.lnkCancelEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCancelEdit_LinkClicked);
            // 
            // lnkEditKeywords
            // 
            this.lnkEditKeywords.AutoSize = true;
            this.lnkEditKeywords.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkEditKeywords.Location = new System.Drawing.Point(495, 11);
            this.lnkEditKeywords.Name = "lnkEditKeywords";
            this.lnkEditKeywords.Size = new System.Drawing.Size(25, 13);
            this.lnkEditKeywords.TabIndex = 21;
            this.lnkEditKeywords.TabStop = true;
            this.lnkEditKeywords.Text = "Edit";
            this.lnkEditKeywords.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditKeywords_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(415, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Keywords";
            // 
            // txtKeywordList
            // 
            this.txtKeywordList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeywordList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKeywordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeywordList.ForeColor = System.Drawing.Color.White;
            this.txtKeywordList.Location = new System.Drawing.Point(418, 30);
            this.txtKeywordList.Multiline = true;
            this.txtKeywordList.Name = "txtKeywordList";
            this.txtKeywordList.Size = new System.Drawing.Size(367, 255);
            this.txtKeywordList.TabIndex = 19;
            // 
            // lblTogglProjects
            // 
            this.lblTogglProjects.AutoSize = true;
            this.lblTogglProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTogglProjects.ForeColor = System.Drawing.Color.White;
            this.lblTogglProjects.Location = new System.Drawing.Point(8, 7);
            this.lblTogglProjects.Name = "lblTogglProjects";
            this.lblTogglProjects.Size = new System.Drawing.Size(104, 18);
            this.lblTogglProjects.TabIndex = 18;
            this.lblTogglProjects.Text = "Toggl Projects";
            // 
            // ConfigureProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(893, 398);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDownProjectListItem);
            this.Controls.Add(this.btnUpProjectListItem);
            this.Controls.Add(this.lstProjects);
            this.Controls.Add(this.lnkSaveEdits);
            this.Controls.Add(this.lstKeywords);
            this.Controls.Add(this.lnkCancelEdit);
            this.Controls.Add(this.lnkEditKeywords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKeywordList);
            this.Controls.Add(this.lblTogglProjects);
            this.Name = "ConfigureProjects";
            this.Text = "ConfigureProjects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDownProjectListItem;
        private System.Windows.Forms.Button btnUpProjectListItem;
        private System.Windows.Forms.ListBox lstProjects;
        private System.Windows.Forms.LinkLabel lnkSaveEdits;
        private System.Windows.Forms.ListBox lstKeywords;
        private System.Windows.Forms.LinkLabel lnkCancelEdit;
        private System.Windows.Forms.LinkLabel lnkEditKeywords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKeywordList;
        private System.Windows.Forms.Label lblTogglProjects;
    }
}