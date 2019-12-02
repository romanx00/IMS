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
    public partial class new_supplier : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Keybox;Initial Catalog=IMS;Integrated Security=True");

        public new_supplier()
        {
            InitializeComponent();
        }

        private void new_supplier_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
            display();
        }
        public void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from Supplier";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count = 0;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT * from Supplier where name = '" + txtName.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            count = Convert.ToInt32(dt1.Rows.Count.ToString());
            if (count == 0)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Supplier values ('" + txtName.Text + "','" + txtPhone.Text + "'," +
                    "'" + txtStreet.Text + "','" + txtCity.Text + "','" + txtState.Text + "','" + txtZip.Text + "')";
                cmd.ExecuteNonQuery();
                txtName.Text = txtStreet.Text = txtCity.Text = txtState.Text = txtZip.Text = txtPhone.Text = ("");
                display();
                txtName.Focus();
                MessageBox.Show("New Supplier added!");
            }
            else
            {
                MessageBox.Show("Sorry but that Supplier has been created already");
                txtName.Text = txtStreet.Text = txtCity.Text = txtState.Text = txtZip.Text = txtPhone.Text = ("");
                display();
                txtName.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;

            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from Supplier where id ='" + id + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Supplier Deleted");
            display();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = txtStreet.Text = txtCity.Text = txtState.Text = txtZip.Text = txtPhone.Text = ("");
            display();
            txtName.Focus();
        }

    }
}
