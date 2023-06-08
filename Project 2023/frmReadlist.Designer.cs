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
            this.txtEnterBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEnterGenre = new System.Windows.Forms.ComboBox();
            this.cmbEnterHasRead = new System.Windows.Forms.ComboBox();
            this.txtEnterAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.btnAddToReadlist.Location = new System.Drawing.Point(55, 331);
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
            // txtEnterBookName
            // 
            this.txtEnterBookName.Location = new System.Drawing.Point(75, 163);
            this.txtEnterBookName.Name = "txtEnterBookName";
            this.txtEnterBookName.Size = new System.Drawing.Size(100, 22);
            this.txtEnterBookName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // cmbEnterGenre
            // 
            this.cmbEnterGenre.FormattingEnabled = true;
            this.cmbEnterGenre.Location = new System.Drawing.Point(75, 233);
            this.cmbEnterGenre.Name = "cmbEnterGenre";
            this.cmbEnterGenre.Size = new System.Drawing.Size(121, 24);
            this.cmbEnterGenre.TabIndex = 6;
            // 
            // cmbEnterHasRead
            // 
            this.cmbEnterHasRead.FormattingEnabled = true;
            this.cmbEnterHasRead.Location = new System.Drawing.Point(75, 262);
            this.cmbEnterHasRead.Name = "cmbEnterHasRead";
            this.cmbEnterHasRead.Size = new System.Drawing.Size(121, 24);
            this.cmbEnterHasRead.TabIndex = 7;
            // 
            // txtEnterAuthor
            // 
            this.txtEnterAuthor.Location = new System.Drawing.Point(75, 200);
            this.txtEnterAuthor.Name = "txtEnterAuthor";
            this.txtEnterAuthor.Size = new System.Drawing.Size(100, 22);
            this.txtEnterAuthor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Read";
            // 
            // frmReadlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEnterAuthor);
            this.Controls.Add(this.cmbEnterHasRead);
            this.Controls.Add(this.cmbEnterGenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnterBookName);
            this.Controls.Add(this.btnRefreshReadlist);
            this.Controls.Add(this.btnAddToReadlist);
            this.Controls.Add(this.lbxToRead);
            this.Controls.Add(this.lbxHaveRead);
            this.Name = "frmReadlist";
            this.Text = "frmReadlist";
            this.Load += new System.EventHandler(this.frmReadlist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxHaveRead;
        private System.Windows.Forms.ListBox lbxToRead;
        private System.Windows.Forms.Button btnAddToReadlist;
        private System.Windows.Forms.Button btnRefreshReadlist;
        private System.Windows.Forms.TextBox txtEnterBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEnterGenre;
        private System.Windows.Forms.ComboBox cmbEnterHasRead;
        private System.Windows.Forms.TextBox txtEnterAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}