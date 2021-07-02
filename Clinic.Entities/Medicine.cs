using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Entities
{
    public class Medicine
    {
        [Key]
        public int Medicine_Id { get; set; }
        public string Medicine_Code { get; set; }
        public string Medicine_Name { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTime> Mfg_Date { get; set; }
        public Nullable<System.DateTime> Exp_date { get; set; }
        public string Company_Name { get; set; }
        public string Batch_No { get; set; }
        public Nullable<decimal> Quantity { get; set; }
    }
}
