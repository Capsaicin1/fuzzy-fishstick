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
        List<Book> Readlist = new List<Book>();
        public frmReadlist()
        {
            InitializeComponent();

            loadReadlist();
        }

        private void loadReadlist()
        {

        }

        private void wireUpReadlist()
        {

        }

        private void btnAddToReadlist_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshReadlist_Click(object sender, EventArgs e)
        {

        }
    }
}
