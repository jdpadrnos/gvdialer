namespace GVDialer
{
    partial class SMSDialog
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
            this.mFormLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.mButtonLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.mCancelButton = new System.Windows.Forms.Button();
            this.mOkButton = new System.Windows.Forms.Button();
            this.mToLabel = new System.Windows.Forms.Label();
            this.mMessageBox = new System.Windows.Forms.TextBox();
            this.mFormLayout.SuspendLayout();
            this.mButtonLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mFormLayout
            // 
            this.mFormLayout.AutoSize = true;
            this.mFormLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mFormLayout.Controls.Add(this.mToLabel);
            this.mFormLayout.Controls.Add(this.mMessageBox);
            this.mFormLayout.Controls.Add(this.mButtonLayout);
            this.mFormLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mFormLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mFormLayout.Location = new System.Drawing.Point(0, 0);
            this.mFormLayout.Name = "mFormLayout";
            this.mFormLayout.Padding = new System.Windows.Forms.Padding(5);
            this.mFormLayout.Size = new System.Drawing.Size(284, 264);
            this.mFormLayout.TabIndex = 2;
            // 
            // mButtonLayout
            // 
            this.mButtonLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonLayout.AutoSize = true;
            this.mButtonLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mButtonLayout.Controls.Add(this.mCancelButton);
            this.mButtonLayout.Controls.Add(this.mOkButton);
            this.mButtonLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.mButtonLayout.Location = new System.Drawing.Point(96, 144);
            this.mButtonLayout.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.mButtonLayout.Name = "mButtonLayout";
            this.mButtonLayout.Size = new System.Drawing.Size(162, 29);
            this.mButtonLayout.TabIndex = 2;
            // 
            // mCancelButton
            // 
            this.mCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mCancelButton.Location = new System.Drawing.Point(84, 3);
            this.mCancelButton.Name = "mCancelButton";
            this.mCancelButton.Size = new System.Drawing.Size(75, 23);
            this.mCancelButton.TabIndex = 1;
            this.mCancelButton.Text = "Cancel";
            this.mCancelButton.UseVisualStyleBackColor = true;
            // 
            // mOkButton
            // 
            this.mOkButton.Location = new System.Drawing.Point(3, 3);
            this.mOkButton.Name = "mOkButton";
            this.mOkButton.Size = new System.Drawing.Size(75, 23);
            this.mOkButton.TabIndex = 0;
            this.mOkButton.Text = "OK";
            this.mOkButton.UseVisualStyleBackColor = true;
            this.mOkButton.Click += new System.EventHandler(this.HandleOkClick);
            // 
            // mToLabel
            // 
            this.mToLabel.AutoSize = true;
            this.mToLabel.Location = new System.Drawing.Point(8, 5);
            this.mToLabel.Name = "mToLabel";
            this.mToLabel.Size = new System.Drawing.Size(26, 13);
            this.mToLabel.TabIndex = 3;
            this.mToLabel.Text = "To: ";
            // 
            // mMessageBox
            // 
            this.mMessageBox.Location = new System.Drawing.Point(8, 21);
            this.mMessageBox.Multiline = true;
            this.mMessageBox.Name = "mMessageBox";
            this.mMessageBox.Size = new System.Drawing.Size(250, 112);
            this.mMessageBox.TabIndex = 4;
            // 
            // SMSForm
            // 
            this.AcceptButton = this.mOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.mCancelButton;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.mFormLayout);
            this.Icon = global::GVDialer.Properties.Resources.ActiveIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SMSForm";
            this.Text = "Send SMS";
            this.mFormLayout.ResumeLayout(false);
            this.mFormLayout.PerformLayout();
            this.mButtonLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mCancelButton;
        private System.Windows.Forms.Button mOkButton;
        private System.Windows.Forms.FlowLayoutPanel mFormLayout;
        private System.Windows.Forms.FlowLayoutPanel mButtonLayout;
        private System.Windows.Forms.Label mToLabel;
        private System.Windows.Forms.TextBox mMessageBox;
    }
}