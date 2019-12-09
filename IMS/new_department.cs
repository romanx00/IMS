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
    public partial class new_department : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=IMS;Integrated Security=True");

        public new_department()
        {
            InitializeComponent();
        }

        private void new_department_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
            display();
            this.BackColor = Color.FromArgb(56, 111, 178);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count = 0;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT * from Department where name = '" + txtName.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            count = Convert.ToInt32(dt1.Rows.Count.ToString());
            if (count == 0)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Department values ('" + txtName.Text + "','" + txtDesc.Text + "')";
                cmd.ExecuteNonQuery();
                txtName.Text =txtDesc.Text = ("");
                display();
                txtName.Focus();
                MessageBox.Show("New department added!");
            }
            else
            {
                MessageBox.Show("Sorry but that Department has been created already");
                txtName.Text = txtDesc.Text = ("");
                txtName.Focus();
            }
            
        }
        public void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from Department";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = txtDesc.Text = ("");
            txtName.Focus();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;

            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from Department where id ='" + id + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Department Deleted");
            display();
        }
    }
}
