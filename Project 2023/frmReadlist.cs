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

        //Lists
        List<string> userReadlists = new List<string>();
        List<int> bookExistsList = new List<int>();
        List<int> userIDList = new List<int>();
        List<int> readlistIDList = new List<int>();
        List<int> bookIDlist = new List<int>();
        List<int> book_readlistIDlist = new List<int>();
        List<Book> books = new List<Book>();

        //Variables
        int userID = 0;
        int readlistID = 0;
        int bookID = 0;
        int book_readlistID = 0;
        string username = "";
        const string inputError = "Oops! Make sure there are no empty fields.";
        const string unknownError = "Oops! We weren't able to excecute that action for unknown reasons. \nPlease try again.";

        // Creating a list where my data will load into.

        public frmReadlist(List<string> bob_UserReadlists, string bob_Username)
        {
            //Inserts the data sent over from the frmFirstPage form and inserts it into variables.
            username = bob_Username;
            userReadlists = bob_UserReadlists;

            InitializeComponent();
        }

        private void frmReadlist_Load(object sender, EventArgs e)
        {
            //For loop loops through the bookGenre array and populates the EnterGenre combobox with those values.
            for (int i = 0; i < bookGenre.Length; i++)
            {
                cmbEnterGenre.Items.Add(bookGenre[i]);
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


        // The refresh button calls the loadReadList again to load any new entries into the db into the list.
        private void btnRefreshReadlist_Click(object sender, EventArgs e)
        {
            
        }

        /* ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */

        /* This function sets the data source for the listbox to the books list
           and the displaymember as the Title */
        private void wireUpBookslist()
        {
            lbxBooksFromReadlist.DataSource = books;
            lbxBooksFromReadlist.DisplayMember = "Title";
        }

        private void wireUpBooksForDeletion()
        {
            cmbBooksInReadlist.DataSource = books;
            cmbBooksInReadlist.DisplayMember="Title";
        }

        /* When btn clicked it will retrieve the userID and use that to create a new readlist and insert it into the database.
          It then retrieves the readlist Id from the newly created readlist. Inserts the userID and readlistID into a joining table.
          This is necessary for the query that retrieves all the readlists to work.*/
        private void btnCreateNewReadlist_Click(object sender, EventArgs e)
        {
            string errorLabel = null;
            var readlistName = txtNewReadlistName.Text;

            if (!string.IsNullOrEmpty(readlistName))
            {
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
                    MessageBox.Show("Success!");
                    
                    //Clearing
                    txtReadlistErrorLabel.Text = "";
                    txtNewReadlistName.Text = "";
                    userIDList.Clear();
                    readlistIDList.Clear();
                    readlistID = 0;
                    userID = 0;
                }
                else
                {
                    MessageBox.Show("Readlist name has to be unique. Try another name.");

                    //Clearing
                    txtNewReadlistName.Text = "";
                    userIDList.Clear();
                    readlistIDList.Clear();
                    readlistID = 0;
                    userID = 0;
                }
            }
            else
            {
                MessageBox.Show(inputError);
            }

            
        }

        private void btnAddBookToReadlist_Click(object sender, EventArgs e)
        {
            string error = null;
            var readlistName = cmbAddToReadlist.SelectedItem;
            var bookTitle = txtEnterBookName.Text;
            var bookAuthor = txtEnterAuthor.Text;
            var bookGenre = cmbEnterGenre.SelectedItem;

            if (readlistName != null && 
                !string.IsNullOrEmpty(bookTitle) && 
                !string.IsNullOrEmpty(bookAuthor) && 
                bookGenre != null)
            {
                string updatedReadlistName = Convert.ToString(readlistName);

                readlistIDList = SqliteDataAccess.getReadlistID(updatedReadlistName);
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
                    MessageBox.Show(inputError);
                    bookIDlist.Clear();
                    readlistIDList.Clear();
                }
                txtEnterBookName.Text = "";
                txtEnterAuthor.Text = "";
                cmbEnterGenre.Text = "";
                cmbAddToReadlist.SelectedItem = null;
            }
            else
            {
                MessageBox.Show(inputError);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        /* Uses the selected readlist and retrieves all the books in that readlist. */
        private void btnSelectReadlist_Click(object sender, EventArgs e)
        {
            string readlistName = cmbMyReadlists.SelectedItem.ToString();

            if(!string.IsNullOrEmpty(readlistName))
            {
                books = SqliteDataAccess.retrieveReadlistBooks(readlistName);
                wireUpBookslist();
            }
            else
            {
                MessageBox.Show(inputError);
            }
        }

        private void btnSeeBookInfo_Click(object sender, EventArgs e)
        {
            Book selectedBook = (Book)lbxBooksFromReadlist.SelectedItem;

            if (selectedBook != null)
            {
                lblBookTitleInfo.Text = selectedBook.Title;
                lblBookAuthorInfo.Text = selectedBook.Author;
                lblBookGenreInfo.Text = selectedBook.Genre;
            }
            else
            {
                MessageBox.Show(inputError);
            }
            
        }

        private void btnSelectReadlistForBookDelete_Click(object sender, EventArgs e)
        {
            var readlistName = cmbReadlistsForRemove.SelectedItem;

            if (readlistName != null)
            {
                string updatedReadlistName = Convert.ToString(readlistName);
                books = SqliteDataAccess.retrieveBooksForDelete(updatedReadlistName);
                wireUpBooksForDeletion();
            }
            else
            {
                MessageBox.Show(inputError);
            }
        }

        private void btnRemoveFromReadlist_Click(object sender, EventArgs e)
        {
            //Remove joining table record first then remove book record.
            Book selectedBook = (Book)cmbBooksInReadlist.SelectedItem;

            //Book selectedBook = (Book)lbxBooksForDelete.SelectedItem;
            var readlistName = cmbReadlistsForRemove.SelectedItem;

            if (readlistName != null && selectedBook != null)
            {
                string updatedReadlistName = Convert.ToString(readlistName);

                readlistIDList = SqliteDataAccess.getReadlistID(updatedReadlistName);
                for (int i = 0; i < readlistIDList.Count; i++)
                {
                    readlistID = readlistIDList[i];
                }


                bookIDlist = SqliteDataAccess.getBookID(selectedBook.Title, selectedBook.Author, selectedBook.Genre, readlistID);
                for (int i = 0; i < bookIDlist.Count; i++)
                {
                    bookID = bookIDlist[i];
                }

                book_readlistIDlist = SqliteDataAccess.getBook_ReadlistID(bookID, readlistID);
                for (int i = 0; i < book_readlistIDlist.Count; i++)
                {
                    book_readlistID = book_readlistIDlist[i];
                }

                try
                {
                    SqliteDataAccess.removeBook_ReadlistRecord(book_readlistID);
                    SqliteDataAccess.removeBook(bookID);
                    MessageBox.Show("Success!");

                    //Clearing
                    readlistIDList.Clear();
                    bookIDlist.Clear();
                    book_readlistIDlist.Clear();
                    cmbBooksInReadlist.SelectedItem = null;
                }
                catch
                {
                    MessageBox.Show(unknownError);

                    //Clearing
                    readlistIDList.Clear();
                    bookIDlist.Clear();
                    book_readlistIDlist.Clear();
                }
            }
            else
            {
                MessageBox.Show(inputError);
            }
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            msg m = new msg();
            m.Show();
        }

        private void comboboxFormat(object sender, ListControlConvertEventArgs e)
        {
            string Title = ((Book)e.ListItem).Title;
            string Author = ((Book)e.ListItem).Author;
            e.Value = Title + ", " + Author;
        }
    }
}
