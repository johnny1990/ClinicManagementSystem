using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Entities
{
    
    public class DoctorCharges
    {
        [Key]
        public string Patient_Code { get; set; }
        public string Doctor_Code { get; set; }
        public System.DateTime Date { get; set; }
        public string Time { get; set; }
        public decimal Charge { get; set; }
        public string Specialist { get; set; }
    }
}
