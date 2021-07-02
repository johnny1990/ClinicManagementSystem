using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Entities
{   
    public class Disease
    {
        [Key]
        public int Disease_Id { get; set; }
        public string Disease_Name { get; set; }
        public string Doctor_Code { get; set; }
    }
}
