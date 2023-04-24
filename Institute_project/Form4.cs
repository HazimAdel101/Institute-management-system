using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Institute_project
{
    public partial class Grades : Form
    {
        public Grades()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l  = new Login();

            l.Show();
            this.Hide();
            

            
        }
        connection_to_db db2 = new connection_to_db();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(db2.conn);
            con1.Open();


            SqlCommand cmd1 = new SqlCommand("insert [Registration].[dbo].[Marks] ( HW,Attendance , Story ,Quiz1 ,Quiz2,Particiption, Presentation , FinalExam  , FinalResult , Evaluation , id) values (@HW,@Attendance,  @story ,@Quiz1 ,@Quiz2 ,@Particiption, @Presentation , @FinalExam ,  @FinalResult,@Evaluation,  @ID)", con1);

           

            cmd1.Parameters.AddWithValue("@ID", (txtId.Text));
            cmd1.Parameters.AddWithValue("@HW", (txtHW.Text));
            cmd1.Parameters.AddWithValue("@Attendance", (txtAttendance.Text));
            cmd1.Parameters.AddWithValue("@Story", (txtStory.Text));
            cmd1.Parameters.AddWithValue("@Quiz1", (txtQuiz1.Text));
            cmd1.Parameters.AddWithValue("@Quiz2", (txtQuiz2.Text));
            cmd1.Parameters.AddWithValue("@Particiption", (txtParticipation.Text));
            cmd1.Parameters.AddWithValue("@Presentation", (txtPresentation.Text));
            cmd1.Parameters.AddWithValue("@FinalExam", (txtFinalExam.Text));
            cmd1.Parameters.AddWithValue("@FinalResult", (txtFinalResult.Text));
            cmd1.Parameters.AddWithValue("@Evaluation", (txtEvaluation.Text));

            cmd1.ExecuteNonQuery();
            MessageBox.Show("Added Successfully!");
            con1.Close();
            con1.Dispose();

            txtHW.Text = "";
            txtAttendance.Text = "";
            txtStory.Text = "";
            txtQuiz1.Text = "";
            txtQuiz2.Text = "";
            txtParticipation.Text = "";
            txtPresentation.Text = "";
            txtFinalExam.Text = "";
            txtFinalResult.Text = "";
            txtEvaluation.Text = "";


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Login l = new Login();

            l.Show();
            this.Close();
        }

        private void Grades_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
