using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Institute_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void button11_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r = new Registration();
            r.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Querying q = new Querying();

            q.Show();
            this.Hide();



        }

        private void MarksButton_Click(object sender, EventArgs e)
        {
            Grades g = new Grades();

            g.Show();
            this.Hide();
        }

        private void yes(object sender, DragEventArgs e)
        {

        }
    }
}
