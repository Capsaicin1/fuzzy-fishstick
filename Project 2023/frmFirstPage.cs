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
    public partial class frmFirstPage : Form
    {
        List<string> userReadlists = new List<string>();

        public frmFirstPage()
        {
            InitializeComponent();
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            //Hides frmFirstPage
            this.Hide();

            //Makes new form and opens the dialog for it
            frmCreateProfile secondform = new frmCreateProfile();
            secondform.ShowDialog();

            //Show this form again when CreateProfile form is closed
            this.Show();
        }

        private void btnContinueFirstPage_Click(object sender, EventArgs e)
        {
            string username = txtEnterUsername.Text;
            //bool retry = false;

            int user_exists = SqliteDataAccess.userExists(username);
            label2.Text = user_exists.ToString();
            /*if (user_exists == true)
            {
                label2.Text = "data is here";
                txtEnterUsername.Text = "";
                //userReadlists = SqliteDataAccess.retriveUserLogin(username);
                //frmReadlist thirdform = new frmReadlist(userReadlists, username);
                //retry = false;
                //thirdform.ShowDialog();
                //this.Hide();
            }
            else
            {
                txtEnterUsername.Text = "";
                label2.Text = "false";
                //retry = true;
            }*/
            //this.Show();
        }
    }
}
