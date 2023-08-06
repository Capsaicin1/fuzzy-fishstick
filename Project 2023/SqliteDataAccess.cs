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
        public static void saveBook(Book book)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Books (Title, Author, Genre, hasRead) values (@Title, @Author, @Genre, @hasRead)", book);
            }
        }

/* ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- */

        /*Inserts the user's username, first name and last name into the user table in my database.
         Also checks if the username the user is attempting to create already exists. If the username 
         already exists, the unique constraint in my table fails then it will return the error message. */
        public static string addUser(UserModel user)
        {
            while (true)
            {
                try
                {
                    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                    {
                        cnn.Execute("INSERT INTO User (Username, FirstName, LastName) VALUES (@Username, @FirstName, @LastName)", user);
                    }

                    return null;
                }
                catch
                {
                    return "Your username has to be unique. Try another name.";
                }

            }
        }

        public static string createReadlist(string readlistName, string user)
        {            
            while (true)
            {
                try
                {
                    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                    {
                        var output = cnn.Execute($"SELECT userID FROM User WHERE Username = '{user}'");
                        cnn.Execute($"INSERT INTO Readlist (readlist_Name, userID) VALUES ('{readlistName}', {output})");
                    }

                    return null;
                }
                catch 
                {
                    return "Readlist name has to be unique. Try another name.";
                }
            }
        }

        public static List<string> retriveUserLogin(string user)
        {
            while (true)
            {
                try
                {
                    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                    {
                        var output = cnn.Query<string>($"SELECT readlist_name FROM Readlist WHERE userID IN (SELECT readlist_ID FROM Readlist_Books WHERE userID = (SELECT userID FROM User WHERE Username = '{user}'))");
                        return output.ToList();
                    }
                }
                catch
                {
                    
                }
            }
        }

        // This function loads the connection string.
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
