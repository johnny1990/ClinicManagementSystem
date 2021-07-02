using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Entities
{  
    public class State
    {
        [Key]
        public int State_Id { get; set; }
        public string State_Name { get; set; }
        public string State_Description { get; set; }
        public int Country_Id { get; set; }
    }
}
