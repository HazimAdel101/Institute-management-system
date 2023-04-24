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

namespace Institute_project
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        connection_to_db db = new connection_to_db();
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection(db.conn);
            con1.Open();

            int payment, fees, discount;

            fees = int.Parse(txtFees.Text);
            discount = int.Parse(txtDiscount.Text);


            payment = fees - discount;

            SqlCommand cmd1 = new SqlCommand("insert [Registration].[dbo].[Student_registration](Name, Age, Gender, Level, Fees, Discount, Payment) values(@Name, @Age, @Gender, @Level, @Fees, @Discount, @Payment)", con1);
            cmd1.Parameters.AddWithValue("@ID", (txtName.Text));
            cmd1.Parameters.AddWithValue("@Name", (txtName.Text));
            cmd1.Parameters.AddWithValue("@Age", (txtAge.Text));
            cmd1.Parameters.AddWithValue("@Gender", (txtGender.Text));
            cmd1.Parameters.AddWithValue("@Level", (txtLevel.Text));
            cmd1.Parameters.AddWithValue("@Fees", (txtFees.Text));
            cmd1.Parameters.AddWithValue("@Discount", (txtDiscount.Text));
            cmd1.Parameters.AddWithValue("@Payment", (payment));

            cmd1.ExecuteNonQuery();
            MessageBox.Show("Added Successfully!");
            con1.Close();
            con1.Dispose();

            txtName.Text = "";
            txtAge.Text = "";
            txtGender.Text = "";
            txtLevel.Text = "";
            txtFees.Text = "";
            txtDiscount.Text = "";
            txtPayment.Text = "";


        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l = new Login();
            l.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
