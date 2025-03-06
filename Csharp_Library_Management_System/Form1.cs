using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_User_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void text_Password_MouseEnter(object sender, EventArgs e)
        {

        }

        private void text_User_Name_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void text_Password_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void text_User_Name_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (text_User_Name.Text == "User Name")
            {
                text_User_Name.Clear();
            }
        }

        private void text_User_Name_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void text_User_Name_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void text_Password_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (text_Password.Text == "Password")
            {
                text_Password.Clear();
                text_Password.PasswordChar = '*';
            }
        }

        private void pictureBoxYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com ");
        }

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com ");
        }

        private void pictureBoxInstageam_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-INPO3PU\\SQLEXPRESS ; database = library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from loginTable where username='" + text_User_Name.Text + "' and pass ='"+text_Password.Text+"' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dsa = new Dashboard();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {

        }
    }
}
