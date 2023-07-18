using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;
using System.Data;
using System.Configuration;

namespace Project_2023
{
    
    // A seperate class to access my database. I will write all of my SQL queries in this class.
    public class SqliteDataAccess
    {
        public string testname = "test";
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

        /*This function inserts the user data the user enters into the user table in my
         database by executing sql.*/
        public static string addUser(UserModel user)
        {
            while (true)
            {
                try
                {
                    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                    {
                        cnn.Execute("insert into User (Username, FirstName, LastName) values (@Username, @FirstName, @LastName)", user);
                    }

                    return null;
                }
                catch
                {
                    return "Your username has to be unique.";
                }

            }
        }

        /*public static void dynamic_data_entry()
        {
            UserModel user = new UserModel
            {
                Username = "test",
            };
        }*/

        public static List<string> retriveUserLogin(UserModel user)
        {            
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                int output = cnn.Execute("SELECT readlist_name FROM Readlist WHERE userID IN (SELECT readlist_ID FROM Readlist_Books where userID = (SELECT userID FROM User WHERE Username = values (@Username)))", user);
                output.ToString();
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
