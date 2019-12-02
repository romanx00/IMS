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
    public partial class Units : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Keybox;Initial Catalog=IMS;Integrated Security=True");

        public Units()
        {
            InitializeComponent();
        }

        private void Units_Load(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
            display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count = 0;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT * from UNITS where unit= '"+txtUnit.Text+"'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            count  = Convert.ToInt32(dt1.Rows.Count.ToString());
            if(count==0)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into UNITS values ('" + txtUnit.Text + "')";
                cmd.ExecuteNonQuery();
                txtUnit.Text = ("");
                display();
            }
            else
            {
                MessageBox.Show("Sorry but that Unit has been created already");
            }
            

        }
        public void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from UNITS";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;

            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from units where id ='" + id + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Unit Deleted");
            display();
        }
    }
}
