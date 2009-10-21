namespace GVDialer
{
    partial class ErrorDialog
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
            this.mMessageLabel = new System.Windows.Forms.Label();
            this.mDetailLink = new System.Windows.Forms.LinkLabel();
            this.mDetailLabel = new System.Windows.Forms.Label();
            this.mOkButton = new System.Windows.Forms.Button();
            this.mTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMessageLabel
            // 
            this.mMessageLabel.AutoSize = true;
            this.mMessageLabel.Location = new System.Drawing.Point(13, 10);
            this.mMessageLabel.MaximumSize = new System.Drawing.Size(400, 300);
            this.mMessageLabel.Name = "mMessageLabel";
            this.mMessageLabel.Size = new System.Drawing.Size(50, 13);
            this.mMessageLabel.TabIndex = 2;
            this.mMessageLabel.Text = "Message";
            // 
            // mDetailLink
            // 
            this.mDetailLink.AutoSize = true;
            this.mDetailLink.Location = new System.Drawing.Point(13, 23);
            this.mDetailLink.Name = "mDetailLink";
            this.mDetailLink.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.mDetailLink.Size = new System.Drawing.Size(68, 23);
            this.mDetailLink.TabIndex = 1;
            this.mDetailLink.TabStop = true;
            this.mDetailLink.Text = "More detail...";
            this.mDetailLink.Click += new System.EventHandler(this.HandleDetailClick);
            // 
            // mDetailLabel
            // 
            this.mDetailLabel.AutoSize = true;
            this.mDetailLabel.Location = new System.Drawing.Point(13, 46);
            this.mDetailLabel.MaximumSize = new System.Drawing.Size(600, 600);
            this.mDetailLabel.Name = "mDetailLabel";
            this.mDetailLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.mDetailLabel.Size = new System.Drawing.Size(34, 23);
            this.mDetailLabel.TabIndex = 3;
            this.mDetailLabel.Text = "Detail";
            this.mDetailLabel.Visible = false;
            // 
            // mOkButton
            // 
            this.mOkButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mOkButton.AutoSize = true;
            this.mOkButton.Location = new System.Drawing.Point(13, 82);
            this.mOkButton.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.mOkButton.Name = "mOkButton";
            this.mOkButton.Size = new System.Drawing.Size(75, 23);
            this.mOkButton.TabIndex = 0;
            this.mOkButton.Text = "OK";
            this.mOkButton.UseVisualStyleBackColor = true;
            this.mOkButton.Click += new System.EventHandler(this.HandleOkClick);
            // 
            // mTableLayoutPanel
            // 
            this.mTableLayoutPanel.AutoSize = true;
            this.mTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mTableLayoutPanel.ColumnCount = 1;
            this.mTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mTableLayoutPanel.Controls.Add(this.mOkButton, 0, 3);
            this.mTableLayoutPanel.Controls.Add(this.mDetailLabel, 0, 2);
            this.mTableLayoutPanel.Controls.Add(this.mDetailLink, 0, 1);
            this.mTableLayoutPanel.Controls.Add(this.mMessageLabel, 0, 0);
            this.mTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mTableLayoutPanel.Name = "mTableLayoutPanel";
            this.mTableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mTableLayoutPanel.RowCount = 4;
            this.mTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mTableLayoutPanel.Size = new System.Drawing.Size(101, 118);
            this.mTableLayoutPanel.TabIndex = 1;
            // 
            // ErrorDialog
            // 
            this.AcceptButton = this.mOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(180, 122);
            this.Controls.Add(this.mTableLayoutPanel);
            this.Icon = global::GVDialer.Properties.Resources.ActiveIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error detected";
            this.mTableLayoutPanel.ResumeLayout(false);
            this.mTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mMessageLabel;
        private System.Windows.Forms.Button mOkButton;
        private System.Windows.Forms.LinkLabel mDetailLink;
        private System.Windows.Forms.Label mDetailLabel;
        private System.Windows.Forms.TableLayoutPanel mTableLayoutPanel;
    }
}