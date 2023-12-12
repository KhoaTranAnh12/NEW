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
    public partial class AddForm : Form
    {
        
        public AddForm()
        {
            InitializeComponent();
        }

        private void addTB_Click(object sender, EventArgs e)
        {
            UserControl2 userItem = new UserControl2();
            userItem.useridTextBox.Text = userTB.Text.Trim();
            userItem.dateofbirthTextBox.Text = dobTB.Text.Trim();
            userItem.phoneTextBox.Text = sdtTB.Text.Trim();
            userItem.emailTextBox.Text = emailTB.Text.Trim();
            Program.form1.AddUser(userItem, lnameTB.Text.Trim(), minitTB.Text.Trim(), fnameTB.Text.Trim(), sexTB.Text.Trim());
            this.Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
