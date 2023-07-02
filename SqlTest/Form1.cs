using System.Data;
using System.Data.SqlClient;

namespace SqlTest
{
    public partial class SqlTest : Form
    {
        public SqlTest()
        {
            InitializeComponent();
        }

        //Connetcion Adress
        SqlConnection conn = new SqlConnection("Data Source=ILY\\UDAYAN;Initial Catalog=Deneme;Integrated Security=True");

        private void BtnConOpen_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Connection is already open!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                openconnection();
            }

        }


        private void BtnConClose_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                MessageBox.Show("Connection is already close!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                closeconnection();
            }
        }


        private void BtnConCheck_Click(object sender, EventArgs e)
        {
            checkconnection();
        }

        //--------------------------------------- Local Classes ---------------------------------------
        private void checkconnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                LblState.Text = "Connection is Open!";
                LblState.ForeColor = Color.Green;
                pictureBox1.Image = Properties.Resources.YesConn;
            }
            else
            {
                LblState.Text = "Connection is Close!";
                LblState.ForeColor = Color.Red;
                pictureBox1.Image = Properties.Resources.NoConn;
            }
        }

        private void closeconnection()
        {
            conn.Close();
            if (conn.State == ConnectionState.Closed)
            {
                LblState.Text = "Connection is Open!";
                LblState.ForeColor = Color.Red;
                pictureBox1.Image = Properties.Resources.NoConn;
            }
        }
        private void openconnection()
        {
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                LblState.Text = "Connection is Close!";
                LblState.ForeColor = Color.Green;
                pictureBox1.Image = Properties.Resources.YesConn;
            }
        }
    }
}