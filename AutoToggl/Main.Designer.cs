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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTrackingProjectTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkToggleConsole = new System.Windows.Forms.LinkLabel();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.lblHr = new System.Windows.Forms.Label();
            this.pnlFancyTimer = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.pnlFancyTimer.SuspendLayout();
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
            this.lblTimer.Text = "0";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTrackingProjectTitle
            // 
            this.lblTrackingProjectTitle.AutoSize = true;
            this.lblTrackingProjectTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackingProjectTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTrackingProjectTitle.Location = new System.Drawing.Point(5, 91);
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
            this.label3.Location = new System.Drawing.Point(9, 73);
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
            this.picMenu.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // lblHr
            // 
            this.lblHr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHr.BackColor = System.Drawing.Color.Transparent;
            this.lblHr.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHr.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHr.Location = new System.Drawing.Point(-18, -26);
            this.lblHr.Margin = new System.Windows.Forms.Padding(0);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(160, 128);
            this.lblHr.TabIndex = 3;
            this.lblHr.Text = "0";
            this.lblHr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlFancyTimer
            // 
            this.pnlFancyTimer.Controls.Add(this.label5);
            this.pnlFancyTimer.Controls.Add(this.lblSec);
            this.pnlFancyTimer.Controls.Add(this.label2);
            this.pnlFancyTimer.Controls.Add(this.lblMin);
            this.pnlFancyTimer.Controls.Add(this.label1);
            this.pnlFancyTimer.Controls.Add(this.lblHr);
            this.pnlFancyTimer.Location = new System.Drawing.Point(332, 5);
            this.pnlFancyTimer.Name = "pnlFancyTimer";
            this.pnlFancyTimer.Size = new System.Drawing.Size(457, 86);
            this.pnlFancyTimer.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(434, -19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 102);
            this.label5.TabIndex = 10;
            this.label5.Text = "s";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblSec
            // 
            this.lblSec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSec.BackColor = System.Drawing.Color.Transparent;
            this.lblSec.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSec.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSec.Location = new System.Drawing.Point(302, -22);
            this.lblSec.Margin = new System.Windows.Forms.Padding(0);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(160, 128);
            this.lblSec.TabIndex = 9;
            this.lblSec.Text = "0";
            this.lblSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(274, -19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 102);
            this.label2.TabIndex = 8;
            this.label2.Text = "m";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblMin
            // 
            this.lblMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblMin.Location = new System.Drawing.Point(142, -22);
            this.lblMin.Margin = new System.Windows.Forms.Padding(0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(160, 128);
            this.lblMin.TabIndex = 7;
            this.lblMin.Text = "0";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, -16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 102);
            this.label1.TabIndex = 6;
            this.label1.Text = "h";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Show AutoToggl";
            this.notifyIcon1.BalloonTipTitle = "AutoToggl";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AutoToggl";
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(801, 671);
            this.Controls.Add(this.pnlFancyTimer);
            this.Controls.Add(this.picMenu);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.lnkToggleConsole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTrackingProjectTitle);
            this.Controls.Add(this.lblTimer);
            this.Name = "Main";
            this.Text = "AutoToggl";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.pnlFancyTimer.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblHr;
        private System.Windows.Forms.Panel pnlFancyTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

