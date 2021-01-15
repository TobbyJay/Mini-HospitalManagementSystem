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
    public partial class SetUpAppointment : Form
    {
        int idCounter = 1;

        public SetUpAppointment()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

            if (txtPurpose.Text == "")
            {
                message.Text = "Please check inputs and try again";
                messagePanel.BackColor = Color.Red;
                message.Visible = true;
                messagePanel.Visible = true;
            }
            else
            {
                SetAppointment setAppointment = new SetAppointment()
                {
                    AppointmentId = idCounter++,
                    PatientName = cmbPatientName.SelectedItem.ToString(),
                    DoctorName = cmbDoctorName.SelectedItem.ToString(),
                    DateToVisit = datePicker.Text.ToString(),
                    Time = cmbTime.SelectedItem.ToString(),
                    PurposeOfVisit = txtPurpose.Text

            
                };

                setAppointmentBindingSource.Add(setAppointment);

                message.Text = "Appointment set successfully";
                messagePanel.BackColor = Color.LimeGreen;
                message.Visible = true;
                messagePanel.Visible = true;

                txtPurpose.Clear();
                cmbPatientName.Text = "";
                cmbDoctorName.Text = "";
                cmbTime.Text = "";
                cmbPatientName.SelectedIndex = -1;
                cmbDoctorName.SelectedIndex = -1;
                cmbTime.SelectedIndex = -1;
            }
          
        }

        private void appointmentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (appointmentDataGrid.Columns[e.ColumnIndex].Name == "edit")
            {
                cmbPatientName.Text = Convert.ToString(appointmentDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                cmbDoctorName.Text = Convert.ToString(appointmentDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                cmbTime.Text = Convert.ToString(appointmentDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtPurpose.Text = Convert.ToString(appointmentDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString());

                BtnSubmit.Text = "Update";

            }

            
            else if (appointmentDataGrid.Columns[e.ColumnIndex].Name == "delete")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   setAppointmentBindingSource.RemoveCurrent();
                }
            }

            if (BtnSubmit.Text == "Update")
            {
                cmbPatientName.Text = Convert.ToString(appointmentDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                cmbDoctorName.Text = Convert.ToString(appointmentDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                cmbTime.Text = Convert.ToString(appointmentDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtPurpose.Text = Convert.ToString(appointmentDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString());

                setAppointmentBindingSource.RemoveCurrent();
                idCounter--;

            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            appointmentDataGrid.Visible = true;
        }

        private void SetUpAppointment_Load(object sender, EventArgs e)
        {
            foreach (var item in PatientsPage.patientsList)
            {
                cmbPatientName.Items.Add($"{item.FirstName} {item.LastName}");
            }

            //foreach (var item in DoctorsPage.doctorsList)
            //{
            //    cmbDoctorName.Items.Add($"Dr. {item.FirstName} {item.LastName}");
            //}
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
