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
using System.Data.Sql;

/// <summary>
/// 
/// ISDS 454 Team 2 Project
/// Inventory Management System v1.0
/// ------------------------------
/// new user form is completed
/// </summary>

namespace IMS
{
    public partial class new_user : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vhgia\Desktop\ISDS_454\IMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dt;
        int id = 0;

        public new_user()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from EMPLOYEE where username ='" + txtUsername.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if ((string.IsNullOrEmpty(txtUsername.Text) |
                ((string.IsNullOrEmpty(txtFName.Text)) |
                ((string.IsNullOrEmpty(txtPassword.Text)) |
                ((string.IsNullOrEmpty(txtEmail.Text)) |
                ((string.IsNullOrEmpty(txtContact.Text))))))))
            {
                MessageBox.Show("One ore more field is empty please try again");
            }
            else
            {
                if (i == 0)
                {
                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "Insert into Employee values ('" + txtUsername.Text + "','" + txtFName.Text + "','" + txtLName.Text + "','" + txtPassword.Text + "','" + txtEmail.Text + "','" + txtContact.Text + "') ";
                    cmd1.ExecuteNonQuery();
                    //clears txt 
                    txtUsername.Text = txtPassword.Text = txtFName.Text = txtLName.Text = txtEmail.Text = txtContact.Text = ("");
                    display();

                    // added mesg 
                    MessageBox.Show("New user added!");


                }
                else
                {
                    MessageBox.Show("Sorry that username is already taken!");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void new_user_Load(object sender, EventArgs e)
        {
            //checks con
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
            display();
        }
        public void display()
        {
            adapt = new SqlDataAdapter("SELECT * FROM EMPLOYEE", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears txt 
            txtUsername.Text = txtPassword.Text = txtFName.Text = txtLName.Text = txtEmail.Text = txtContact.Text = ("");
            display();
            txtUsername.Focus();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id;
            con.Open();
            id=Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from EMPLOYEE where id ='"+id+"'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Deleted");
            display();
            con.Close();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtLName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtContact.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtFName.Text !="" && txtLName.Text != "" &&
                txtPassword.Text != "" && txtEmail.Text !="" && txtContact.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("UPDATE EMPLOYEE SET Username=@user,FName=@first,LName=@last,Password=@pass,Email=@email,Contact=@contact WHERE id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@first", txtFName.Text);
                cmd.Parameters.AddWithValue("@last", txtLName.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated successfully");
                con.Close();
                display();
            }
            else
            {
                MessageBox.Show("Please select a record");
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
