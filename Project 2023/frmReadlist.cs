using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_2023
{
    /*
       Label - lbl
       TextBox - txt
       Button - btn
       ComboBox - cmb
       GroupBox - gbx
       RadioButton - rbtn
       CheckBox - cbx
       Form - frm
       ListBox - lbx
    */
    public partial class frmReadlist : Form
    {
        //Arrays
        string[] bookGenre = { "Fiction", "Non-Fiction", "Fantasy", "Urban-Fantasy", "Crime", "Romance", "Action", "Biography" };
        string[] hasRead = { "1", "0" };

        //Lists
        List<string> userReadlists = new List<string>();
        List<int> bookExistsList = new List<int>();
        List<int> userIDList = new List<int>();
        List<int> readlistIDList = new List<int>();
        List<int> bookIDlist = new List<int>();
        List<int> IDlist = new List<int>();
        List<Book> books = new List<Book>();
        List<string> bookInfo = new List<string>();

        //Variables
        int userID = 0;
        int readlistID = 0;
        int bookID = 0;
        string username = "";

        // Creating a list where my data will load into.

        public frmReadlist(List<string> bob_UserReadlists, string bob_Username)
        {
            //Inserts the data sent over from the frmFirstPage form and inserts it into variables.
            username = bob_Username;
            userReadlists = bob_UserReadlists;

            InitializeComponent();
            loadReadlist();
        }

        private void frmReadlist_Load(object sender, EventArgs e)
        {
            //For loop loops through the bookGenre array and populates the EnterGenre combobox with those values.
            for (int i = 0; i < bookGenre.Length; i++)
            {
                cmbEnterGenre.Items.Add(bookGenre[i]);
            }

            //For loop loops through the hasRead array and populates the EnterHasRead combobox with those values.
            for (int i = 0; i < hasRead.Length; i++)
            {
                cmbEnterHasRead.Items.Add(hasRead[i]);
            }

            //For Loop for populating the MyReadlists combobox with all the user's readlists.
            for (int i = 0; i < userReadlists.Count; i++)
            {
                cmbMyReadlists.Items.Add(userReadlists[i]);
            }

            //For Loop for populating the ReadListForRemove combobox with all the user's readlists.
            for (int i = 0; i < userReadlists.Count; i++)
            {
                cmbReadlistsForRemove.Items.Add(userReadlists[i]);
            }

            //For Loop for populating the AddToReadlist combobox with all the user's readlists.
            for (int i = 0; i < userReadlists.Count; i++)
            {
                cmbAddToReadlist.Items.Add(userReadlists[i]);
            }
        }


        /* ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- */

        // This function loads the data into the list and wires up the list.
        private void loadReadlist()
        {

        }



        // The refresh button calls the loadReadList again to load any new entries into the db into the list.
        private void btnRefreshReadlist_Click(object sender, EventArgs e)
        {
            loadReadlist();
        }

        /* ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */

        /* This function sets the data source for the listbox to the books list
           and the displaymember as the Title */
        private void wireUpBookslist()
        {
            lbxBooksFromReadlist.DataSource = books;
            lbxBooksFromReadlist.DisplayMember = "Title";
        }

        /* When btn clicked it will retrieve the userID and use that to create a new readlist and insert it into the database.
          It then retrieves the readlist Id from the newly created readlist. Inserts the userID and readlistID into a joining table.
          This is necessary for the query that retrieves all the readlists to work.*/
        private void btnCreateNewReadlist_Click(object sender, EventArgs e)
        {
            string errorLabel = null;
            string readlistName = txtNewReadlistName.Text;

            userIDList = SqliteDataAccess.getUserID(username);
            for (int i = 0; i < userIDList.Count; i++)
            {
                userID = userIDList[i];
            }
            errorLabel = SqliteDataAccess.createReadlist(readlistName, userID);

            if (errorLabel == null)
            {
                readlistIDList = SqliteDataAccess.getReadlistID(readlistName);
                for (int i = 0; i < readlistIDList.Count; i++)
                {
                    readlistID = readlistIDList[i];
                }
                SqliteDataAccess.insertJoiningTableRecord(readlistID, userID);
                txtReadlistErrorLabel.Text = "";
                txtNewReadlistName.Text = "";
                userIDList.Clear();
                readlistIDList.Clear();
            }
            else
            {
                txtReadlistErrorLabel.Text = errorLabel;
                txtNewReadlistName.Text = "";
                userIDList.Clear();
                readlistIDList.Clear();
            }
        }

        private void btnAddBookToReadlist_Click(object sender, EventArgs e)
        {
            string error = null;
            string readlistName = cmbAddToReadlist.SelectedItem.ToString();

            readlistIDList = SqliteDataAccess.getReadlistID(readlistName);
            for (int i = 0; i < readlistIDList.Count; i++)
            {
                readlistID = readlistIDList[i];
            }

            Book b = new Book
            {
                Title = txtEnterBookName.Text,
                Author = txtEnterAuthor.Text,
                Genre = cmbEnterGenre.Text,
                readlistID = readlistID
            };
            error = SqliteDataAccess.saveBook(b);

            if (error == null)
            {
                bookIDlist = SqliteDataAccess.getBookID(b.Title, b.Author, b.Genre, readlistID);
                for (int i = 0; i < bookIDlist.Count; i++)
                {
                    bookID = bookIDlist[i];
                }
                SqliteDataAccess.insertBook_JT_Record(readlistID, bookID);
                bookIDlist.Clear();
                readlistIDList.Clear();
            }
            else
            {
                lblCreateBookError.Text = error;
                bookIDlist.Clear ();
                readlistIDList.Clear();
            }
            txtEnterBookName.Text = "";
            txtEnterAuthor.Text = "";
            cmbEnterGenre.Text = "";
            cmbEnterHasRead.Text = "";

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        /* Uses the selected readlist and retrieves all the books in that readlist. */
        private void btnSelectReadlist_Click(object sender, EventArgs e)
        {
            string readlistName = cmbMyReadlists.SelectedItem.ToString();
            books = SqliteDataAccess.retrieveReadlistBooks(readlistName);
            wireUpBookslist();
        }

        private void btnSeeBookInfo_Click(object sender, EventArgs e)
        {
            Book b = new Book
            {
                Title = ""
            };
            IDlist = null;
        }

        private void btnRemoveFromReadlist_Click(object sender, EventArgs e)
        {

        }
    }
}
