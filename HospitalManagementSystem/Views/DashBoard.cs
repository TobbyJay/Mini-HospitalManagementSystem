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
    public partial class DashBoard : Form
    {
        int counter = 1;

        public DashBoard()
        {
            InitializeComponent();
        }

       
      
        private void LblDoctors_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                //DoctorsPage doctorsPage = new DoctorsPage();
              //  doctorsPage.Show();
            //    this.Hide();
               
        }

        private void LblPatients_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientsPage patientsPage = new PatientsPage();
            patientsPage.Show();
            //this.Hide();

        }


        private void LblSetUpMeeting_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetUpAppointment setUpAppointment = new SetUpAppointment();
            setUpAppointment.Show();
            //this.Hide();

        }

        private void LblLogout_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to leave this page?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Hide();
            }
           
        }

        private void BtnUploadPhoto_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpeg;*.jpg;.*.gif;) |*.jpeg;*.jpg;.*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                adminImage.Image = new Bitmap(openFileDialog.FileName);
                MessageBox.Show(Convert.ToString(openFileDialog.FileName.ToString()));
            }
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
         //   totalDoctors.Text = DoctorsPage.TotalDoctors.ToString();

            totalPatients.Text = PatientsPage.TotalPatients.ToString();

            /* DoctorsPage getDoctors = new DoctorsPage();
            PatientsPage getPatients = new PatientsPage();

            totalDoctors.Text = getDoctors.GetTotalDoctors();

            totalPatients.Text = getPatients.GetTotalPatients();
            */

        }
    }
}
