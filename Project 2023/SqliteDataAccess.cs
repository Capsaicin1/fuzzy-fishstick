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
        public static void saveBook(Book bob_book)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Books (Title, Author, Genre, hasRead) values (@Title, @Author, @Genre, @hasRead)", bob_book);
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


        /* Selects all the readlists associated with the username that is entered. Takes one parameter (username) and
           returns the output to a list.*/
        public static List<string> retriveUserLogin(string bob_user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>($"SELECT readlist_name FROM Readlist WHERE userID IN (SELECT readlist_ID FROM Readlist_Books WHERE userID = (SELECT userID FROM User WHERE Username = '{bob_user}'))");
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

        // This function loads the connection string.
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
