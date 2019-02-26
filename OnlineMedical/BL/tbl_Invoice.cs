using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMedical.BL
{
    public class tbl_Invoice
    {
        public string Invoice_ID { get; set; }
        public string Patient_ID { get; set; }
        public int RN_Charge { get; set; }
        public int Doctor_Charge { get; set; }
        public int Prescription_Charge { get; set; }
        public int Lab_Charge { get; set; }
        public int Procedure_Charge { get; set; }
        public int No_of_days { get; set; }
        public string Provider_Group_No { get; set; }

        public virtual Patient Patient { get; set; }
    }
}