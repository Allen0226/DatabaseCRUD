using System;
using System.Collections.Generic;

namespace DatabaseCRUD.Models
{
    public partial class MyProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public DateTime LaunchDate { get; set; }
    }
}
