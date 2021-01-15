
namespace HospitalManagementSystem.Views
{
    partial class DoctorsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsPage));
            this.messagePanel = new System.Windows.Forms.Panel();
            this.message = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.addPatientDataGrid = new System.Windows.Forms.DataGridView();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.BtnView = new System.Windows.Forms.Button();
            this.CloseForm = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.messagePanel.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPatientDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // messagePanel
            // 
            this.messagePanel.Controls.Add(this.message);
            this.messagePanel.Location = new System.Drawing.Point(243, 35);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(449, 32);
            this.messagePanel.TabIndex = 34;
            this.messagePanel.Visible = false;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.White;
            this.message.Location = new System.Drawing.Point(116, 7);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(40, 15);
            this.message.TabIndex = 0;
            this.message.Text = "label9";
            this.message.Visible = false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Panel1.Controls.Add(this.label7);
            this.Panel1.Controls.Add(this.phoneNumber);
            this.Panel1.Controls.Add(this.addPatientDataGrid);
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Controls.Add(this.cmbMaritalStatus);
            this.Panel1.Controls.Add(this.BtnView);
            this.Panel1.Controls.Add(this.CloseForm);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.lastName);
            this.Panel1.Controls.Add(this.firstName);
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.BtnSave);
            this.Panel1.Controls.Add(this.label6);
            this.Panel1.Location = new System.Drawing.Point(80, 52);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(720, 443);
            this.Panel1.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.phoneNumber.Location = new System.Drawing.Point(261, 211);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(235, 23);
            this.phoneNumber.TabIndex = 31;
            // 
            // addPatientDataGrid
            // 
            this.addPatientDataGrid.AllowUserToAddRows = false;
            this.addPatientDataGrid.AllowUserToOrderColumns = true;
            this.addPatientDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.addPatientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addPatientDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit,
            this.delete});
            this.addPatientDataGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.addPatientDataGrid.Location = new System.Drawing.Point(54, 302);
            this.addPatientDataGrid.Name = "addPatientDataGrid";
            this.addPatientDataGrid.Size = new System.Drawing.Size(621, 129);
            this.addPatientDataGrid.TabIndex = 30;
            this.addPatientDataGrid.Visible = false;
            // 
            // edit
            // 
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.HeaderText = "";
            this.edit.Name = "edit";
            this.edit.Text = "edit";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 69;
            // 
            // delete
            // 
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.Text = "delete";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(133, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Phone No. :";
            // 
            // cmbMaritalStatus
            // 
            this.cmbMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaritalStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaritalStatus.FormattingEnabled = true;
            this.cmbMaritalStatus.Items.AddRange(new object[] {
            "Married",
            "Others",
            "Single"});
            this.cmbMaritalStatus.Location = new System.Drawing.Point(261, 174);
            this.cmbMaritalStatus.MaxDropDownItems = 100;
            this.cmbMaritalStatus.Name = "cmbMaritalStatus";
            this.cmbMaritalStatus.Size = new System.Drawing.Size(234, 23);
            this.cmbMaritalStatus.Sorted = true;
            this.cmbMaritalStatus.TabIndex = 27;
            // 
            // BtnView
            // 
            this.BtnView.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnView.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnView.FlatAppearance.BorderSize = 2;
            this.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnView.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnView.ForeColor = System.Drawing.Color.White;
            this.BtnView.Location = new System.Drawing.Point(390, 244);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(105, 29);
            this.BtnView.TabIndex = 26;
            this.BtnView.Text = "View Patients";
            this.BtnView.UseVisualStyleBackColor = false;
            // 
            // CloseForm
            // 
            this.CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseForm.Image = ((System.Drawing.Image)(resources.GetObject("CloseForm.Image")));
            this.CloseForm.Location = new System.Drawing.Point(645, 23);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(30, 29);
            this.CloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseForm.TabIndex = 14;
            this.CloseForm.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(133, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Marital Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(133, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Last Name :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Red;
            this.Label5.Location = new System.Drawing.Point(283, 68);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(0, 18);
            this.Label5.TabIndex = 23;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lastName.Location = new System.Drawing.Point(261, 136);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(235, 23);
            this.lastName.TabIndex = 21;
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.firstName.Location = new System.Drawing.Point(261, 93);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(235, 23);
            this.firstName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(279, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "ADD DOCTOR";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(260, 244);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(105, 29);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(133, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "First Name :";
            // 
            // DoctorsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 531);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorsPage";
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPatientDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Label message;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.DataGridView addPatientDataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMaritalStatus;
        internal System.Windows.Forms.Button BtnView;
        internal System.Windows.Forms.PictureBox CloseForm;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox lastName;
        internal System.Windows.Forms.TextBox firstName;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Label label6;
    }
}