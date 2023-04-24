using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Institute_project
{
    public partial class Querying : Form
    {
        public Querying()
        {
            InitializeComponent();
        }

        connection_to_db db = new connection_to_db();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(db.conn);
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select Name, Age, Gender, Level, Fees, Discount, Payment from [Registration].[dbo].[Student_registration] where id = @ID", con1);

            cmd1.Parameters.AddWithValue("ID", txtId.Text);

            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();

            if(reader1.Read())
            {
                txtName.Text = reader1["Name"].ToString();
                txtAge.Text = reader1["Age"].ToString();
                txtGender.Text = reader1["Gender"].ToString();
                txtLevel.Text = reader1["Level"].ToString();
                txtFees.Text = reader1["Fees"].ToString();
                txtDiscount.Text = reader1["Discount"].ToString();
                txtPayment.Text = reader1["Payment"].ToString();
            }




        }

        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(db.conn);
            con1.Open();

            SqlCommand cmd = new SqlCommand("Delete from Student_registration where ID = @ID", con1);

            cmd.Parameters.AddWithValue("@ID", int.Parse(txtId.Text));
            cmd.ExecuteNonQuery();
            con1.Close();
            MessageBox.Show("Deleted duccessfully!");

        }

        private void Querying_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int payment, fees, discount;

            fees = int.Parse(txtFees.Text);
            discount = int.Parse(txtDiscount.Text);


            payment = fees - discount;

            SqlConnection con1 = new SqlConnection(db.conn);
            con1.Open();

            SqlCommand cmd = new SqlCommand("update [Registration].[dbo].[Student_registration] set Name=@Name,Age= @Age, Gender = @Gender, Level = @Level, Fees= @Fees, Discount = @Discount, Payment = @Payment where ID = @ID", con1);


            cmd.Parameters.AddWithValue("@ID", (txtId.Text));
            cmd.Parameters.AddWithValue("@Name", (txtName.Text));
            cmd.Parameters.AddWithValue("@Age", (txtAge.Text));
            cmd.Parameters.AddWithValue("@Gender", (txtGender.Text));
            cmd.Parameters.AddWithValue("@Level", (txtLevel.Text));
            cmd.Parameters.AddWithValue("@Fees", (txtFees.Text));
            cmd.Parameters.AddWithValue("@Discount", (txtDiscount.Text));
            cmd.Parameters.AddWithValue("@Payment", (payment));

            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully!");
            con1.Close();

        }

        private void txtGender_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            QueryMarks q = new QueryMarks();
            q.Show();
            this.Hide();

        }

        private void txtLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}