﻿using System;
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
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            //panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= DESKTOP-INPO3PU\\SQLEXPRESS; database = library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook1";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        int bid;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
               // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= DESKTOP-INPO3PU\\SQLEXPRESS; database = library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select from NewBook1 where bid "+bid+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            txtBName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtPublication.Text = ds.Tables[0].Rows[0][3].ToString();;
            txtPDate.Text = ds.Tables[0].Rows[0][4].ToString();;
            txtPrice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
           }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if (txtBookName.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= DESKTOP-INPO3PU\\SQLEXPRESS; database = library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewBook1 where bName LIKE '" +txtBookName.Text+ "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= DESKTOP-INPO3PU\\SQLEXPRESS; database = library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewBook1";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_TextChanged(object sender, EventArgs e)
        {
            txtBookName.Clear();
            panel2.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String bname = txtBName.Text;
            String bauthor= txtAuthor.Text;
            String publication =txtPublication.Text;
            String pdate = txtPDate. Text;
            Int64 price =Int64.Parse(txtPrice.Text);
            Int64 quan =Int64.Parse(txtQuantity.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= DESKTOP-INPO3PU\\SQLEXPRESS; database = library; integrated security=True";
            SqlCommand cmd =new SqlCommand();
            cmd.Connection =con;

            cmd.CommandText = "update NewBook1 set bName ='" + bname + "', bAuthor='" + bauthor + "',bPubl ='" + publication + "',bPDate='" + pdate + "',bPrice='" + price + "',bQuan='" + quan + ")";
            SqlDataAdapter da =new SqlDataAdapter(cmd);
            DataSet ds =new DataSet();
            da.Fill(ds);

        }
    }
}
