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
    public partial class QueryMarks : Form
    {
        public QueryMarks()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Querying q = new Querying();
            q.Show();
            this.Close();
        }

        connection_to_db db2 = new connection_to_db();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(db2.conn);
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select HW,Attendance,Story,Quiz1,Quiz2,Particiption,Presentation,FinalExam,FinalResult,Evaluation FROM [Registration].[dbo].[Marks]   where id= @ID ", con1);

            cmd1.Parameters.AddWithValue("ID", txtId.Text);

            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
               // txtName.Text = reader1["Name"].ToString();
                txtHW.Text = reader1["HW"].ToString();
                txtAttendance.Text = reader1["Attendance"].ToString();
                txtStory.Text = reader1["Story"].ToString();
                txtQuiz1.Text = reader1["Quiz1"].ToString();
                txtQuiz2.Text = reader1["Quiz2"].ToString();
                txtParticipation.Text = reader1["Particiption"].ToString();
                txtPresentation.Text = reader1["Presentation"].ToString();
                txtFinalExam.Text = reader1["FinalExam"].ToString();
                txtFinalResult.Text = reader1["FinalResult"].ToString();
                txtEvaluation.Text = reader1["Evaluation"].ToString();

            }

        }
        connection_to_db db3= new connection_to_db();

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection(db3.conn);
            con1.Open();
            

            SqlCommand cmd = new SqlCommand("update [Registration].[dbo].[Marks] set HW= @HW, Attendance = @Attendance, Story = @Story, Quiz1= @Quiz1, Quiz2 = @Quiz2, Particiption = @Participation, Presentation = @Presentation, FinalExam = @FinalExam, FinalResult = @FinalResult, Evaluation = @Evaluation where id = @ID", con1);

           

            cmd.Parameters.AddWithValue("@ID", (txtId.Text));
           
            cmd.Parameters.AddWithValue("@HW", (txtHW.Text));
            cmd.Parameters.AddWithValue("@Attendance", (txtAttendance.Text));
            cmd.Parameters.AddWithValue("@Story", (txtStory.Text));
            cmd.Parameters.AddWithValue("@Quiz1", (txtQuiz1.Text));
            cmd.Parameters.AddWithValue("@Quiz2", (txtQuiz2.Text));
            cmd.Parameters.AddWithValue("@Participation", (txtParticipation.Text));
            cmd.Parameters.AddWithValue("@Presentation", (txtPresentation.Text));
            cmd.Parameters.AddWithValue("@FinalExam", (txtFinalExam.Text));
            cmd.Parameters.AddWithValue("@FinalResult", (txtFinalResult.Text));
            cmd.Parameters.AddWithValue("@Evaluation", (txtEvaluation.Text));

            cmd.ExecuteNonQuery();
           
            MessageBox.Show("Updated Successfully!");
            con1.Close();

            SqlConnection con2 = new SqlConnection(db3.conn);
            con2.Open();
            SqlCommand cmd1 = new SqlCommand("UPDATE [Registration].[dbo].[Student_registration] set Name = @Name where ID = @ID", con2);

            cmd1.Parameters.AddWithValue("@ID", (txtId.Text));
           // cmd1.Parameters.AddWithValue("@Name", (txtName.Text));
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully!");
            con2.Close();

        }

        private void QueryMarks_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}