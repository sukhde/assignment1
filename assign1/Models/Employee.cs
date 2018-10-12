using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace assign1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationNumber { get; set; }
        [InverseProperty("MakeSaleEmployee")]
        public virtual ICollection<Sale> MakeSaleEmployee { get; set; }
        [InverseProperty("ApproveSaleEmployee")]
        public virtual ICollection<Sale> ApproveSaleEmployee { get; set; }
    }
}

