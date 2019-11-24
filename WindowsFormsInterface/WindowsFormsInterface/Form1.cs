using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPanel.Show();
            SigninPanel.Hide();
            SignupPanel.Hide();
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void Signin_Click(object sender, EventArgs e)
        {
            SigninPanel.Show();
            AvailablePanel.Hide();
            RequestPanel.Hide();
            MessagePanel.Hide();
        }

        private void SignupBack_Click(object sender, EventArgs e)
        {
            
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            SignupPanel.Show();
       }

        private void AvailableConnection_Click(object sender, EventArgs e)
        {
            AvailablePanel.Show();
        }

        private void IncommingRquest_Click(object sender, EventArgs e)
        {
            RequestPanel.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            StartPanel.Show();
            SignupPanel.Hide();
        }

        private void Request_Click(object sender, EventArgs e)
        {
            MessagePanel.Show();
        }

        //private void Logout_Click(object sender, EventArgs e)
        //{
        //    StartPanel.Show();

        //}

        private void Accept_Click(object sender, EventArgs e)
        {
            MessagePanel.Show();
        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            MessagePanel.Hide();
            SigninPanel.Hide();
            RequestPanel.Hide();
            AvailablePanel.Hide();
            StartPanel.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
