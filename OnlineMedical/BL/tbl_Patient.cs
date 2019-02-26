using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalSystem.BL
{
    public class tbl_Patient
    {
        public string Patient_ID { get; set; }
        public string Patient_Name { get; set; }
        public System.DateTime Patient_Date_of_Birth { get; set; }
        public string Patient_Gender { get; set; }
        public string Patient_Address { get; set; }
        public int Patient_Phone { get; set; }

    }
}