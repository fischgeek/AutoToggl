namespace AutoToggl
{
    partial class Main
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTrackingProjectTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkToggleConsole = new System.Windows.Forms.LinkLabel();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTimer.Location = new System.Drawing.Point(612, -17);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(211, 128);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "143";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTrackingProjectTitle
            // 
            this.lblTrackingProjectTitle.AutoSize = true;
            this.lblTrackingProjectTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackingProjectTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTrackingProjectTitle.Location = new System.Drawing.Point(9, 74);
            this.lblTrackingProjectTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTrackingProjectTitle.Name = "lblTrackingProjectTitle";
            this.lblTrackingProjectTitle.Size = new System.Drawing.Size(205, 37);
            this.lblTrackingProjectTitle.TabIndex = 3;
            this.lblTrackingProjectTitle.Text = "PROJECT NAME";
            this.lblTrackingProjectTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tracking";
            // 
            // lnkToggleConsole
            // 
            this.lnkToggleConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkToggleConsole.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkToggleConsole.Location = new System.Drawing.Point(698, 225);
            this.lnkToggleConsole.Name = "lnkToggleConsole";
            this.lnkToggleConsole.Size = new System.Drawing.Size(87, 23);
            this.lnkToggleConsole.TabIndex = 6;
            this.lnkToggleConsole.TabStop = true;
            this.lnkToggleConsole.Text = "Show Console";
            this.lnkToggleConsole.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkToggleConsole.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkToggleConsole_LinkClicked);
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.White;
            this.txtConsole.Location = new System.Drawing.Point(13, 257);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(776, 400);
            this.txtConsole.TabIndex = 7;
            this.txtConsole.Text = "";
            this.txtConsole.Visible = false;
            this.txtConsole.WordWrap = false;
            this.txtConsole.TextChanged += new System.EventHandler(this.txtConsole_TextChanged);
            // 
            // picMenu
            // 
            this.picMenu.Image = global::AutoToggl.Properties.Resources.menu;
            this.picMenu.Location = new System.Drawing.Point(12, 12);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(32, 32);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 8;
            this.picMenu.TabStop = false;
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            this.picMenu.MouseEnter += new System.EventHandler(this.picMenu_MouseEnter);
            this.picMenu.MouseLeave += new System.EventHandler(this.picMenu_MouseLeave);
            this.picMenu.MouseHover += new System.EventHandler(this.picMenu_MouseHover);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(801, 671);
            this.Controls.Add(this.picMenu);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.lnkToggleConsole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTrackingProjectTitle);
            this.Controls.Add(this.lblTimer);
            this.Name = "Main";
            this.Text = "AutoToggl";
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTrackingProjectTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkToggleConsole;
        private System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.PictureBox picMenu;
    }
}

