using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Entities
{ 
    public class Country
    {
        [Key]
        public int Country_Id { get; set; }
        public string Country_Name { get; set; }
        public string Country_Desc { get; set; }
    }
}
