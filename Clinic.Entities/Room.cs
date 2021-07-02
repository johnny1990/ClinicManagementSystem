using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Entities
{ 
    public class Room
    {
        [Key]
        public int Room_Id { get; set; }
        public string Room_Code { get; set; }
        public string Room_Name { get; set; }
        public string Description { get; set; }
        public decimal Charges { get; set; }
        public string Status { get; set; }
    }
}
