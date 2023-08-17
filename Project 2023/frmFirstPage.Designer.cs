namespace Project_2023
{
    partial class frmFirstPage
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtEnterUsername = new System.Windows.Forms.TextBox();
            this.lblEnterUsername = new System.Windows.Forms.Label();
            this.btnContinueFirstPage = new System.Windows.Forms.Button();
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipEntrerUsername = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCreateUser = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipContinue = new System.Windows.Forms.ToolTip(this.components);
            this.gbxFrontPage = new System.Windows.Forms.GroupBox();
            this.errorLabelNoUser = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbxFrontPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(96, 20);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(190, 94);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Readlist\r\n\r\n";
            // 
            // txtEnterUsername
            // 
            this.txtEnterUsername.Location = new System.Drawing.Point(17, 117);
            this.txtEnterUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnterUsername.Name = "txtEnterUsername";
            this.txtEnterUsername.Size = new System.Drawing.Size(369, 22);
            this.txtEnterUsername.TabIndex = 1;
            this.toolTipEntrerUsername.SetToolTip(this.txtEnterUsername, "Enter your username.");
            // 
            // lblEnterUsername
            // 
            this.lblEnterUsername.AutoSize = true;
            this.lblEnterUsername.Location = new System.Drawing.Point(17, 94);
            this.lblEnterUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterUsername.Name = "lblEnterUsername";
            this.lblEnterUsername.Size = new System.Drawing.Size(73, 16);
            this.lblEnterUsername.TabIndex = 2;
            this.lblEnterUsername.Text = "Username:";
            // 
            // btnContinueFirstPage
            // 
            this.btnContinueFirstPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinueFirstPage.Location = new System.Drawing.Point(253, 206);
            this.btnContinueFirstPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContinueFirstPage.Name = "btnContinueFirstPage";
            this.btnContinueFirstPage.Size = new System.Drawing.Size(111, 43);
            this.btnContinueFirstPage.TabIndex = 3;
            this.btnContinueFirstPage.Text = "Continue";
            this.toolTipContinue.SetToolTip(this.btnContinueFirstPage, "Continue to the next page.");
            this.btnContinueFirstPage.UseVisualStyleBackColor = true;
            this.btnContinueFirstPage.Click += new System.EventHandler(this.btnContinueFirstPage_Click);
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateProfile.Location = new System.Drawing.Point(37, 206);
            this.btnCreateProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreateProfile.Size = new System.Drawing.Size(111, 43);
            this.btnCreateProfile.TabIndex = 4;
            this.btnCreateProfile.Text = "Create";
            this.toolTipCreateUser.SetToolTip(this.btnCreateProfile, "Create a new account.");
            this.btnCreateProfile.UseVisualStyleBackColor = true;
            this.btnCreateProfile.Click += new System.EventHandler(this.btnCreateProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "New User?\r\nCreate an account:";
            // 
            // gbxFrontPage
            // 
            this.gbxFrontPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxFrontPage.Controls.Add(this.errorLabelNoUser);
            this.gbxFrontPage.Controls.Add(this.label1);
            this.gbxFrontPage.Controls.Add(this.btnCreateProfile);
            this.gbxFrontPage.Controls.Add(this.btnContinueFirstPage);
            this.gbxFrontPage.Controls.Add(this.lblEnterUsername);
            this.gbxFrontPage.Controls.Add(this.txtEnterUsername);
            this.gbxFrontPage.Controls.Add(this.lblHeading);
            this.gbxFrontPage.Location = new System.Drawing.Point(21, 6);
            this.gbxFrontPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxFrontPage.Name = "gbxFrontPage";
            this.gbxFrontPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxFrontPage.Size = new System.Drawing.Size(415, 295);
            this.gbxFrontPage.TabIndex = 6;
            this.gbxFrontPage.TabStop = false;
            // 
            // errorLabelNoUser
            // 
            this.errorLabelNoUser.AutoSize = true;
            this.errorLabelNoUser.Location = new System.Drawing.Point(98, 94);
            this.errorLabelNoUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabelNoUser.Name = "errorLabelNoUser";
            this.errorLabelNoUser.Size = new System.Drawing.Size(0, 16);
            this.errorLabelNoUser.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmFirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 315);
            this.Controls.Add(this.gbxFrontPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmFirstPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YourReadlist";
            this.gbxFrontPage.ResumeLayout(false);
            this.gbxFrontPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtEnterUsername;
        private System.Windows.Forms.Label lblEnterUsername;
        private System.Windows.Forms.Button btnContinueFirstPage;
        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipEntrerUsername;
        private System.Windows.Forms.ToolTip toolTipCreateUser;
        private System.Windows.Forms.ToolTip toolTipContinue;
        private System.Windows.Forms.GroupBox gbxFrontPage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label errorLabelNoUser;
    }
}

