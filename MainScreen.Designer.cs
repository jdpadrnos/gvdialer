namespace GVDialer
{
    partial class MainScreen
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
            if (disposing && (components != null))
            {
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
            this.mPictureBox = new System.Windows.Forms.PictureBox();
            this.mTimer = new System.Windows.Forms.Timer(this.components);
            this.mTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mCallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCallContactsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCallRecentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCallBox = new System.Windows.Forms.ToolStripTextBox();
            this.mSmsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSmsContactsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSmsRecentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSmsBox = new System.Windows.Forms.ToolStripTextBox();
            this.mInboxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mExitSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSettingsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mAboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mPictureBox)).BeginInit();
            this.mContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mPictureBox
            // 
            this.mPictureBox.Image = global::GVDialer.Properties.Resources.SplashImage;
            this.mPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.mPictureBox.Name = "mPictureBox";
            this.mPictureBox.Size = new System.Drawing.Size(210, 55);
            this.mPictureBox.TabIndex = 0;
            this.mPictureBox.TabStop = false;
            // 
            // mTimer
            // 
            this.mTimer.Enabled = true;
            this.mTimer.Interval = 5000;
            this.mTimer.Tick += new System.EventHandler(this.HandleTimerTick);
            // 
            // mTrayIcon
            // 
            this.mTrayIcon.ContextMenuStrip = this.mContextMenu;
            this.mTrayIcon.Icon = global::GVDialer.Properties.Resources.InactiveIcon;
            this.mTrayIcon.Text = "GVDialer";
            this.mTrayIcon.Visible = true;
            // 
            // mContextMenu
            // 
            this.mContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCallMenuItem,
            this.mSmsMenuItem,
            this.mInboxMenuItem,
            this.mSettingsSeparator,
            this.mSettingsMenuItem,
            this.mAboutMenuItem,
            this.mExitSeparator,
            this.mExitMenuItem});
            this.mContextMenu.Name = "mContextMenu";
            this.mContextMenu.Size = new System.Drawing.Size(153, 170);
            // 
            // mCallMenuItem
            // 
            this.mCallMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCallContactsMenuItem,
            this.mCallRecentMenuItem,
            this.mCallBox});
            this.mCallMenuItem.Enabled = false;
            this.mCallMenuItem.Name = "mCallMenuItem";
            this.mCallMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mCallMenuItem.Text = "&Call";
            this.mCallMenuItem.DropDownOpening += new System.EventHandler(this.HandleCallOpening);
            // 
            // mCallContactsMenuItem
            // 
            this.mCallContactsMenuItem.Enabled = false;
            this.mCallContactsMenuItem.Name = "mCallContactsMenuItem";
            this.mCallContactsMenuItem.Size = new System.Drawing.Size(160, 22);
            this.mCallContactsMenuItem.Text = "Contacts";
            this.mCallContactsMenuItem.Visible = false;
            // 
            // mCallRecentMenuItem
            // 
            this.mCallRecentMenuItem.Enabled = false;
            this.mCallRecentMenuItem.Name = "mCallRecentMenuItem";
            this.mCallRecentMenuItem.Size = new System.Drawing.Size(160, 22);
            this.mCallRecentMenuItem.Text = "Recent";
            // 
            // mCallBox
            // 
            this.mCallBox.Name = "mCallBox";
            this.mCallBox.Size = new System.Drawing.Size(100, 23);
            this.mCallBox.ToolTipText = "Enter phone number";
            this.mCallBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleBoxKeyUp);
            this.mCallBox.TextChanged += new System.EventHandler(this.HandleBoxTextChanged);
            // 
            // mSmsMenuItem
            // 
            this.mSmsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSmsContactsMenuItem,
            this.mSmsRecentMenuItem,
            this.mSmsBox});
            this.mSmsMenuItem.Enabled = false;
            this.mSmsMenuItem.Name = "mSmsMenuItem";
            this.mSmsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mSmsMenuItem.Text = "Send &SMS";
            this.mSmsMenuItem.DropDownOpening += new System.EventHandler(this.HandleSmsOpening);
            // 
            // mSmsContactsMenuItem
            // 
            this.mSmsContactsMenuItem.Enabled = false;
            this.mSmsContactsMenuItem.Name = "mSmsContactsMenuItem";
            this.mSmsContactsMenuItem.Size = new System.Drawing.Size(160, 22);
            this.mSmsContactsMenuItem.Text = "Contacts";
            this.mSmsContactsMenuItem.Visible = false;
            // 
            // mSmsRecentMenuItem
            // 
            this.mSmsRecentMenuItem.Enabled = false;
            this.mSmsRecentMenuItem.Name = "mSmsRecentMenuItem";
            this.mSmsRecentMenuItem.Size = new System.Drawing.Size(160, 22);
            this.mSmsRecentMenuItem.Text = "Recent";
            // 
            // mSmsBox
            // 
            this.mSmsBox.Name = "mSmsBox";
            this.mSmsBox.Size = new System.Drawing.Size(100, 23);
            this.mSmsBox.ToolTipText = "Enter phone number";
            this.mSmsBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleBoxKeyUp);
            // 
            // mInboxMenuItem
            // 
            this.mInboxMenuItem.Enabled = false;
            this.mInboxMenuItem.Name = "mInboxMenuItem";
            this.mInboxMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mInboxMenuItem.Text = "Open &Inbox...";
            this.mInboxMenuItem.Click += new System.EventHandler(this.HandleInboxClick);
            // 
            // mSettingsMenuItem
            // 
            this.mSettingsMenuItem.Name = "mSettingsMenuItem";
            this.mSettingsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mSettingsMenuItem.Text = "&Settings...";
            this.mSettingsMenuItem.Click += new System.EventHandler(this.HandleSettingsClick);
            // 
            // mExitSeparator
            // 
            this.mExitSeparator.Name = "mExitSeparator";
            this.mExitSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // mExitMenuItem
            // 
            this.mExitMenuItem.Name = "mExitMenuItem";
            this.mExitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mExitMenuItem.Text = "E&xit";
            this.mExitMenuItem.Click += new System.EventHandler(this.HandleExitClick);
            // 
            // mSettingsSeparator
            // 
            this.mSettingsSeparator.Name = "mSettingsSeparator";
            this.mSettingsSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // mAboutMenuItem
            // 
            this.mAboutMenuItem.Name = "mAboutMenuItem";
            this.mAboutMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mAboutMenuItem.Text = "About...";
            this.mAboutMenuItem.Click += new System.EventHandler(this.HandleAboutClick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(210, 55);
            this.Controls.Add(this.mPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::GVDialer.Properties.Resources.ActiveIcon;
            this.Name = "MainScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GVDialer";
            this.Shown += new System.EventHandler(this.HandleShown);
            ((System.ComponentModel.ISupportInitialize)(this.mPictureBox)).EndInit();
            this.mContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mPictureBox;
        private System.Windows.Forms.Timer mTimer;
        private System.Windows.Forms.NotifyIcon mTrayIcon;
        private System.Windows.Forms.ContextMenuStrip mContextMenu;
        private System.Windows.Forms.ToolStripMenuItem mExitMenuItem;
        private System.Windows.Forms.ToolStripSeparator mExitSeparator;
        private System.Windows.Forms.ToolStripMenuItem mSettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mCallMenuItem;
        private System.Windows.Forms.ToolStripTextBox mCallBox;
        private System.Windows.Forms.ToolStripMenuItem mCallContactsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mCallRecentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSmsMenuItem;
        private System.Windows.Forms.ToolStripTextBox mSmsBox;
        private System.Windows.Forms.ToolStripMenuItem mSmsContactsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSmsRecentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mInboxMenuItem;
        private System.Windows.Forms.ToolStripSeparator mSettingsSeparator;
        private System.Windows.Forms.ToolStripMenuItem mAboutMenuItem;
    }
}
