using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New
{
    public partial class BorrowerItem : UserControl
    {
        public BorrowerItem()
        {
            InitializeComponent();
        }

        public BorrowerItem(string Fname, string minit, string Lname, string sex, string phone, string email)
        {
            InitializeComponent();
            fnameTB.Text = Fname;
            minitTB.Text = minit;
            lnameTB.Text = Lname;
            sexTB.Text = sex;
            phoneTB.Text = phone;
            emailTB.Text = email;
        }
        private void BorrowerItem_Load(object sender, EventArgs e)
        {

        }

    }
}
