namespace Project_2023
{
    partial class frmReadlist
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
            this.lbxHaveRead = new System.Windows.Forms.ListBox();
            this.lbxToRead = new System.Windows.Forms.ListBox();
            this.btnAddToReadlist = new System.Windows.Forms.Button();
            this.btnRefreshReadlist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxHaveRead
            // 
            this.lbxHaveRead.FormattingEnabled = true;
            this.lbxHaveRead.ItemHeight = 16;
            this.lbxHaveRead.Location = new System.Drawing.Point(55, 60);
            this.lbxHaveRead.Name = "lbxHaveRead";
            this.lbxHaveRead.Size = new System.Drawing.Size(120, 84);
            this.lbxHaveRead.TabIndex = 0;
            // 
            // lbxToRead
            // 
            this.lbxToRead.FormattingEnabled = true;
            this.lbxToRead.ItemHeight = 16;
            this.lbxToRead.Location = new System.Drawing.Point(220, 60);
            this.lbxToRead.Name = "lbxToRead";
            this.lbxToRead.Size = new System.Drawing.Size(120, 84);
            this.lbxToRead.TabIndex = 1;
            // 
            // btnAddToReadlist
            // 
            this.btnAddToReadlist.Location = new System.Drawing.Point(55, 200);
            this.btnAddToReadlist.Name = "btnAddToReadlist";
            this.btnAddToReadlist.Size = new System.Drawing.Size(120, 35);
            this.btnAddToReadlist.TabIndex = 2;
            this.btnAddToReadlist.Text = "Add To Readlist";
            this.btnAddToReadlist.UseVisualStyleBackColor = true;
            this.btnAddToReadlist.Click += new System.EventHandler(this.btnAddToReadlist_Click);
            // 
            // btnRefreshReadlist
            // 
            this.btnRefreshReadlist.Location = new System.Drawing.Point(220, 200);
            this.btnRefreshReadlist.Name = "btnRefreshReadlist";
            this.btnRefreshReadlist.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshReadlist.TabIndex = 3;
            this.btnRefreshReadlist.Text = "Refresh";
            this.btnRefreshReadlist.UseVisualStyleBackColor = true;
            this.btnRefreshReadlist.Click += new System.EventHandler(this.btnRefreshReadlist_Click);
            // 
            // frmReadlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefreshReadlist);
            this.Controls.Add(this.btnAddToReadlist);
            this.Controls.Add(this.lbxToRead);
            this.Controls.Add(this.lbxHaveRead);
            this.Name = "frmReadlist";
            this.Text = "frmReadlist";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxHaveRead;
        private System.Windows.Forms.ListBox lbxToRead;
        private System.Windows.Forms.Button btnAddToReadlist;
        private System.Windows.Forms.Button btnRefreshReadlist;
    }
}