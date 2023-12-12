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
    public partial class ModifyForm : Form
    {
        UserControl2 userItem;
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {

        }

        public void Setup(UserControl2 userItem)
        {
            this.userItem = userItem;
            idTextBox.Text = userItem.useridTextBox.Text;
            dobTextBox.Text = userItem.dateofbirthTextBox.Text;
            emailTextBox.Text = userItem.emailTextBox.Text;
            phoneTB.Text = userItem.phoneTextBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userItem.useridTextBox.Text = idTextBox.Text.Trim();
            userItem.dateofbirthTextBox.Text = dobTextBox.Text.Trim();
            userItem.emailTextBox.Text = emailTextBox.Text.Trim();
            userItem.phoneTextBox.Text = phoneTB.Text.Trim();
            Program.form1.ModifyUser(this.userItem, lnameTB.Text.Trim(), minitTB.Text.Trim(), fnameTB.Text.Trim(), sexTB.Text.Trim());
            this.Close();
        }
    }
}
