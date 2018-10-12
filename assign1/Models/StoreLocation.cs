﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace assign1.Models
{
    public class StoreLocation
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public virtual ICollection<Sale> Sale { get; set; }
    }
}