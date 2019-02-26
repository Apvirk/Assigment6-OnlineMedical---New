using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalSystem.BL
{
    public class tbl_Doctor
    {
        public string Doctor_ID { get; set; }
        public string Doctor_Name { get; set; }
        public int Doctor_Phone { get; set; }
        public string Doctor_Department { get; set; }
        public string Doctor_Address { get; set; }
    }
}