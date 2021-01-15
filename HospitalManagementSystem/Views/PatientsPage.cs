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
    public partial class PatientsPage : Form
    {
        int countPatients = 0;

        public static int TotalPatients;

        public static List<Patients> patientsList = new List<Patients>();

        int idCounter = 1;
        public PatientsPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string fname = firstName.Text;
            string lname = lastName.Text;
            string phone = phoneNumber.Text;


            if (fname == "" || lname == "" || phone == "")
            {   
                message.Visible = true;
                messagePanel.Visible = true;
                message.Text = "Please check inputs and try again";
                messagePanel.BackColor = Color.Red;
               

            }
            else
            { 
                message.Visible = true;
                messagePanel.Visible = true;
                message.Text = "Patient added successfully";
                messagePanel.BackColor = Color.LimeGreen;


                Patients patients = new Patients()
                {
                    PatientId = idCounter++,
                    FirstName = firstName.Text,
                    LastName = lastName.Text,
                    MaritalStatus = cmbMaritalStatus.SelectedItem.ToString(),
                    PhoneNumber = phoneNumber.Text
                };
                patientsBindingSource.Add(patients);

                patientsList.Add(patients);
               
                firstName.Clear();
                lastName.Clear();
                phoneNumber.Clear();
                cmbMaritalStatus.Text = "";
                cmbMaritalStatus.SelectedIndex = -1;
               
            }
           
            
          
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            addPatientDataGrid.Visible = true;
            
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //this.Hide();
                
                //MessageBox.Show(TotalPatients.ToString());
                this.Hide();
                DashBoard dashBoard = new DashBoard();
                dashBoard.Show();
            }
        }

        private void addPatientDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            if (addPatientDataGrid.Columns[e.ColumnIndex].Name == "edit")
            {
                firstName.Text = Convert.ToString(addPatientDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                lastName.Text = Convert.ToString(addPatientDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                cmbMaritalStatus.Text = Convert.ToString(addPatientDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
                phoneNumber.Text = Convert.ToString(addPatientDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString());

                BtnSave.Text = "Update";

            }


            else if (addPatientDataGrid.Columns[e.ColumnIndex].Name == "delete")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    patientsBindingSource.RemoveCurrent();
                    
                }
            }


            if (BtnSave.Text == "Update")
            {
                firstName.Text = Convert.ToString(addPatientDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                lastName.Text = Convert.ToString(addPatientDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                cmbMaritalStatus.Text = Convert.ToString(addPatientDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
                phoneNumber.Text = Convert.ToString(addPatientDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString());

                patientsBindingSource.RemoveCurrent();
                idCounter--;

            }
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            message.Visible = false;
            messagePanel.Visible = false;

        }

        public string GetTotalPatients()
        {
            label7.Text = countPatients++.ToString();
            TotalPatients = int.Parse(label7.Text);
            return TotalPatients.ToString();
        }
    }
}
