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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBname.Text != "" && textBauthor.Text != "" && textPup.Text != "" && textPrice.Text != "" && textQunty.Text != "")
            {
                String bname = textBname.Text;
                String bauthor = textBauthor.Text;
                String publication = textPup.Text;
                String pdate = dateTimePicker1.Text;
                Int64 price = Int64.Parse(textPrice.Text);
                Int64 quan = Int64.Parse(textQunty.Text);


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= DESKTOP-INPO3PU\\SQLEXPRESS; database = library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook1 (bName, bAuthor, bPubl, bPDate, bPrice, bQuan) values ('" + bname + "','" + bauthor + "','" + publication + "','" + pdate + "','" + price + "','" + quan + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBname.Clear();
                textBauthor.Clear();
                textPup.Clear();
                textPrice.Clear();
                textQunty.Clear();
            }
            else
            {
                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will DELETE your Unsaved DATA.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
