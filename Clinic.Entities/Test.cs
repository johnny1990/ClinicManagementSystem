using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Entities
{  
    public class Test
    {
        [Key]
        public int Test_Id { get; set; }
        public string Test_Code { get; set; }
        public string Test_Name { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Charges { get; set; }
    }
}
