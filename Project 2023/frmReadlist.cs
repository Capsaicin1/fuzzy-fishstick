using System;
using System.Collections.Generic;
using System.Linq;
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
        List<Book> books = new List<Book>();

        //ID Lists - capacity set to 1
        List<int> userIDList = new List<int>(1);
        List<int> readlistIDList = new List<int>(1);
        List<int> bookIDlist = new List<int>(1);
        List<int> book_readlistIDlist = new List<int>(1);
        

        //Variables
        int userID = 0;
        int readlistID = 0;
        int bookID = 0;
        int book_readlistID = 0;
        string username = "";
        const string none = "none";
        
        //Errors
        const string inputError = "Oops! Make sure there are no empty fields.";
        const string unknownError = "Oops! We weren't able to excecute that action for unknown reasons. \nPlease try again.";

        // Accepting data from the frmFirstPage (userReadlists, Username)
        public frmReadlist(List<string> bob_UserReadlists, string bob_Username)
        {
            //Inserts the data sent over from the frmFirstPage form and inserts it into variables.
            username = bob_Username;
            userReadlists = bob_UserReadlists;

            InitializeComponent();
        }

        // Populates the comboboxes when the form loads.
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

        /* This function sets the data source for the listbox to the books list
           and the displaymember as the Title */
        private void wireUpBookslist()
        {
            lbxBooksFromReadlist.DataSource = books;
            lbxBooksFromReadlist.DisplayMember = "Title";
        }

        /* This function sets the data source for the listbox to the books list
           and the displaymember as the Title */
        private void wireUpBooksForDeletion()
        {
            cmbBooksInReadlist.DataSource = books;
            cmbBooksInReadlist.DisplayMember="fullTitle";
        }
        

        /* When btn clicked it will retrieve the userID and use that to create a new readlist and insert it into the database.
          It then retrieves the readlist Id from the newly created readlist. Inserts the userID and readlistID into a joining table.
          This is necessary for the query that retrieves all the readlists to work.*/
        private void btnCreateNewReadlist_Click(object sender, EventArgs e)
        {
            var readlistName = txtNewReadlistName.Text;

            // Checks that 'readlistName' isn't empty before continuing.
            if (!string.IsNullOrEmpty(readlistName))
            {
                userIDList = SqliteDataAccess.getUserID(username);
                for (int i = 0; i < userIDList.Count; i++)
                {
                    userID = userIDList[i];
                }
                string errorLabel = SqliteDataAccess.createReadlist(readlistName, userID);

                // Checks if 'errorLabel' is empty or not before continuing.
                if (errorLabel == null)
                {
                    readlistIDList = SqliteDataAccess.getReadlistID(readlistName);
                    for (int i = 0; i < readlistIDList.Count; i++)
                    {
                        readlistID = readlistIDList[i];
                    }
                    SqliteDataAccess.insertJoiningTableRecord(readlistID, userID);
                    MessageBox.Show("Success! Make sure to refresh.");
                    
                    //Clearing
                    txtReadlistErrorLabel.Text = "";
                    txtNewReadlistName.Text = "";
                    userIDList.Clear();
                    readlistIDList.Clear();
                    readlistID = 0;
                    userID = 0;
                }
                // If there was an error it means that the readlist name isn't unique.
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

        /* Uses the 'readlistName, bookTitle, bookAuthor, bookGenre' entered and creates a new Book object. 
           Then adds a book and book joining table record into the database.*/
        private void btnAddBookToReadlist_Click(object sender, EventArgs e)
        {
            var readlistName = cmbAddToReadlist.SelectedItem;
            var bookTitle = txtEnterBookName.Text;
            var bookAuthor = txtEnterAuthor.Text;
            var bookGenre = cmbEnterGenre.SelectedItem;
            
            // Checks that 'readlistName, bookTitle, bookAuthor, bookGenre' isn't empty before continuing. 
            if (readlistName != null && 
                !string.IsNullOrEmpty(bookTitle) && 
                !string.IsNullOrEmpty(bookAuthor) && 
                bookGenre != null)
            {
                string updatedReadlistName = Convert.ToString(readlistName);

                if ((string)cmbAddToReadlist.SelectedItem != none &&
                    (string)cmbEnterGenre.SelectedItem != none)
                {
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
                    string error = SqliteDataAccess.saveBook(b);

                    //If there is no error - continue.
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
                    // If there is - show input error.
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
            // If those variables are empty - show 'inputError'.
            else
            {
                MessageBox.Show(inputError);
            }
        }

        /* The refresh button retrieves the user's readlists again. Overrides the current list with the new values.
           Then clears all the comboboxes where the readlists are shown and inserts the new values. This is to stop
           the values in the combobox being duplicated.*/
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Checks that the username isn't null - if for some unknown reason that the username got cleared.
            if (username != null)
            {
                //Checks that the readlists were retrieved before continuing.
                userReadlists = SqliteDataAccess.retriveUserLogin(username);
                if (userReadlists != null)
                {
                    cmbMyReadlists.Items.Clear();
                    cmbReadlistsForRemove.Items.Clear();
                    cmbAddToReadlist.Items.Clear();

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
                // If it's null - shown unknown error.
                else { MessageBox.Show(unknownError); }
            }
            // If it's null - show unknown error.
            else { MessageBox.Show(unknownError); } 
        }

        /* Uses the selected readlist and retrieves all the books in that readlist. */
        private void btnSelectReadlist_Click(object sender, EventArgs e)
        {
            var readlistName = cmbMyReadlists.SelectedItem;

            if(readlistName != null &&
                (string)cmbMyReadlists.SelectedItem != none)
            {
                string updatedReadlistName = Convert.ToString(readlistName);
                books = SqliteDataAccess.retrieveReadlistBooks(updatedReadlistName);
                wireUpBookslist();
            }
            else
            {
                MessageBox.Show(inputError);
            }
        }

        /* Retrieves Book object from selected list item and stores it into 'selectedBook'.
           Displayes the title, author and genre from that Book.*/
        private void btnSeeBookInfo_Click(object sender, EventArgs e)
        {
            Book selectedBook = (Book)lbxBooksFromReadlist.SelectedItem;

            // Checks that 'selectedBook' isn't null.
            if (selectedBook != null)
            {
                lblBookTitleInfo.Text = selectedBook.Title;
                lblBookAuthorInfo.Text = selectedBook.Author;
                lblBookGenreInfo.Text = selectedBook.Genre;
            }
            // If null - show input error.
            else
            {
                MessageBox.Show(inputError);
            }
            
        }

        // Uses the readlist name to retrieve all the books in that readlist and populates the combobox.

        private void btnSelectReadlistForBookDelete_Click(object sender, EventArgs e)
        {
            var readlistName = cmbReadlistsForRemove.SelectedItem;

            // Checks that readlistName isn't null.
            if (readlistName != null &&
                (string)cmbReadlistsForRemove.SelectedItem != none)
            {
                string updatedReadlistName = Convert.ToString(readlistName);
                books = SqliteDataAccess.retrieveBooksForDelete(updatedReadlistName);
                wireUpBooksForDeletion();
            }
            //If null - show inptError.
            else
            {
                MessageBox.Show(inputError);
            }
        }

        /* Function retrives the ReadlistID, BookID and Book_ReadlistID and stores these values in a list.
           Then removes the Book_Readlist record first and then removes the book. This is because of the 
           foreign key constraints in the Book and Book_Readlist tables.*/
        private void btnRemoveFromReadlist_Click(object sender, EventArgs e)
        {
            if ((string)cmbBooksInReadlist.SelectedText != none &&
                (string)cmbReadlistsForRemove.SelectedText != none)
            {
                //Remove joining table record first then remove book record.
                Book selectedBook = (Book)cmbBooksInReadlist.SelectedItem;
                //Book selectedBook = (Book)lbxBooksForDelete.SelectedItem;
                var readlistName = cmbReadlistsForRemove.SelectedItem;

                // Checks that the 'readlistName, selectedBook' isn't empty.
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

                    //Tries to remove - and clears the ID lists.
                    try
                    {
                        SqliteDataAccess.removeBook_ReadlistRecord(book_readlistID);
                        SqliteDataAccess.removeBook(bookID);
                        MessageBox.Show("Success!");

                        //Clearing
                        readlistIDList.Clear();
                        bookIDlist.Clear();
                        book_readlistIDlist.Clear();
                    }
                    //IF an error occurs - shows the unknownError and clears the ID lists.
                    catch
                    {
                        MessageBox.Show(unknownError);

                        //Clearing
                        readlistIDList.Clear();
                        bookIDlist.Clear();
                        book_readlistIDlist.Clear();
                    }
                }
                // If those variables are empty - shows inputError.
                else
                {
                    MessageBox.Show(inputError);
                }
            }
            else { MessageBox.Show(inputError); }
            
        }

        // Brings up the message form.
        private void btnTutorial_Click(object sender, EventArgs e)
        {
            msg m = new msg();
            m.Show();
        }

        // Formats the combobox 'cmbBooksInReadlist' to show the book title and author.
        
        private void comboboxFormat(object sender, ListControlConvertEventArgs e)
        {
            /*
            var Title = ((Book)e.ListItem).Title;
            var Author = ((Book)e.ListItem).Author;
            e.Value = Title + " , " + Author;
            */
        }
    }
}
