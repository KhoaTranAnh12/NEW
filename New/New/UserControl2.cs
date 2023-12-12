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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        public UserControl2(string id, string dateofbirth, string phone, string email)
        {
            InitializeComponent();
            useridTextBox.Text = id;
            dateofbirthTextBox.Text = dateofbirth;
            phoneTextBox.Text = phone;
            emailTextBox.Text = email; 
        }

        private void xoabtn_Click(object sender, EventArgs e)
        {
            Program.form1.DeleteUser(this);

        }

        private void suabtn_Click(object sender, EventArgs e)
        {
            ModifyForm modifyForm = new ModifyForm();
            modifyForm.Setup(this);
            modifyForm.Show();
        }
    }
}
