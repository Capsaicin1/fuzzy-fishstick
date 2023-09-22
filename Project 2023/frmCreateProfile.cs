using System;
using System.Linq;
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
    public partial class frmCreateProfile : Form
    {
        //Variables
        const string inputError = "Oops! Make sure there are no empty fields.";
        const string unknownError = "Oops! We weren't able to excecute that action for unknown reasons. \nPlease try again.";

        public frmCreateProfile()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            //Hides the Create Profile form
            this.Close();
        }

        /*Creates a new user model 'u' and calls the addUser function.
         The function takes the values of 'u' and inserts it into the
         user table in my database.It hides this form causing the login
         form to open again.*/
        private void btnConfirmProfileDetails_Click(object sender, EventArgs e)
        {
            UserModel u = new UserModel
            {
                Username = txtCreateUsername.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
            };

            if (!string.IsNullOrEmpty(txtCreateUsername.Text) &&
                !string.IsNullOrEmpty(txtFirstName.Text) &&
                !string.IsNullOrEmpty(txtLastName.Text) &&
                !txtCreateUsername.Text.Any(Char.IsWhiteSpace))
            {
                string error = SqliteDataAccess.addUser(u);
                txtCreateUsername.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";


                if (error == null)
                {
                    this.Close();
                }
                else { MessageBox.Show("Username has to be unique."); }
            }
            else
            {
                if (!txtCreateUsername.Text.Any(Char.IsWhiteSpace))
                {
                    MessageBox.Show(inputError);
                }
                else
                {
                    MessageBox.Show("Username cannot contain any spaces");
                }
            }
        }
    }
}
