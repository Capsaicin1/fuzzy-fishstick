﻿using System;
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
            bool retry = true;

            /*while (retry)
            {
                userReadlists = SqliteDataAccess.retriveUserLogin(username);
                bool isEmpty = SqliteDataAccess.IsEmpty(userReadlists);

                if (!isEmpty)
                {
                    this.Hide();
                    frmReadlist thirdform = new frmReadlist(userReadlists, username);
                    thirdform.ShowDialog();
                    retry = false;
                }
                else
                {
                    retry = true;
                }
            }*/

            while (retry)
            {
                userReadlists = SqliteDataAccess.retriveUserLogin(username);
                bool user_exists = SqliteDataAccess.userExists(username);

                if (user_exists)
                {
                    this.Hide();
                    frmReadlist thirdform = new frmReadlist(userReadlists, username);
                    thirdform.ShowDialog();
                    retry = false;
                }
                else
                {
                    retry = false;
                }
            }
            this.Show();
        }
    }
}
