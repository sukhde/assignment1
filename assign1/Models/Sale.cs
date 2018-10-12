using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace assign1.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int StoreLocationId { get; set; }
        public virtual StoreLocation StoreLocation { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public string MakeSaleEmployeeId { get; set; }
        public virtual Employee MakeSaleEmployee { get; set; }
        public string ApproveSaleEmployeeId { get; set; }
        public virtual Employee ApproveSaleEmployee { get; set; }

    }
}