using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        string[] bookGenre = { "Fiction", "Non-Fiction" };
        string[] hasRead = { "1", "0" };
        List<string> userReadlists = new List<string>();

        // Creating a list where my data will load into.
        List <Book> Readlist = new List <Book>();
        public frmReadlist(List<string> argsUserReadlists)
        {
            userReadlists = argsUserReadlists;
            InitializeComponent();
            loadReadlist();
        }

        private void frmReadlist_Load(object sender, EventArgs e)
        {
            //For loop loops through the bookGenre array and populates the EnterGenre combobox with those values.
            for (int i = 0; i < bookGenre.Length; i++)
                cmbEnterGenre.Items.Add(bookGenre[i]);
            //For loop loops through the hasRead array and populates the EnterHasRead combobox with those values.
            for (int i = 0; i < hasRead.Length; i++)
                cmbEnterHasRead.Items.Add(hasRead[i]);
            for (int i = 0;i < userReadlists.Count; i++)
                cmbMyReadlists.Items.Add(userReadlists[i]);
        }

        // This function loads the data into the list and wires up the list.
        private void loadReadlist()
        {
            Readlist = SqliteDataAccess.LoadBooks();
            wireUpReadlist();
        }

        /* This function sets the data source for the HaveRead listbox to the Readlist list
         and the displaymember as the Title */
        private void wireUpReadlist()
        {
            lbxHaveRead.DataSource = Readlist;
            lbxHaveRead.DataSource = null;
            lbxHaveRead.DisplayMember = "BookTitle";
        }

        private void btnAddToReadlist_Click(object sender, EventArgs e)
        {
            Book b = new Book
            {
                Title = txtEnterBookName.Text,
                Author = txtEnterAuthor.Text,
                Genre = cmbEnterGenre.Text,
                hasRead = cmbEnterHasRead.Text
            };

            Convert.ToInt32(cmbEnterHasRead.SelectedItem);

            SqliteDataAccess.saveBook(b);

            txtEnterBookName.Text = "";
            txtEnterAuthor.Text = "";
            cmbEnterGenre.Text = "";
            cmbEnterHasRead.Text = "";
        }

        // The refresh button calls the loadReadList again to load any new entries into the db into the list.
        private void btnRefreshReadlist_Click(object sender, EventArgs e)
        {
            loadReadlist();
        }

        private void btnCreateNewReadlist_Click(object sender, EventArgs e)
        {
            string readlistName = txtNewReadlistName.Text;
            SqliteDataAccess.createReadlist(readlistName);
        }
    }
}
