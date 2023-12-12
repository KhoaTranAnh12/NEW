using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace New
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=DESKTOP-R7ED1GM;Initial Catalog=KimNgan;Integrated Security=True";

        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
            LoadUser();
        }

        private void connectbtn_Click(object sender, EventArgs e)
        {
            LoadUser();
        }
        private void disconnectbtn_Click(object sender, EventArgs e)
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
                MessageBox.Show("Đóng kết nối thành công");
            }
            else
            {
                MessageBox.Show("Chưa mở kết nối");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void LoadUser()
        {
            try
            {
                sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    //MessageBox.Show("Ket noi thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from USER_table";
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            UserLayoutPanel.Controls.Clear();
            while (reader.Read())
            {
                string id = reader["UserID"].ToString();
                string dateofbirth = reader["DateofBirth"].ToString();
                string phone = reader["Phone"].ToString();
                string email = reader["Email"].ToString();
                UserLayoutPanel.Controls.Add(new UserControl2(id, dateofbirth, phone, email));
            }
            reader.Close();
        }
        
        public void DeleteUser(UserControl2 userItem)
        {
            try
            {
                using (SqlCommand sqlCmd = new SqlCommand("DELETE_USER", sqlCon))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@UserID", userItem.useridTextBox.Text);
                    sqlCmd.ExecuteNonQuery();
                }
                LoadUser();
            }
            catch (Exception ex)
            {
                //todo
            }
        }

        public void ModifyUser(UserControl2 useritem, string lname, string minit, string fname, string sex)
        {
            SqlCommand sqlCmd = new SqlCommand("UPDATE_USER", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@UserID", useritem.useridTextBox.Text);
            sqlCmd.Parameters.AddWithValue("@Dob", useritem.dateofbirthTextBox.Text);
            sqlCmd.Parameters.AddWithValue("@Phone", useritem.phoneTextBox.Text);
            sqlCmd.Parameters.AddWithValue("@Email", useritem.emailTextBox.Text); //loi
            sqlCmd.Parameters.AddWithValue("@LName", lname);
            sqlCmd.Parameters.AddWithValue("@Minit", minit);
            sqlCmd.Parameters.AddWithValue("@FName", fname);
            sqlCmd.Parameters.AddWithValue("@Sex", sex);

            sqlCmd.Connection = sqlCon;
            try
            {
                sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                
            }
            LoadUser();
        }

        public void AddUser(UserControl2 useritem, string lname, string minit, string fname, string sex)
        {
            SqlCommand sqlCmd = new SqlCommand("INSERT_USER", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@UserID", useritem.useridTextBox.Text);
            sqlCmd.Parameters.AddWithValue("@Dob", useritem.dateofbirthTextBox.Text);
            sqlCmd.Parameters.AddWithValue("@Phone", useritem.phoneTextBox.Text);
            sqlCmd.Parameters.AddWithValue("@Email", useritem.emailTextBox.Text);
            sqlCmd.Parameters.AddWithValue("@LName", lname);
            sqlCmd.Parameters.AddWithValue("@Minit", minit);
            sqlCmd.Parameters.AddWithValue("@FName", fname);
            sqlCmd.Parameters.AddWithValue("@Sex", sex);


            sqlCmd.Connection = sqlCon;
            try
            {
                sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                
               
            }

            LoadUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm addform = new AddForm();
            addform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("SelectNameBorrower", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@BookTitle", searchTB.Text);
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            UserLayoutPanel.Controls.Clear();
            while (reader.Read())
            {
                string lname = reader["LName"].ToString();
                string minit = reader["Minit"].ToString();
                string fname = reader["FName"].ToString();
                string sex = reader["Sex"].ToString();
                string phone = reader["phone"].ToString();
                string email = reader["email"].ToString();
                UserLayoutPanel.Controls.Add(new BorrowerItem(lname, minit, fname, sex, phone, email));
            }
            reader.Close();
        }

        //public void AddBorrower(BorrowerItem borrowerItem)
        //{
        //    SqlCommand sqlCmd = new SqlCommand("INSERT_Borrower", sqlCon);
        //    sqlCmd.CommandType = CommandType.StoredProcedure;

        //    sqlCmd.Parameters.AddWithValue("@UserID", useritem.useridTextBox.Text);
        //    sqlCmd.Parameters.AddWithValue("@Dob", useritem.dateofbirthTextBox.Text);
        //    sqlCmd.Parameters.AddWithValue("@Phone", useritem.phoneTextBox.Text);
        //    sqlCmd.Parameters.AddWithValue("@Email", useritem.emailTextBox.Text);


        //    sqlCmd.Connection = sqlCon;
        //    try
        //    {
        //        sqlCmd.ExecuteNonQuery();
        //    }
        //    catch (SqlException ex)
        //    {


        //    }

        //    LoadUser();
        //}
    }
}
