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
            this.mToLabel = new System.Windows.Forms.Label();
            this.mMessageBox = new System.Windows.Forms.TextBox();
            this.mButtonLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.mCancelButton = new System.Windows.Forms.Button();
            this.mOkButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mButtonLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mToLabel
            // 
            this.mToLabel.AutoSize = true;
            this.mToLabel.Location = new System.Drawing.Point(13, 10);
            this.mToLabel.Name = "mToLabel";
            this.mToLabel.Size = new System.Drawing.Size(26, 13);
            this.mToLabel.TabIndex = 3;
            this.mToLabel.Text = "To: ";
            // 
            // mMessageBox
            // 
            this.mMessageBox.Location = new System.Drawing.Point(13, 26);
            this.mMessageBox.Multiline = true;
            this.mMessageBox.Name = "mMessageBox";
            this.mMessageBox.Size = new System.Drawing.Size(233, 112);
            this.mMessageBox.TabIndex = 4;
            // 
            // mButtonLayout
            // 
            this.mButtonLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonLayout.AutoSize = true;
            this.mButtonLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mButtonLayout.Controls.Add(this.mCancelButton);
            this.mButtonLayout.Controls.Add(this.mOkButton);
            this.mButtonLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.mButtonLayout.Location = new System.Drawing.Point(84, 149);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mButtonLayout, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mMessageBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mToLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 188);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // SMSDialog
            // 
            this.AcceptButton = this.mOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.mCancelButton;
            this.ClientSize = new System.Drawing.Size(259, 188);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = global::GVDialer.Properties.Resources.ActiveIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SMSDialog";
            this.Text = "Send SMS";
            this.mButtonLayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mCancelButton;
        private System.Windows.Forms.Button mOkButton;
        private System.Windows.Forms.FlowLayoutPanel mButtonLayout;
        private System.Windows.Forms.Label mToLabel;
        private System.Windows.Forms.TextBox mMessageBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}