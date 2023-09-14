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
        //Lists
        List<string> userReadlists = new List<string>();
        List<int> userExistslist = new List<int>();

        //Variables
        int userExistsValue;
        string username = "";
        const string inputError = "Oops! Make sure there are no empty fields.";
        const string unknownError = "Oops! We weren't able to excecute that action for unknown reasons. \nPlease try again.";

        public frmFirstPage()
        {
            InitializeComponent();
        }

        // Closes the current form and opens the CreateProfile form.
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

        /* Identifies if the userexists by calling the 'userExists' function. If the user exists 
          then closes the current form, send relevant data to the next form and opens the next form. If the user doesn't exist
          then gives the user an error and denies them access.*/
        private void btnContinueFirstPage_Click(object sender, EventArgs e)
        {
            username = txtEnterUsername.Text;

            if(!string.IsNullOrEmpty(username))
            {
                userExistslist = SqliteDataAccess.userExists(username);

                for (int i = 0; i < userExistslist.Count; i++)
                {
                    userExistsValue = userExistslist[i];
                }

                if (userExistsValue == 1)
                {
                    txtEnterUsername.Text = "";
                    errorLabelNoUser.Text = "";

                    /*===============================================================================================*/

                    userReadlists = SqliteDataAccess.retriveUserLogin(username);
                    frmReadlist thirdform = new frmReadlist(userReadlists, username);

                    /*===============================================================================================*/

                    thirdform.ShowDialog();
                    this.Hide();
                    this.Show();
                }
                else
                {
                    txtEnterUsername.Text = "";
                    MessageBox.Show("Username doesn't exist!");
                }
            }
            else
            {
                MessageBox.Show(inputError);
            }
            
        }
    }
}
