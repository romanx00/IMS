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

namespace IMS
{
    public partial class dealer_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=IMS;Integrated Security=True");

        public dealer_info()
        {
            InitializeComponent();
        }

        private void btnDealerAdd_Click(object sender, EventArgs e)
        {
            // checks if another row in db shares name 
            int count = 0;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT * from Dealer_info where DealerName = '" + txtDealerName.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            count = Convert.ToInt32(dt1.Rows.Count.ToString());
            if (count == 0)
                // inserts into db if no match found 
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Dealer_Info values ('" + txtDealerName.Text + "','" + txtDealerCName.Text + "','" + txtDealerContact.Text + "','" + txtDealerDesc.Text + "')";
                cmd.ExecuteNonQuery();
                txtDealerName.Text = txtDealerCName.Text = txtDealerContact.Text = txtDealerDesc.Text = ("");
                display();
                txtDealerName.Focus();
                MessageBox.Show("New Dealer added!");
            }
            else
            {
                // shows message that name has been taken already 
                MessageBox.Show("Sorry but that Dealer has been created already");
                txtDealerName.Text = txtDealerCName.Text = txtDealerContact.Text = txtDealerDesc.Text = ("");
               
                txtDealerName.Focus();
            }
        }

        private void dealer_info_Load(object sender, EventArgs e)
            // closes and then reopnes connection 
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
            display();
        }
        public void display()
            // sets data grid to dealer info also shown as dg
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from dealer_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDeleteDealer_Click(object sender, EventArgs e)
        {
            int id;

            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from Dealer_Info where id ='" + id + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Dealer Deleted");
            display();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           txtNameUpdate.Text= txtCNameUpdate.Text= txtContactUpdate.Text= txtDescUpdate.Text= txtDealerName.Text = txtDealerCName.Text = txtDealerContact.Text = txtDealerDesc.Text = ("");
            display();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            int id;
            // grabs row form dt a moves to dr 
            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Dealer_Info where id ='" + id + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                // sets update txt boxs to db info 
                txtNameUpdate.Text = dr["DealerName"].ToString();
                txtCNameUpdate.Text = dr["DealerCompanyName"].ToString();
                txtContactUpdate.Text = dr["DealerContact"].ToString();
                txtDescUpdate.Text = dr["DealerDesc"].ToString();


            }

            

        }

        private void btnUpdateDealer_Click(object sender, EventArgs e)


        {
            // this allows for updating dealer info 
            int id;

            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Dealer_Info  SET DealerName = '"+txtNameUpdate.Text+"', DealerCompanyName = '"+txtCNameUpdate.Text+"', DealerContact = '"+txtContactUpdate.Text+"', DealerDesc = '"+txtDescUpdate.Text+"'  where id = '" + id + "'";
            cmd.ExecuteNonQuery();
            panel2.Visible = false;
            display();


        }
    }
}
