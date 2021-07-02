using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Entities
{    
    public class SpecialVisitDoctor
    {
        [Key]
        public int Doctor_Id { get; set; }
        public string Doctor_Code { get; set; }
        public string Doctor_Name { get; set; }
        public Nullable<int> Specialist_Id { get; set; }
        public Nullable<decimal> Charges { get; set; }
        public string Description { get; set; }
    }
}
