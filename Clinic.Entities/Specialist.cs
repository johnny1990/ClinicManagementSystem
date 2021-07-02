using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Entities
{ 
    public class Specialist
    {
        [Key]
        public int Specialist_Id { get; set; }
        public string Specialist_Name { get; set; }
        public string Special_Description { get; set; }
    }
}
