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
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=IMS;Integrated Security=True");

        public add_products()
        {
            InitializeComponent();
            
      
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            // refresh drop down for each time a product is added 
            
       

            // passes the info into the prodcuts table 
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into PRODUCTS values ('"+txtBarcode.Text+ "','" + txtName.Text + "','" + txtDesc.Text + "'," +
                "'" + cbCat.SelectedItem.ToString() + "','" + cbDep.SelectedItem.ToString() + "','" + cbSup.SelectedItem.ToString() + "','" + txtPrice.Text + "') ";
            cmd.ExecuteNonQuery();
            
            fill_dg();
            MessageBox.Show("Prodcut added!!");
            clear();

            
            
        }
        public void clear()
        {
            txtBarcode.Text = txtPrice.Text= txtDesc.Text = txtName.Text = ("");
            // clearing coboboxes breaks drop down not sure how to fix 
            //cbCat.Items.Clear();
            //cbDep.Items.Clear();
            //cbSup.Items.Clear();
            txtEditBarcode.Text = txtEditDesc.Text = txtEditName.Text = txtEditPrice.Text = ("");
            //cbEditCat.Items.Clear();
           // cbEditDep.Items.Clear();
            //cbEditSup.Items.Clear();
            fill_dg();
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
               // cbEditCat.Items.Add(dr["Name"].ToString());
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
                //cbEditDep.Items.Add(dr["Name"].ToString());


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
                //cbEditSup.Items.Add(dr["Name"].ToString());

            }
        }
        public void fill_Editddc()
        {
            // drop down for category 
            //cbCat.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from CATEGORY";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbEditCat.Items.Add(dr["Name"].ToString());

            }
        }
        public void fill_Editddd()
        {
            // drop down for category 
            //cbCat.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DEPARTMENT";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
               cbEditDep.Items.Add(dr["Name"].ToString());
                
            }
        }
        public void fill_Editdds()
        {
            // drop down for category 
            //cbCat.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SUPPLIER";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbEditSup.Items.Add(dr["Name"].ToString());
                
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
            panel2.Visible = false;
            this.BackColor = Color.FromArgb(56, 111, 178);


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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // delete products then fill data grid 
            int id;

            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from Products where id ='" + id + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Deleted");
            fill_dg();
            
        }

        private void btnEditSelect_Click(object sender, EventArgs e)
        {
            {

                fill_Editddc();
                fill_Editddd();
                fill_Editdds();
               
                panel2.Visible = true;
                int id;
                // grabs row form dt a moves to dr 
                id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from products where id ='" + id + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    // sets update txt boxs to db info 
                    txtEditBarcode.Text = dr["Barcode"].ToString();
                    txtEditName.Text = dr["Name"].ToString();
                    txtEditDesc.Text = dr["Desc"].ToString();
                    txtEditPrice.Text = dr["price"].ToString();
                    
                    cbEditCat.SelectedText = dr["Category"].ToString();
                    cbEditDep.SelectedText = dr["Department"].ToString();
                    cbEditSup.SelectedText = dr["Supplier"].ToString();
                    


                }



            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // this allows for updating dealer info 
            int id;

            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update products  SET Barcode = '" + txtEditBarcode.Text + "', Name = '" + txtEditName.Text + "', Desc = '" + txtEditDesc.Text + "', Category = '" + cbEditCat.SelectedItem.ToString() + "', Department = '" + cbEditDep.SelectedItem.ToString() + "', Supplier = '" + cbEditSup.SelectedItem.ToString() + "',  Price = '" + txtEditPrice.Text + "' where id = '" + id + "')";
            cmd.ExecuteNonQuery();
            panel2.Visible = false;
            clear();
            
        }
    

    }
}
