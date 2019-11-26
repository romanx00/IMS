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
            fill_dd();
        }
        public void fill_dd()
        {
            cbCat.Items.Clear();
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

        private void add_products_Load(object sender, EventArgs e)
        {
            //checks con
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
           
        }
    }
}
