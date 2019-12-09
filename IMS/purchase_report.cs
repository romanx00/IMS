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
    public partial class purchase_report : Form

    {

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=IMS;Integrated Security=True");


        string query = "";

        public purchase_report()
        {
            InitializeComponent();
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from purchase";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            foreach (DataRow dr in dt.Rows)
            {
                i = i + Convert.ToInt32(dr["prodcut_total"].ToString());

            }

            lbltest.Text = i.ToString();

            query = "select * from purchase";




        }

        private void purchase_report_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            this.BackColor = Color.FromArgb(56, 111, 178);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string startdate;
            string enddate;

            startdate = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            enddate = dateTimePicker2.Value.ToString("MM/dd/yyyy");

            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from purchase where purchase_date>='" + startdate.ToString() + "' AND purchase_date<='" + enddate.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            foreach (DataRow dr in dt.Rows)
            {
                i = i + Convert.ToInt32(dr["prodcut_total"].ToString());

            }
            lbltest.Text = i.ToString();
            query = "select * from purchase where purchase_date>='" + startdate.ToString() + "' AND purchase_date<='" + enddate.ToString() + "'";

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           // generate_purchase_report gpr = new generate_purchase_report();
           // gpr.get_value(query.ToString());
            //gpr.Show();
        }
    }
}
