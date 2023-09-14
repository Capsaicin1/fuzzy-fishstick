using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;
using System.Data;
using System.Configuration;
using System.Web;

namespace Project_2023
{
    
    // A seperate class to access my database. I will write all of my SQL queries in this class.
    public class SqliteDataAccess
    {
        /*Function to load the books in the books table from my database int the readlistbox.
         It does this by loading up a new connection to the database and running a query */
         public static List<Book> LoadBooks()
         {
            using (IDbConnection cnn  = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Book>("select Title from Books", new DynamicParameters());
                return output.ToList();
            }
         }

        /*This function inserts the book data the user enters into the books table in my database
         by executing sql.*/
        public static string saveBook(Book bob_book)
        {           
            while (true)
            {
                try
                {
                    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                    {
                        cnn.Execute("insert into Books (Title, Author, Genre, readlist_ID) values (@Title, @Author, @Genre, @readlistID)", bob_book);
                    }
                    return null;
                }
                catch
                {
                    return "Empty field are not allowed.";
                }
            }
            
        }

/* ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- */

        /*Inserts the user's username, first name and last name into the user table in my database.
         Also checks if the username the user is attempting to create already exists. If the username 
         already exists, the unique constraint in my table fails then it will return the error message. */
        public static string addUser(UserModel bob_user)
        {
            while (true)
            {
                try
                {
                    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                    {
                        cnn.Execute("INSERT INTO User (Username, FirstName, LastName) VALUES (@Username, @FirstName, @LastName)", bob_user);
                    }

                    return null;
                }
                catch
                {
                    return "Your username has to be unique.";
                }

            }
        }

        public static List<int> getUserID(string bob_user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<int>($"SELECT userID FROM User WHERE Username = '{bob_user}'");
                return output.ToList();
            }
        }

        public static List<int> getReadlistID(string bob_readlistName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<int>($"SELECT readlist_ID FROM Readlist WHERE readlist_Name = '{bob_readlistName}'");
                return output.ToList();
            }
        }

        

        public static List<int> getBookID(string bob_bookName, string bob_bookAuthor, string bob_bookGenre, int bob_readlistID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<int>($"SELECT bookID FROM Books WHERE title = '{bob_bookName}' AND Author = '{bob_bookAuthor}' AND Genre = '{bob_bookGenre}' AND readlist_ID = '{bob_readlistID}'");
                return output.ToList();
            }
        }

        public static List<int> getBook_ReadlistID(int bob_bookID, int bob_readlistID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<int>($"SELECT book_readlist_ID FROM book_readlist WHERE readlist_ID = '{bob_readlistID}' AND bookID = '{bob_bookID}'");
                return output.ToList();
            }
        }
        public static string createReadlist(string bob_readlistName, int bob_userID)
        {   
            while (true)
            {
                try
                {
                    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                    {
                        cnn.Execute($"INSERT INTO Readlist (readlist_Name, userID) VALUES ('{bob_readlistName}', '{bob_userID}')");
                    }
                    return null;
                }
                catch 
                {
                    return "Readlist name has to be unique. Try another name.";
                }
            }
        }


        public static void insertJoiningTableRecord(int bob_readlistID, int bob_userID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO ReadList_Books (readlist_ID, userID) VALUES ('{bob_readlistID}', '{bob_userID}')");
            }
        }

        public static void insertBook_JT_Record(int bob_readlistID, int bob_bookID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO book_readlist (readlist_ID, bookID) VALUES ('{bob_readlistID}', '{bob_bookID}')");
            }
        }

        public static void removeBook_ReadlistRecord(int bob_BookreadlistID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM book_readlist WHERE book_readlist_ID = '{bob_BookreadlistID}'");
            }
        }
            
        public static void removeBook(int bob_bookID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM Books WHERE bookID = '{bob_bookID}'");
            }
        }

        /* Selects all the readlists associated with the username that is entered. Takes one parameter (username) and
           returns the output to a list.*/
        public static List<string> retriveUserLogin(string bob_user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>($"SELECT readlist_name FROM Readlist WHERE readlist_ID IN (SELECT readlist_ID FROM Readlist_Books WHERE userID = (SELECT userID FROM User WHERE Username = '{bob_user}'))");
                return output.ToList();
            }
        }

        public static List<Book> retrieveReadlistBooks(string bob_readlistName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Book>($"SELECT Title, Author, Genre FROM Books WHERE readlist_ID IN (SELECT readlist_ID FROM book_readlist WHERE readlist_ID = (SELECT readlist_ID FROM Readlist WHERE readlist_Name = '{bob_readlistName}'))");
                return output.ToList();
            }
        }

        public static List<Book> retrieveBooksForDelete(string bob_readlistName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Book>($"SELECT Title, Author, Genre FROM Books WHERE readlist_ID IN (SELECT readlist_ID FROM book_readlist WHERE readlist_ID = (SELECT readlist_ID FROM Readlist WHERE readlist_Name = '{bob_readlistName}'))");
                return output.ToList();
            }
        }

        public static List<Book> retrieveBookInfo(int bob_bookID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Book>($"SELECT Title, Author, Genre FROM Books WHERE bookID = '{bob_bookID}'");
                return output.ToList();
            }
        }

        //Checks if a list is empty. Function takes 1 parameter (A list) and can return either 'true' or 'false'.
        public static bool IsEmpty<T>(List<T> list)
        {
            if (list == null || list.Count == 0)
            {
                return true;
            }
            return !list.Any();
        }

        /* Checks if a user exists by executing a query that, if the record exists, it will return 1.
           Takes one parameter (username) and returns either 1 or 0 to a list. (My SELECT statements only work when I 
            return to a list) */
        public static List<int> userExists(string bob_user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<int>($"SELECT 1 FROM User WHERE Username = '{bob_user}'");
                return output.ToList();
            }
        }

        public static List<int> bookExists(int bob_bookID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<int>($"SELECT 1 FROM Books WHERE bookID = '{bob_bookID}' AND Title = ''");
                return output.ToList();
            }
        }

        // This function loads the connection string.
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
