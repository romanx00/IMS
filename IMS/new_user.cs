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


namespace IMS
{
    public partial class new_user : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=IMS;Integrated Security=True");

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
            if (i == 0)
            {
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "Insert into Employee values ('"+txtUsername.Text+ "','" + txtFName.Text + "','" + txtLName.Text + "','" + txtPassword.Text + "','" + txtEmail.Text + "','" + txtContact.Text + "') ";
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
            this.BackColor = Color.FromArgb(56, 111, 178);
        }
        public void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from EMPLOYEE ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

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

            id=Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from EMPLOYEE where id ='"+id+"'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Deleted");
            display();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
