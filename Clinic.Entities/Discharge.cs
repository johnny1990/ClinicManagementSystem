using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Entities
{
    public class Discharge
    {
        [Key]
        public int Patient_Id { get; set; }
        public string Patient_Code { get; set; }
        public string Patient_Name { get; set; }
        public string F_H_Name { get; set; }
        public string Chief_Complain { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Doctor_Name { get; set; }
        public string Room_Name { get; set; }
        public string In_Out_Patient { get; set; }
        public Nullable<System.DateTime> Date_on_Admit { get; set; }
        public string time_of_Admit { get; set; }
        public Nullable<System.DateTime> Date_of_Discharge { get; set; }
        public string Time_of_Discharge { get; set; }
        public Nullable<int> Age { get; set; }
        public string Day_Stayed { get; set; }
        public Nullable<decimal> Advance { get; set; }
        public Nullable<decimal> Doctor_Charges { get; set; }
        public Nullable<decimal> Test_Charges { get; set; }
        public Nullable<decimal> Room_Charges { get; set; }
        public Nullable<decimal> Medicine_Charges { get; set; }
        public Nullable<decimal> Extra_Charges { get; set; }
        public Nullable<decimal> Total_Charges { get; set; }
        public string Patient_Condition { get; set; }
    }
}
