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
        // Creating a list where my data will load into.
        List<Book> Readlist = new List<Book>();
        public frmReadlist()
        {
            InitializeComponent();
            loadReadlist();
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
            lbxHaveRead.DisplayMember = "Title";
        }

        private void btnAddToReadlist_Click(object sender, EventArgs e)
        {
            Book b = new Book();

            b.Title = txtEnterBookName.Text;

            SqliteDataAccess.saveBook(b);

            txtEnterBookName.Text = "";
        }

        // The refresh button calls the loadReadList again to load any new entries into the db into the list.
        private void btnRefreshReadlist_Click(object sender, EventArgs e)
        {
            loadReadlist();
        }
    }
}
