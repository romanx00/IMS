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
    public partial class sales : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=IMS;Integrated Security=True");
        DataTable dt = new DataTable();
        int tot = 0;


        public sales()
        {
            InitializeComponent();
        }

        private void sales_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
            dt.Clear();
            dt.Columns.Add("Product");
            dt.Columns.Add("Price");
            dt.Columns.Add("QTY");
            dt.Columns.Add("Total");
            fill_employee_name();



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
                cbUsers.Items.Add(dr["Username"].ToString());
            }

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int stock = 0;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT * from stock where product_name = '" + txtProducts.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                stock = Convert.ToInt32(dr1["product_qty"].ToString());
            }
            if (Convert.ToInt32(txtQty.Text) > stock)
            {
                MessageBox.Show("Sorry this amount is not available");
            }
            else
            {
                DataRow dr = dt.NewRow();
                dr["product"] = txtProducts.Text;
                dr["Price"] = txtPrice.Text;
                dr["QTY"] = txtQty.Text;
                dr["Total"] = txtTotal.Text;
                dt.Rows.Add(dr);
                dataGridView1.DataSource = dt;

                tot = tot + Convert.ToInt32(dr["total"].ToString());
                lbltotalAmount.Text = tot.ToString();



            }

        }



        private void txtProducts_KeyUp(object sender, KeyEventArgs e)
        {
            lbCart.Visible = true;
            lbCart.Items.Clear();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from stock where product_name like ('" + txtProducts.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lbCart.Items.Add(dr["product_name"].ToString());
            }
        }

        private void txtProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lbCart.Focus();
                lbCart.SelectedIndex = 0;

            }
        }

        private void lbCart_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    this.lbCart.SelectedIndex = this.lbCart.SelectedIndex + 1;

                }
                if (e.KeyCode == Keys.Up)
                {
                    this.lbCart.SelectedIndex = this.lbCart.SelectedIndex - 1;

                }
                if (e.KeyCode == Keys.Enter)
                {
                    txtProducts.Text = lbCart.SelectedItem.ToString();
                    lbCart.Visible = false;
                    txtQty.Focus();

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 * from purchase where product_name= '" + txtProducts.Text + "' order by id desc ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtPrice.Text = dr["product_price"].ToString();

            }

        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Text = Convert.ToString(Convert.ToInt32(txtQty.Text) * Convert.ToInt32(txtPrice.Text));
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                tot = 0;
                dt.Rows.RemoveAt(Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString()));
                foreach (DataRow dr1 in dt.Rows)

                {
                    tot = tot + Convert.ToInt32(dr1["total"].ToString());
                    lbltotalAmount.Text = tot.ToString();

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSavePrint_Click(object sender, EventArgs e)
        {
            string orderid = "";
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into order_user values('" + cbUsers.Text + "', '" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "')";
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select top 1 * from order_user order by id desc";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                orderid = dr2["id"].ToString();
            }

            foreach (DataRow dr in dt.Rows)
            {
                int qty = 0;
                string pname = "";


                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into order_itemS values('" + orderid.ToString() + "','" + dr["product"].ToString() + "','" + dr["qty"].ToString() + "','" + dr["total"].ToString() + "')";
                cmd3.ExecuteNonQuery();


                qty = Convert.ToInt32(dr["qty"].ToString());
                pname = dr["product"].ToString();


                SqlCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "update stock set product_qty=product_qty-" + qty + " where product_name='" + pname.ToString() + "'";
                cmd6.ExecuteNonQuery();

            }

            txtPrice.Text = "";
            txtProducts.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";
            lbltotalAmount.Text = "";
            dt.Clear();
            dataGridView1.DataSource = dt;

            MessageBox.Show("Sale added!");


        }
    }
}