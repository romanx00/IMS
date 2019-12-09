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
    public partial class purchase : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=IMS;Integrated Security=True");

        public purchase()
        {
            InitializeComponent();
        }

        private void purchase_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
            fill_product_name();
            fill_employee_name();
            fill_Department_name();
            cbProductName.Focus();
            this.BackColor = Color.FromArgb(56, 111, 178);


        }

        public void fill_product_name()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from products";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                cbProductName.Items.Add(dr["Name"].ToString());
            }
        }
        public void fill_employee_name()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from Employee";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbEmpName.Items.Add(dr["Username"].ToString());
            }
        }
        public void fill_Department_name()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from Department";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbDepartment.Items.Add(dr["Name"].ToString());
            }
        }
     
     

        private void cbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from products where name = '" + cbProductName.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblCategorySelection.Text = dr["Category"].ToString();
                lblPriceSelect.Text = dr["Price"].ToString();


            }
        }

        

        private void txtQuantity_Leave_1(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from products where name = '" + cbProductName.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblPurTotal.Text = Convert.ToString(Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(dr["Price"]));

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT * from stock where product_name = '" + cbProductName.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            i = Convert.ToInt32(dt1.Rows.Count.ToString());
            if (i==0)
            {
                // if not in stock table adds into purchase and stock tables
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Purchase  values ('" + cbProductName.Text + "','" + txtQuantity.Text + "','" + lblPriceSelect.Text + "','" + lblPurTotal.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + cbEmpName.Text + "')";
                cmd.ExecuteNonQuery();

                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "Insert into Stock  values ('" + cbProductName.Text + "','" + txtQuantity.Text + "','" + cbDepartment.Text + "')";
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Item purchase added to stock!");
            }
            else
            {
                //if allready in stock tables adds to just purchase order 
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "Insert into Purchase  values ('" + cbProductName.Text + "','" + txtQuantity.Text + "','" + lblPriceSelect.Text + "','" + lblPurTotal.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + cbEmpName.Text + "')";
                cmd2.ExecuteNonQuery();
                // updates the stock table 
                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "update stock set product_qty = product_qty +  " + txtQuantity.Text + " where product_name ='" + cbProductName.Text + "' ";
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Item purchase added to stock!");
            }




          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbDepartment.Text = "";
            cbEmpName.Text = "";
            cbProductName.Text = "";
            lblPriceSelect.Text = lblPurTotal.Text = ("");
            txtQuantity.Text = ("");
           
           
        }
    }
}
