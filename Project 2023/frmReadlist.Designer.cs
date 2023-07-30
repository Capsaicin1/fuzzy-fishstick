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
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewReadlistName = new System.Windows.Forms.TextBox();
            this.btnCreateNewReadlist = new System.Windows.Forms.Button();
            this.txtReadlistErrorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMyReadlists = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbxHaveRead
            // 
            this.lbxHaveRead.FormattingEnabled = true;
            this.lbxHaveRead.ItemHeight = 16;
            this.lbxHaveRead.Location = new System.Drawing.Point(626, 60);
            this.lbxHaveRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxHaveRead.Name = "lbxHaveRead";
            this.lbxHaveRead.Size = new System.Drawing.Size(120, 84);
            this.lbxHaveRead.TabIndex = 0;
            // 
            // lbxToRead
            // 
            this.lbxToRead.FormattingEnabled = true;
            this.lbxToRead.ItemHeight = 16;
            this.lbxToRead.Location = new System.Drawing.Point(767, 60);
            this.lbxToRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxToRead.Name = "lbxToRead";
            this.lbxToRead.Size = new System.Drawing.Size(120, 84);
            this.lbxToRead.TabIndex = 1;
            // 
            // btnAddToReadlist
            // 
            this.btnAddToReadlist.Location = new System.Drawing.Point(768, 288);
            this.btnAddToReadlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToReadlist.Name = "btnAddToReadlist";
            this.btnAddToReadlist.Size = new System.Drawing.Size(120, 34);
            this.btnAddToReadlist.TabIndex = 2;
            this.btnAddToReadlist.Text = "Add To Readlist";
            this.btnAddToReadlist.UseVisualStyleBackColor = true;
            this.btnAddToReadlist.Click += new System.EventHandler(this.btnAddToReadlist_Click);
            // 
            // btnRefreshReadlist
            // 
            this.btnRefreshReadlist.Location = new System.Drawing.Point(812, 198);
            this.btnRefreshReadlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshReadlist.Name = "btnRefreshReadlist";
            this.btnRefreshReadlist.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshReadlist.TabIndex = 3;
            this.btnRefreshReadlist.Text = "Refresh";
            this.btnRefreshReadlist.UseVisualStyleBackColor = true;
            this.btnRefreshReadlist.Click += new System.EventHandler(this.btnRefreshReadlist_Click);
            // 
            // txtEnterBookName
            // 
            this.txtEnterBookName.Location = new System.Drawing.Point(767, 161);
            this.txtEnterBookName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnterBookName.Name = "txtEnterBookName";
            this.txtEnterBookName.Size = new System.Drawing.Size(100, 22);
            this.txtEnterBookName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // cmbEnterGenre
            // 
            this.cmbEnterGenre.FormattingEnabled = true;
            this.cmbEnterGenre.Location = new System.Drawing.Point(767, 232);
            this.cmbEnterGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEnterGenre.Name = "cmbEnterGenre";
            this.cmbEnterGenre.Size = new System.Drawing.Size(121, 24);
            this.cmbEnterGenre.TabIndex = 6;
            // 
            // cmbEnterHasRead
            // 
            this.cmbEnterHasRead.FormattingEnabled = true;
            this.cmbEnterHasRead.Location = new System.Drawing.Point(767, 260);
            this.cmbEnterHasRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEnterHasRead.Name = "cmbEnterHasRead";
            this.cmbEnterHasRead.Size = new System.Drawing.Size(121, 24);
            this.cmbEnterHasRead.TabIndex = 7;
            // 
            // txtEnterAuthor
            // 
            this.txtEnterAuthor.Location = new System.Drawing.Point(706, 198);
            this.txtEnterAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnterAuthor.Name = "txtEnterAuthor";
            this.txtEnterAuthor.Size = new System.Drawing.Size(100, 22);
            this.txtEnterAuthor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(720, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Read";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 54);
            this.label5.TabIndex = 12;
            this.label5.Text = "READLISTS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Create New Readlist";
            // 
            // txtNewReadlistName
            // 
            this.txtNewReadlistName.Location = new System.Drawing.Point(26, 117);
            this.txtNewReadlistName.Name = "txtNewReadlistName";
            this.txtNewReadlistName.Size = new System.Drawing.Size(184, 22);
            this.txtNewReadlistName.TabIndex = 15;
            // 
            // btnCreateNewReadlist
            // 
            this.btnCreateNewReadlist.Location = new System.Drawing.Point(26, 145);
            this.btnCreateNewReadlist.Name = "btnCreateNewReadlist";
            this.btnCreateNewReadlist.Size = new System.Drawing.Size(108, 32);
            this.btnCreateNewReadlist.TabIndex = 16;
            this.btnCreateNewReadlist.Text = "Create";
            this.btnCreateNewReadlist.UseVisualStyleBackColor = true;
            // 
            // txtReadlistErrorLabel
            // 
            this.txtReadlistErrorLabel.AutoSize = true;
            this.txtReadlistErrorLabel.Location = new System.Drawing.Point(217, 117);
            this.txtReadlistErrorLabel.Name = "txtReadlistErrorLabel";
            this.txtReadlistErrorLabel.Size = new System.Drawing.Size(43, 16);
            this.txtReadlistErrorLabel.TabIndex = 17;
            this.txtReadlistErrorLabel.Text = "-error-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "My Readlists";
            // 
            // cmbMyReadlists
            // 
            this.cmbMyReadlists.FormattingEnabled = true;
            this.cmbMyReadlists.Location = new System.Drawing.Point(31, 240);
            this.cmbMyReadlists.Name = "cmbMyReadlists";
            this.cmbMyReadlists.Size = new System.Drawing.Size(121, 24);
            this.cmbMyReadlists.TabIndex = 19;
            // 
            // frmReadlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 565);
            this.Controls.Add(this.cmbMyReadlists);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReadlistErrorLabel);
            this.Controls.Add(this.btnCreateNewReadlist);
            this.Controls.Add(this.txtNewReadlistName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReadlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewReadlistName;
        private System.Windows.Forms.Button btnCreateNewReadlist;
        private System.Windows.Forms.Label txtReadlistErrorLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMyReadlists;
    }
}