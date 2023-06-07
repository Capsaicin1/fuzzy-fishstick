﻿using System;
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
        /*Function to load the books in the books table from my database int the readlistbox.
         It does this by loading up a new connection to the database and running a query */
        public static List<Book> LoadBooks()
        {
            using (IDbConnection cnn  = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Book>("select title from Books", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void saveBook(Book book)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Books (Title) values (@Title)", book);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
