namespace GVDialer
{
    partial class SettingsDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.mAccountGroup = new System.Windows.Forms.GroupBox();
            this.mAccountLayout = new System.Windows.Forms.TableLayoutPanel();
            this.mEmailLabel = new System.Windows.Forms.Label();
            this.mPasswordLabel = new System.Windows.Forms.Label();
            this.mEmailBox = new System.Windows.Forms.TextBox();
            this.mPasswordBox = new System.Windows.Forms.TextBox();
            this.mFormLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.mOptionsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.mCallbackLabel = new System.Windows.Forms.Label();
            this.mCallbackBox = new System.Windows.Forms.TextBox();
            this.mButtonLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.mCancelButton = new System.Windows.Forms.Button();
            this.mOkButton = new System.Windows.Forms.Button();
            this.mAccountGroup.SuspendLayout();
            this.mAccountLayout.SuspendLayout();
            this.mFormLayout.SuspendLayout();
            this.mOptionsLayout.SuspendLayout();
            this.mButtonLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAccountGroup
            // 
            this.mAccountGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mAccountGroup.Controls.Add(this.mAccountLayout);
            this.mAccountGroup.Location = new System.Drawing.Point(8, 8);
            this.mAccountGroup.Name = "mAccountGroup";
            this.mAccountGroup.Padding = new System.Windows.Forms.Padding(8);
            this.mAccountGroup.Size = new System.Drawing.Size(259, 83);
            this.mAccountGroup.TabIndex = 0;
            this.mAccountGroup.TabStop = false;
            this.mAccountGroup.Text = "Google Voice Account";
            // 
            // mAccountLayout
            // 
            this.mAccountLayout.ColumnCount = 2;
            this.mAccountLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mAccountLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mAccountLayout.Controls.Add(this.mEmailLabel, 0, 0);
            this.mAccountLayout.Controls.Add(this.mPasswordLabel, 0, 1);
            this.mAccountLayout.Controls.Add(this.mEmailBox, 1, 0);
            this.mAccountLayout.Controls.Add(this.mPasswordBox, 1, 1);
            this.mAccountLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mAccountLayout.Location = new System.Drawing.Point(8, 21);
            this.mAccountLayout.Name = "mAccountLayout";
            this.mAccountLayout.RowCount = 2;
            this.mAccountLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mAccountLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mAccountLayout.Size = new System.Drawing.Size(243, 54);
            this.mAccountLayout.TabIndex = 0;
            // 
            // mEmailLabel
            // 
            this.mEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mEmailLabel.AutoSize = true;
            this.mEmailLabel.Location = new System.Drawing.Point(3, 7);
            this.mEmailLabel.Name = "mEmailLabel";
            this.mEmailLabel.Size = new System.Drawing.Size(76, 13);
            this.mEmailLabel.TabIndex = 0;
            this.mEmailLabel.Text = "Email Address:";
            // 
            // mPasswordLabel
            // 
            this.mPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mPasswordLabel.AutoSize = true;
            this.mPasswordLabel.Location = new System.Drawing.Point(23, 34);
            this.mPasswordLabel.Name = "mPasswordLabel";
            this.mPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.mPasswordLabel.TabIndex = 2;
            this.mPasswordLabel.Text = "Password:";
            // 
            // mEmailBox
            // 
            this.mEmailBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mEmailBox.Location = new System.Drawing.Point(85, 3);
            this.mEmailBox.Name = "mEmailBox";
            this.mEmailBox.Size = new System.Drawing.Size(155, 20);
            this.mEmailBox.TabIndex = 1;
            // 
            // mPasswordBox
            // 
            this.mPasswordBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPasswordBox.Location = new System.Drawing.Point(85, 30);
            this.mPasswordBox.Name = "mPasswordBox";
            this.mPasswordBox.Size = new System.Drawing.Size(155, 20);
            this.mPasswordBox.TabIndex = 3;
            this.mPasswordBox.UseSystemPasswordChar = true;
            // 
            // mFormLayout
            // 
            this.mFormLayout.AutoSize = true;
            this.mFormLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mFormLayout.Controls.Add(this.mAccountGroup);
            this.mFormLayout.Controls.Add(this.mOptionsLayout);
            this.mFormLayout.Controls.Add(this.mButtonLayout);
            this.mFormLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mFormLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mFormLayout.Location = new System.Drawing.Point(0, 0);
            this.mFormLayout.Name = "mFormLayout";
            this.mFormLayout.Padding = new System.Windows.Forms.Padding(5);
            this.mFormLayout.Size = new System.Drawing.Size(274, 171);
            this.mFormLayout.TabIndex = 2;
            // 
            // mOptionsLayout
            // 
            this.mOptionsLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mOptionsLayout.AutoSize = true;
            this.mOptionsLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mOptionsLayout.ColumnCount = 2;
            this.mOptionsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mOptionsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mOptionsLayout.Controls.Add(this.mCallbackLabel, 0, 0);
            this.mOptionsLayout.Controls.Add(this.mCallbackBox, 1, 0);
            this.mOptionsLayout.Location = new System.Drawing.Point(8, 97);
            this.mOptionsLayout.Name = "mOptionsLayout";
            this.mOptionsLayout.RowCount = 1;
            this.mOptionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mOptionsLayout.Size = new System.Drawing.Size(259, 26);
            this.mOptionsLayout.TabIndex = 1;
            // 
            // mCallbackLabel
            // 
            this.mCallbackLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mCallbackLabel.AutoSize = true;
            this.mCallbackLabel.Location = new System.Drawing.Point(3, 6);
            this.mCallbackLabel.Name = "mCallbackLabel";
            this.mCallbackLabel.Size = new System.Drawing.Size(89, 13);
            this.mCallbackLabel.TabIndex = 1;
            this.mCallbackLabel.Text = "Callback number:";
            // 
            // mCallbackBox
            // 
            this.mCallbackBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mCallbackBox.Location = new System.Drawing.Point(98, 3);
            this.mCallbackBox.Name = "mCallbackBox";
            this.mCallbackBox.Size = new System.Drawing.Size(158, 20);
            this.mCallbackBox.TabIndex = 1;
            // 
            // mButtonLayout
            // 
            this.mButtonLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonLayout.AutoSize = true;
            this.mButtonLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mButtonLayout.Controls.Add(this.mCancelButton);
            this.mButtonLayout.Controls.Add(this.mOkButton);
            this.mButtonLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.mButtonLayout.Location = new System.Drawing.Point(105, 134);
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
            // SettingsForm
            // 
            this.AcceptButton = this.mOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.mCancelButton;
            this.ClientSize = new System.Drawing.Size(274, 171);
            this.Controls.Add(this.mFormLayout);
            this.Icon = global::GVDialer.Properties.Resources.ActiveIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "GVDialer Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HandleFormClosing);
            this.mAccountGroup.ResumeLayout(false);
            this.mAccountLayout.ResumeLayout(false);
            this.mAccountLayout.PerformLayout();
            this.mFormLayout.ResumeLayout(false);
            this.mFormLayout.PerformLayout();
            this.mOptionsLayout.ResumeLayout(false);
            this.mOptionsLayout.PerformLayout();
            this.mButtonLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mAccountGroup;
        private System.Windows.Forms.Label mEmailLabel;
        private System.Windows.Forms.TextBox mEmailBox;
        private System.Windows.Forms.Label mPasswordLabel;
        private System.Windows.Forms.TextBox mPasswordBox;
        private System.Windows.Forms.Label mCallbackLabel;
        private System.Windows.Forms.TextBox mCallbackBox;
        private System.Windows.Forms.Button mCancelButton;
        private System.Windows.Forms.Button mOkButton;
        private System.Windows.Forms.FlowLayoutPanel mFormLayout;
        private System.Windows.Forms.TableLayoutPanel mAccountLayout;
        private System.Windows.Forms.TableLayoutPanel mOptionsLayout;
        private System.Windows.Forms.FlowLayoutPanel mButtonLayout;
    }
}

