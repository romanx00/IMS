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
    public partial class add_products : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexsander\source\repos\IMS\IMS\IMS.mdf;Integrated Security=True");

        public add_products()
        {
            InitializeComponent();
            
      
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            // refresh drop down for each time a product is added 
            fill_ddc();
            fill_ddd();
            fill_dds();
       

            // passes the info into the prodcuts table 
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into PRODUCTS values ('"+txtBarcode.Text+ "','" + txtName.Text + "','" + txtDesc.Text + "'," +
                "'" + cbCat.SelectedItem.ToString() + "','" + cbDep.SelectedItem.ToString() + "','" + cbSup.SelectedItem.ToString() + "') ";
            cmd.ExecuteNonQuery();
            txtBarcode.Text = txtDesc.Text = txtName.Text = ("");
            fill_dg();
            MessageBox.Show("Prodcut added!!");
            
            
        }
        public void fill_ddc()
        {
            // drop down for category 
            //cbCat.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType= CommandType.Text;
            cmd.CommandText = "select * from CATEGORY";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                cbCat.Items.Add(dr["Name"].ToString());
            }
        }
        public void fill_ddd()
        {
            // drop down for department 
           // cbDep.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DEPARTMENT";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbDep.Items.Add(dr["Name"].ToString());
            }
        }
        
        public void fill_dds()
        {
            //drop down for Supplier 
            //cbSup.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SUPPLIER";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbSup.Items.Add(dr["Name"].ToString());
            }
        }

    
        private void add_products_Load(object sender, EventArgs e)
        {
            //checks con
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            // fills drop down menue
            con.Open();
            fill_ddc();
            fill_ddd();
            fill_dds();
            fill_dg();

        }
        public void fill_dg()
        {
            // drop down for category 
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PRODUCTS";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;

            // clears edit drop down
            cbEditCat.Items.Clear();
            cbEditDep.Items.Clear();
            cbEditSup.Items.Clear();

            int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            // drop down for  edit category 
            
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from CATEGORY";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                cbEditCat.Items.Add(dr1["Name"].ToString());
            }
            // drop down for edit department 
            
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from DEPARTMENT";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                cbEditDep.Items.Add(dr2["Name"].ToString());
            }

            //drop down for Edit Supplier 
         
            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select * from SUPPLIER";
            cmd3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            da3.Fill(dt3);
            foreach (DataRow dr3 in dt3.Rows)
            {
                cbEditSup.Items.Add(dr3["Name"].ToString());
            }


            // uses int i to select the row from the data grid to be edited 
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PRODUCTS name where id="+i+" ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtEditBarcode.Text = dr["Barcode"].ToString();
                txtEditName.Text = dr["Name"].ToString();
                txtEditDesc.Text = dr["Desc"].ToString();
                cbEditCat.SelectedText = dr["Category"].ToString();
                cbEditDep.SelectedText = dr["Department"].ToString();
                cbEditSup.SelectedText = dr["Supplier"].ToString();
            }

            

            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "udate PRODUCTS set Barcode = '"+txtEditBarcode.Text+"', Name = '"+txtEditName.Text+"', Desc = '"+txtEditDesc.Text+"'," +
                " Category = '"+cbEditCat.SelectedItem.ToString()+"',  Department = '"+cbEditDep.SelectedItem.ToString()+"', Supplier = '"+cbEditSup.SelectedItem.ToString()+"' where id = '"+i+"'";
            cmd.ExecuteNonQuery();
            //fill_dg();
        }
    }
}
