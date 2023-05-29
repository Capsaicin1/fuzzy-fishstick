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
    */
    public partial class frmCreateProfile : Form
    {
        public frmCreateProfile()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            //Hides the Create Profile form
            this.Close();
        }

        private void btnConfirmProfileDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
