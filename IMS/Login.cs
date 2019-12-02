using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace IMS
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=IMS;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int i = 0;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from EMPLOYEE where username ='"+txbUsername.Text+"' and password ='"+txbPassword.Text +"' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i==0)
            {
                MessageBox.Show("Invalid Username or Password!");

            }
            else
            {
                this.Hide();
                MDIParent1 mdi = new MDIParent1();
                mdi.Show();
            }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbPassword.Text = txbUsername.Text = ("");
            txbPassword.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
        }

    }
}
