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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSelectReadlist = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbReadlistsForRemove = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbBooksInReadlist = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRemoveFromReadlist = new System.Windows.Forms.Button();
            this.lbxBooksFromReadlist = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbAddToReadlist = new System.Windows.Forms.ComboBox();
            this.btnAddBookToReadlist = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSeeBookInfo = new System.Windows.Forms.Button();
            this.lblBookTitleInfo = new System.Windows.Forms.Label();
            this.lblBookAuthorInfo = new System.Windows.Forms.Label();
            this.lblBookGenreInfo = new System.Windows.Forms.Label();
            this.lblCreateBookError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxHaveRead
            // 
            this.lbxHaveRead.FormattingEnabled = true;
            this.lbxHaveRead.Location = new System.Drawing.Point(746, 49);
            this.lbxHaveRead.Margin = new System.Windows.Forms.Padding(2);
            this.lbxHaveRead.Name = "lbxHaveRead";
            this.lbxHaveRead.Size = new System.Drawing.Size(91, 69);
            this.lbxHaveRead.TabIndex = 0;
            // 
            // lbxToRead
            // 
            this.lbxToRead.FormattingEnabled = true;
            this.lbxToRead.Location = new System.Drawing.Point(851, 49);
            this.lbxToRead.Margin = new System.Windows.Forms.Padding(2);
            this.lbxToRead.Name = "lbxToRead";
            this.lbxToRead.Size = new System.Drawing.Size(91, 69);
            this.lbxToRead.TabIndex = 1;
            // 
            // btnRefreshReadlist
            // 
            this.btnRefreshReadlist.Location = new System.Drawing.Point(885, 161);
            this.btnRefreshReadlist.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshReadlist.Name = "btnRefreshReadlist";
            this.btnRefreshReadlist.Size = new System.Drawing.Size(56, 19);
            this.btnRefreshReadlist.TabIndex = 3;
            this.btnRefreshReadlist.Text = "Refresh";
            this.btnRefreshReadlist.UseVisualStyleBackColor = true;
            this.btnRefreshReadlist.Click += new System.EventHandler(this.btnRefreshReadlist_Click);
            // 
            // txtEnterBookName
            // 
            this.txtEnterBookName.Location = new System.Drawing.Point(58, 186);
            this.txtEnterBookName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnterBookName.Name = "txtEnterBookName";
            this.txtEnterBookName.Size = new System.Drawing.Size(142, 20);
            this.txtEnterBookName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title:";
            // 
            // cmbEnterGenre
            // 
            this.cmbEnterGenre.FormattingEnabled = true;
            this.cmbEnterGenre.Location = new System.Drawing.Point(57, 237);
            this.cmbEnterGenre.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEnterGenre.Name = "cmbEnterGenre";
            this.cmbEnterGenre.Size = new System.Drawing.Size(143, 21);
            this.cmbEnterGenre.TabIndex = 6;
            // 
            // cmbEnterHasRead
            // 
            this.cmbEnterHasRead.FormattingEnabled = true;
            this.cmbEnterHasRead.Location = new System.Drawing.Point(851, 211);
            this.cmbEnterHasRead.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEnterHasRead.Name = "cmbEnterHasRead";
            this.cmbEnterHasRead.Size = new System.Drawing.Size(92, 21);
            this.cmbEnterHasRead.TabIndex = 7;
            // 
            // txtEnterAuthor
            // 
            this.txtEnterAuthor.Location = new System.Drawing.Point(58, 211);
            this.txtEnterAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnterAuthor.Name = "txtEnterAuthor";
            this.txtEnterAuthor.Size = new System.Drawing.Size(142, 20);
            this.txtEnterAuthor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(816, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Read:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 44);
            this.label5.TabIndex = 12;
            this.label5.Text = "READLISTS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Create New Readlist";
            // 
            // txtNewReadlistName
            // 
            this.txtNewReadlistName.Location = new System.Drawing.Point(16, 95);
            this.txtNewReadlistName.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewReadlistName.Name = "txtNewReadlistName";
            this.txtNewReadlistName.Size = new System.Drawing.Size(184, 20);
            this.txtNewReadlistName.TabIndex = 15;
            // 
            // btnCreateNewReadlist
            // 
            this.btnCreateNewReadlist.Location = new System.Drawing.Point(16, 119);
            this.btnCreateNewReadlist.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateNewReadlist.Name = "btnCreateNewReadlist";
            this.btnCreateNewReadlist.Size = new System.Drawing.Size(81, 26);
            this.btnCreateNewReadlist.TabIndex = 16;
            this.btnCreateNewReadlist.Text = "Create";
            this.btnCreateNewReadlist.UseVisualStyleBackColor = true;
            this.btnCreateNewReadlist.Click += new System.EventHandler(this.btnCreateNewReadlist_Click);
            // 
            // txtReadlistErrorLabel
            // 
            this.txtReadlistErrorLabel.AutoSize = true;
            this.txtReadlistErrorLabel.Location = new System.Drawing.Point(163, 95);
            this.txtReadlistErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtReadlistErrorLabel.Name = "txtReadlistErrorLabel";
            this.txtReadlistErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.txtReadlistErrorLabel.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "View Books From";
            // 
            // cmbMyReadlists
            // 
            this.cmbMyReadlists.FormattingEnabled = true;
            this.cmbMyReadlists.Location = new System.Drawing.Point(286, 95);
            this.cmbMyReadlists.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMyReadlists.Name = "cmbMyReadlists";
            this.cmbMyReadlists.Size = new System.Drawing.Size(160, 21);
            this.cmbMyReadlists.TabIndex = 19;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(119, 120);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 25);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSelectReadlist
            // 
            this.btnSelectReadlist.Location = new System.Drawing.Point(286, 120);
            this.btnSelectReadlist.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectReadlist.Name = "btnSelectReadlist";
            this.btnSelectReadlist.Size = new System.Drawing.Size(160, 25);
            this.btnSelectReadlist.TabIndex = 22;
            this.btnSelectReadlist.Text = "Select ";
            this.btnSelectReadlist.UseVisualStyleBackColor = true;
            this.btnSelectReadlist.Click += new System.EventHandler(this.btnSelectReadlist_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 155);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Add Books";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 356);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Remove Books";
            // 
            // cmbReadlistsForRemove
            // 
            this.cmbReadlistsForRemove.FormattingEnabled = true;
            this.cmbReadlistsForRemove.Location = new System.Drawing.Point(77, 383);
            this.cmbReadlistsForRemove.Margin = new System.Windows.Forms.Padding(2);
            this.cmbReadlistsForRemove.Name = "cmbReadlistsForRemove";
            this.cmbReadlistsForRemove.Size = new System.Drawing.Size(123, 21);
            this.cmbReadlistsForRemove.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 386);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Readlist:";
            // 
            // cmbBooksInReadlist
            // 
            this.cmbBooksInReadlist.FormattingEnabled = true;
            this.cmbBooksInReadlist.Location = new System.Drawing.Point(77, 409);
            this.cmbBooksInReadlist.Name = "cmbBooksInReadlist";
            this.cmbBooksInReadlist.Size = new System.Drawing.Size(123, 21);
            this.cmbBooksInReadlist.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 409);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Book:";
            // 
            // btnRemoveFromReadlist
            // 
            this.btnRemoveFromReadlist.Location = new System.Drawing.Point(22, 436);
            this.btnRemoveFromReadlist.Name = "btnRemoveFromReadlist";
            this.btnRemoveFromReadlist.Size = new System.Drawing.Size(178, 28);
            this.btnRemoveFromReadlist.TabIndex = 29;
            this.btnRemoveFromReadlist.Text = "Remove";
            this.btnRemoveFromReadlist.UseVisualStyleBackColor = true;
            this.btnRemoveFromReadlist.Click += new System.EventHandler(this.btnRemoveFromReadlist_Click);
            // 
            // lbxBooksFromReadlist
            // 
            this.lbxBooksFromReadlist.FormattingEnabled = true;
            this.lbxBooksFromReadlist.Location = new System.Drawing.Point(286, 155);
            this.lbxBooksFromReadlist.Name = "lbxBooksFromReadlist";
            this.lbxBooksFromReadlist.Size = new System.Drawing.Size(159, 121);
            this.lbxBooksFromReadlist.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 265);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Readlist:";
            // 
            // cmbAddToReadlist
            // 
            this.cmbAddToReadlist.FormattingEnabled = true;
            this.cmbAddToReadlist.Items.AddRange(new object[] {
            "None"});
            this.cmbAddToReadlist.Location = new System.Drawing.Point(78, 262);
            this.cmbAddToReadlist.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddToReadlist.Name = "cmbAddToReadlist";
            this.cmbAddToReadlist.Size = new System.Drawing.Size(123, 21);
            this.cmbAddToReadlist.TabIndex = 32;
            // 
            // btnAddBookToReadlist
            // 
            this.btnAddBookToReadlist.Location = new System.Drawing.Point(19, 287);
            this.btnAddBookToReadlist.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddBookToReadlist.Name = "btnAddBookToReadlist";
            this.btnAddBookToReadlist.Size = new System.Drawing.Size(182, 28);
            this.btnAddBookToReadlist.TabIndex = 33;
            this.btnAddBookToReadlist.Text = "Add To Readlist";
            this.btnAddBookToReadlist.UseVisualStyleBackColor = true;
            this.btnAddBookToReadlist.Click += new System.EventHandler(this.btnAddBookToReadlist_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(281, 356);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Book Info";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(282, 386);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Title:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(282, 409);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Author:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(282, 434);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Genre:";
            // 
            // btnSeeBookInfo
            // 
            this.btnSeeBookInfo.Location = new System.Drawing.Point(285, 287);
            this.btnSeeBookInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeeBookInfo.Name = "btnSeeBookInfo";
            this.btnSeeBookInfo.Size = new System.Drawing.Size(161, 28);
            this.btnSeeBookInfo.TabIndex = 38;
            this.btnSeeBookInfo.Text = "See Info";
            this.btnSeeBookInfo.UseVisualStyleBackColor = true;
            this.btnSeeBookInfo.Click += new System.EventHandler(this.btnSeeBookInfo_Click);
            // 
            // lblBookTitleInfo
            // 
            this.lblBookTitleInfo.AutoSize = true;
            this.lblBookTitleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitleInfo.Location = new System.Drawing.Point(335, 386);
            this.lblBookTitleInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookTitleInfo.Name = "lblBookTitleInfo";
            this.lblBookTitleInfo.Size = new System.Drawing.Size(24, 13);
            this.lblBookTitleInfo.TabIndex = 39;
            this.lblBookTitleInfo.Text = "test";
            // 
            // lblBookAuthorInfo
            // 
            this.lblBookAuthorInfo.AutoSize = true;
            this.lblBookAuthorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthorInfo.Location = new System.Drawing.Point(335, 409);
            this.lblBookAuthorInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookAuthorInfo.Name = "lblBookAuthorInfo";
            this.lblBookAuthorInfo.Size = new System.Drawing.Size(24, 13);
            this.lblBookAuthorInfo.TabIndex = 40;
            this.lblBookAuthorInfo.Text = "test";
            // 
            // lblBookGenreInfo
            // 
            this.lblBookGenreInfo.AutoSize = true;
            this.lblBookGenreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookGenreInfo.Location = new System.Drawing.Point(335, 434);
            this.lblBookGenreInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookGenreInfo.Name = "lblBookGenreInfo";
            this.lblBookGenreInfo.Size = new System.Drawing.Size(24, 13);
            this.lblBookGenreInfo.TabIndex = 41;
            this.lblBookGenreInfo.Text = "test";
            // 
            // lblCreateBookError
            // 
            this.lblCreateBookError.AutoSize = true;
            this.lblCreateBookError.Location = new System.Drawing.Point(108, 160);
            this.lblCreateBookError.Name = "lblCreateBookError";
            this.lblCreateBookError.Size = new System.Drawing.Size(41, 13);
            this.lblCreateBookError.TabIndex = 42;
            this.lblCreateBookError.Text = "label17";
            // 
            // frmReadlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 596);
            this.Controls.Add(this.lblCreateBookError);
            this.Controls.Add(this.lblBookGenreInfo);
            this.Controls.Add(this.lblBookAuthorInfo);
            this.Controls.Add(this.lblBookTitleInfo);
            this.Controls.Add(this.btnSeeBookInfo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAddBookToReadlist);
            this.Controls.Add(this.cmbAddToReadlist);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbxBooksFromReadlist);
            this.Controls.Add(this.btnRemoveFromReadlist);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbBooksInReadlist);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbReadlistsForRemove);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSelectReadlist);
            this.Controls.Add(this.btnRefresh);
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
            this.Controls.Add(this.lbxToRead);
            this.Controls.Add(this.lbxHaveRead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSelectReadlist;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbReadlistsForRemove;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbBooksInReadlist;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRemoveFromReadlist;
        private System.Windows.Forms.ListBox lbxBooksFromReadlist;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbAddToReadlist;
        private System.Windows.Forms.Button btnAddBookToReadlist;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSeeBookInfo;
        private System.Windows.Forms.Label lblBookTitleInfo;
        private System.Windows.Forms.Label lblBookAuthorInfo;
        private System.Windows.Forms.Label lblBookGenreInfo;
        private System.Windows.Forms.Label lblCreateBookError;
    }
}