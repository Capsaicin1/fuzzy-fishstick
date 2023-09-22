namespace Project_2023
{
    partial class frmCreateProfile
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
            this.lblHeading2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreateUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.btnConfirmProfileDetails = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.toolTipEnterFirstName = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEnterYourLastName = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEnterUsername = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBackToLogin = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipConfirmDetails = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading2
            // 
            this.lblHeading2.AutoSize = true;
            this.lblHeading2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading2.Location = new System.Drawing.Point(1, 2);
            this.lblHeading2.Name = "lblHeading2";
            this.lblHeading2.Size = new System.Drawing.Size(155, 98);
            this.lblHeading2.TabIndex = 1;
            this.lblHeading2.Text = "Readlist\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create Your Profile";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(8, 100);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 3;
            this.toolTipEnterFirstName.SetToolTip(this.txtFirstName, "Enter your first name.");
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(141, 100);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(102, 20);
            this.txtLastName.TabIndex = 4;
            this.toolTipEnterYourLastName.SetToolTip(this.txtLastName, "Enter your last name.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 80);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name:";
            // 
            // txtCreateUsername
            // 
            this.txtCreateUsername.Location = new System.Drawing.Point(8, 165);
            this.txtCreateUsername.Name = "txtCreateUsername";
            this.txtCreateUsername.Size = new System.Drawing.Size(235, 20);
            this.txtCreateUsername.TabIndex = 7;
            this.toolTipEnterUsername.SetToolTip(this.txtCreateUsername, "Enter your username.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username:";
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.Location = new System.Drawing.Point(8, 219);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(84, 34);
            this.btnBackToLogin.TabIndex = 9;
            this.btnBackToLogin.Text = "Back";
            this.toolTipBackToLogin.SetToolTip(this.btnBackToLogin, "Go back to the login page.");
            this.btnBackToLogin.UseVisualStyleBackColor = true;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // btnConfirmProfileDetails
            // 
            this.btnConfirmProfileDetails.Location = new System.Drawing.Point(141, 219);
            this.btnConfirmProfileDetails.Name = "btnConfirmProfileDetails";
            this.btnConfirmProfileDetails.Size = new System.Drawing.Size(84, 34);
            this.btnConfirmProfileDetails.TabIndex = 10;
            this.btnConfirmProfileDetails.Text = "Confirm";
            this.toolTipConfirmDetails.SetToolTip(this.btnConfirmProfileDetails, "Confirm your details.");
            this.btnConfirmProfileDetails.UseVisualStyleBackColor = true;
            this.btnConfirmProfileDetails.Click += new System.EventHandler(this.btnConfirmProfileDetails_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUsernameError);
            this.groupBox1.Controls.Add(this.btnConfirmProfileDetails);
            this.groupBox1.Controls.Add(this.btnBackToLogin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCreateUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblHeading2);
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 269);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.AutoSize = true;
            this.lblUsernameError.Location = new System.Drawing.Point(74, 145);
            this.lblUsernameError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(0, 15);
            this.lblUsernameError.TabIndex = 11;
            // 
            // frmCreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 287);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCreateProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateProfile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeading2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreateUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.Button btnConfirmProfileDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTipEnterFirstName;
        private System.Windows.Forms.ToolTip toolTipEnterYourLastName;
        private System.Windows.Forms.ToolTip toolTipEnterUsername;
        private System.Windows.Forms.ToolTip toolTipBackToLogin;
        private System.Windows.Forms.ToolTip toolTipConfirmDetails;
        private System.Windows.Forms.Label lblUsernameError;
    }
}