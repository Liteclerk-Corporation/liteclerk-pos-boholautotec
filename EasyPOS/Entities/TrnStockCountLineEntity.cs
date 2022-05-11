﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class TrnStockCountLineEntity
    {
        public Int32 Id { get; set; }
        public Int32 StockCountId { get; set; }
        public Int32 ItemId { get; set; }
        public String ItemBarcode { get; set; }
        public String ItemDescription { get; set; }
        public Int32 UnitId { get; set; }
        public String Unit { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Cost { get; set; }
        public Decimal Amount { get; set; }
        public Decimal Price { get; set; }
        public Decimal SellingAmount { get; set; }
    }
}
