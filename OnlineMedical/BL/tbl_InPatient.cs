using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalSystem.BL
{
    public class tbl_InPatient
    {
        public string InPatient_ID { get; set; }
        public string Lab_ID { get; set; }
        public string Patient_Status { get; set; }
        public System.DateTime Admission_Date { get; set; }
        public System.DateTime Discharge_Time { get; set; }
        public string Room_ID { get; set; }
        public string Room_Type { get; set; }
        public string Room_Status { get; set; }

    }
}