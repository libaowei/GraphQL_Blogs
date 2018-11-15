﻿using chapter1.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chapter1
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public string Barcode { get; set; }

        public string Title { get; set; }

        public decimal SellingPrice { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
