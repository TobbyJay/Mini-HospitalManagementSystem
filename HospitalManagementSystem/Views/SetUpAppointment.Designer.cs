namespace HospitalManagementSystem
{
    partial class SetUpAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetUpAppointment));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDoctorName = new System.Windows.Forms.ComboBox();
            this.appointmentDataGrid = new System.Windows.Forms.DataGridView();
            this.setAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbPatientName = new System.Windows.Forms.ComboBox();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.message = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateToVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purposeOfVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setAppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.messagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Panel1.Controls.Add(this.datePicker);
            this.Panel1.Controls.Add(this.label8);
            this.Panel1.Controls.Add(this.label7);
            this.Panel1.Controls.Add(this.cmbTime);
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Controls.Add(this.txtPurpose);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.cmbDoctorName);
            this.Panel1.Controls.Add(this.appointmentDataGrid);
            this.Panel1.Controls.Add(this.cmbPatientName);
            this.Panel1.Controls.Add(this.BtnView);
            this.Panel1.Controls.Add(this.BtnClose);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.BtnSubmit);
            this.Panel1.Controls.Add(this.label6);
            this.Panel1.Location = new System.Drawing.Point(66, 46);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(738, 459);
            this.Panel1.TabIndex = 14;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(167, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(421, 14);
            this.label7.TabIndex = 37;
            this.label7.Text = "Note: You can only set an appointment for (Monday -Friday 10:00am-4:00pm).";
            // 
            // cmbTime
            // 
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "10:00am",
            "11:00am",
            "12:00pm",
            "1:00pm",
            "2:00pm",
            "3:00pm",
            "4:00pm"});
            this.cmbTime.Location = new System.Drawing.Point(284, 185);
            this.cmbTime.MaxDropDownItems = 100;
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(234, 23);
            this.cmbTime.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(142, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Time :";
            // 
            // txtPurpose
            // 
            this.txtPurpose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurpose.Location = new System.Drawing.Point(284, 216);
            this.txtPurpose.Multiline = true;
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(234, 46);
            this.txtPurpose.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(142, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Purpose of visit :";
            // 
            // cmbDoctorName
            // 
            this.cmbDoctorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctorName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctorName.FormattingEnabled = true;
            this.cmbDoctorName.Location = new System.Drawing.Point(284, 116);
            this.cmbDoctorName.MaxDropDownItems = 100;
            this.cmbDoctorName.Name = "cmbDoctorName";
            this.cmbDoctorName.Size = new System.Drawing.Size(234, 23);
            this.cmbDoctorName.Sorted = true;
            this.cmbDoctorName.TabIndex = 32;
            // 
            // appointmentDataGrid
            // 
            this.appointmentDataGrid.AllowUserToAddRows = false;
            this.appointmentDataGrid.AllowUserToOrderColumns = true;
            this.appointmentDataGrid.AutoGenerateColumns = false;
            this.appointmentDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.appointmentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentIdDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.doctorNameDataGridViewTextBoxColumn,
            this.dateToVisit,
            this.Time,
            this.purposeOfVisitDataGridViewTextBoxColumn,
            this.edit,
            this.delete});
            this.appointmentDataGrid.DataSource = this.setAppointmentBindingSource;
            this.appointmentDataGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.appointmentDataGrid.Location = new System.Drawing.Point(73, 306);
            this.appointmentDataGrid.Name = "appointmentDataGrid";
            this.appointmentDataGrid.Size = new System.Drawing.Size(621, 151);
            this.appointmentDataGrid.TabIndex = 31;
            this.appointmentDataGrid.Visible = false;
            this.appointmentDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDataGrid_CellContentClick);
            // 
            // setAppointmentBindingSource
            // 
            this.setAppointmentBindingSource.DataSource = typeof(HospitalManagementSystem.SetAppointment);
            // 
            // cmbPatientName
            // 
            this.cmbPatientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatientName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatientName.FormattingEnabled = true;
            this.cmbPatientName.Location = new System.Drawing.Point(284, 74);
            this.cmbPatientName.MaxDropDownItems = 100;
            this.cmbPatientName.Name = "cmbPatientName";
            this.cmbPatientName.Size = new System.Drawing.Size(234, 23);
            this.cmbPatientName.Sorted = true;
            this.cmbPatientName.TabIndex = 27;
            // 
            // BtnView
            // 
            this.BtnView.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnView.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnView.FlatAppearance.BorderSize = 2;
            this.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnView.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnView.ForeColor = System.Drawing.Color.White;
            this.BtnView.Location = new System.Drawing.Point(413, 271);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(130, 29);
            this.BtnView.TabIndex = 26;
            this.BtnView.Text = "View Appointments";
            this.BtnView.UseVisualStyleBackColor = false;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(667, 10);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 29);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 14;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(142, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Doctor Name :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Red;
            this.Label5.Location = new System.Drawing.Point(305, 81);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(0, 18);
            this.Label5.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(216, -4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "SET-UP APPOINTMENT";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.Location = new System.Drawing.Point(268, 271);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(130, 29);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(142, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Patient Name :";
            // 
            // messagePanel
            // 
            this.messagePanel.BackColor = System.Drawing.Color.LimeGreen;
            this.messagePanel.Controls.Add(this.message);
            this.messagePanel.Location = new System.Drawing.Point(233, 12);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(467, 28);
            this.messagePanel.TabIndex = 37;
            this.messagePanel.Visible = false;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.White;
            this.message.Location = new System.Drawing.Point(147, 7);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 15);
            this.message.TabIndex = 0;
            this.message.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(142, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Date to visit :";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(284, 152);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(234, 23);
            this.datePicker.TabIndex = 39;
            this.datePicker.Value = new System.DateTime(2020, 7, 25, 0, 0, 0, 0);
            // 
            // appointmentIdDataGridViewTextBoxColumn
            // 
            this.appointmentIdDataGridViewTextBoxColumn.DataPropertyName = "AppointmentId";
            this.appointmentIdDataGridViewTextBoxColumn.HeaderText = "AppointmentId";
            this.appointmentIdDataGridViewTextBoxColumn.Name = "appointmentIdDataGridViewTextBoxColumn";
            this.appointmentIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            // 
            // dateToVisit
            // 
            this.dateToVisit.DataPropertyName = "AppointmentId";
            this.dateToVisit.HeaderText = "Date Of Visit";
            this.dateToVisit.Name = "dateToVisit";
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.Width = 80;
            // 
            // purposeOfVisitDataGridViewTextBoxColumn
            // 
            this.purposeOfVisitDataGridViewTextBoxColumn.DataPropertyName = "PurposeOfVisit";
            this.purposeOfVisitDataGridViewTextBoxColumn.HeaderText = "PurposeOfVisit";
            this.purposeOfVisitDataGridViewTextBoxColumn.Name = "purposeOfVisitDataGridViewTextBoxColumn";
            this.purposeOfVisitDataGridViewTextBoxColumn.Width = 160;
            // 
            // edit
            // 
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.HeaderText = "";
            this.edit.Name = "edit";
            this.edit.Text = "edit";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 65;
            // 
            // delete
            // 
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "delete";
            this.delete.ToolTipText = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 65;
            // 
            // SetUpAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 531);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetUpAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetUpAppointment";
            this.Load += new System.EventHandler(this.SetUpAppointment_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setAppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.DataGridView appointmentDataGrid;
        private System.Windows.Forms.ComboBox cmbPatientName;
        internal System.Windows.Forms.Button BtnView;
        internal System.Windows.Forms.PictureBox BtnClose;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button BtnSubmit;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDoctorName;
        private System.Windows.Forms.TextBox txtPurpose;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource setAppointmentBindingSource;
        private System.Windows.Forms.ComboBox cmbTime;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateToVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn purposeOfVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}