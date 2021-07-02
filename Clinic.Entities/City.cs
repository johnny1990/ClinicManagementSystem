using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Entities
{
    public class City
    {
        [Key]
        public int City_Id { get; set; }
        public string City_Name { get; set; }
        public string City_Description { get; set; }
        public Nullable<int> State_Id { get; set; }
    }
}
