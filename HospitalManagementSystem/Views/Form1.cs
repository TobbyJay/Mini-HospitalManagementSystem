using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Increment(1);

            switch (ProgressBar1.Value)
            {
                case 1:
                    loaderLabel.Text = "Loading....";
                    break;
                case 20:
                    loaderLabel.Text = "Setting Up Pages....";
                    break;
                case 40:
                    loaderLabel.Text = "Loading Forms....";
                    break;
                case 60:
                    loaderLabel.Text = "Loading Doctors....";
                    break;
                case 80:
                    loaderLabel.Text = "Loading Patients....";
                    break;
                case 99:
                    loaderLabel.Text = "Welcome...";
                    LoginPage loginPage = new LoginPage();
                    loginPage.Show();
                    this.Hide();
                    break;
               
                default:
                    break;
            }
           
            percentageLabel.Text = ProgressBar1.Value + " %";

        }
    }
}
