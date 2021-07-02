using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Entities
{
    public class Patient
    {
        [Key]
        public int Patient_Id { get; set; }
        public string Patient_Code { get; set; }
        public string Patient_Name { get; set; }
        public string F_H_Name { get; set; }
        public string Complaint { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public Nullable<int> Age { get; set; }
        public string I_O_Patient { get; set; }
        public string Doctor_Code { get; set; }
        public Nullable<System.DateTime> Date_of_Admit { get; set; }
        public string Time_Admit { get; set; }
        public string Test_Code { get; set; }
        public string Room_Code { get; set; }
        public Nullable<decimal> Advance { get; set; }
        public string Condition { get; set; }
        public string Status { get; set; }
    }
}
