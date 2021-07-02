
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Entities
{
    public class RoomCharges
    {
        [Key]
        public string Patient_Code { get; set; }
        public string Room_Code { get; set; }
        public DateTime Date_on_Room_Given { get; set; }
        public string Time_of_Room_Given { get; set; }
        public decimal RoomCharge { get; set; }
    }
}
