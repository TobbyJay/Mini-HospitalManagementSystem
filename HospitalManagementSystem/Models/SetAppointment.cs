using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    class SetAppointment
    {
        public int AppointmentId { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string DateToVisit { get; set; }
        public string Time { get; set; }
        public string PurposeOfVisit { get; set; }
    }   
}
