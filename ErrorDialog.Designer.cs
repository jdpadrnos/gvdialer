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
            this.mFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mMessageLabel = new System.Windows.Forms.Label();
            this.mDetailLink = new System.Windows.Forms.LinkLabel();
            this.mDetailLabel = new System.Windows.Forms.Label();
            this.mOkButton = new System.Windows.Forms.Button();
            this.mFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mFlowLayoutPanel
            // 
            this.mFlowLayoutPanel.AutoSize = true;
            this.mFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mFlowLayoutPanel.Controls.Add(this.mMessageLabel);
            this.mFlowLayoutPanel.Controls.Add(this.mDetailLink);
            this.mFlowLayoutPanel.Controls.Add(this.mDetailLabel);
            this.mFlowLayoutPanel.Controls.Add(this.mOkButton);
            this.mFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mFlowLayoutPanel.Name = "mFlowLayoutPanel";
            this.mFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.mFlowLayoutPanel.Size = new System.Drawing.Size(91, 78);
            this.mFlowLayoutPanel.TabIndex = 0;
            // 
            // mMessageLabel
            // 
            this.mMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mMessageLabel.AutoSize = true;
            this.mMessageLabel.Location = new System.Drawing.Point(8, 5);
            this.mMessageLabel.Name = "mMessageLabel";
            this.mMessageLabel.Size = new System.Drawing.Size(75, 13);
            this.mMessageLabel.TabIndex = 0;
            this.mMessageLabel.Text = "Message";
            // 
            // mDetailLink
            // 
            this.mDetailLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mDetailLink.AutoSize = true;
            this.mDetailLink.Location = new System.Drawing.Point(8, 18);
            this.mDetailLink.Name = "mDetailLink";
            this.mDetailLink.Size = new System.Drawing.Size(75, 13);
            this.mDetailLink.TabIndex = 3;
            this.mDetailLink.TabStop = true;
            this.mDetailLink.Text = "More detail...";
            this.mDetailLink.Click += new System.EventHandler(this.HandleDetailClick);
            // 
            // mDetailLabel
            // 
            this.mDetailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mDetailLabel.AutoSize = true;
            this.mDetailLabel.Location = new System.Drawing.Point(8, 31);
            this.mDetailLabel.Name = "mDetailLabel";
            this.mDetailLabel.Size = new System.Drawing.Size(75, 13);
            this.mDetailLabel.TabIndex = 1;
            this.mDetailLabel.Text = "Detail";
            this.mDetailLabel.Visible = false;
            // 
            // mOkButton
            // 
            this.mOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mOkButton.AutoSize = true;
            this.mFlowLayoutPanel.SetFlowBreak(this.mOkButton, true);
            this.mOkButton.Location = new System.Drawing.Point(8, 47);
            this.mOkButton.Name = "mOkButton";
            this.mOkButton.Size = new System.Drawing.Size(75, 23);
            this.mOkButton.TabIndex = 2;
            this.mOkButton.Text = "OK";
            this.mOkButton.UseVisualStyleBackColor = true;
            // 
            // ErrorDialog
            // 
            this.AcceptButton = this.mOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 0);
            this.Controls.Add(this.mFlowLayoutPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 36);
            this.MinimizeBox = false;
            this.Icon = global::GVDialer.Properties.Resources.ActiveIcon;
            this.Name = "ErrorDialog";
            this.ShowInTaskbar = false;
            this.Text = "Error detected";
            this.mFlowLayoutPanel.ResumeLayout(false);
            this.mFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mFlowLayoutPanel;
        private System.Windows.Forms.Label mMessageLabel;
        private System.Windows.Forms.Label mDetailLabel;
        private System.Windows.Forms.Button mOkButton;
        private System.Windows.Forms.LinkLabel mDetailLink;
    }
}