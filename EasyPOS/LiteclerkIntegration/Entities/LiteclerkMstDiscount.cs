﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.LiteclerkIntegration.Entities
{
    class LiteclerkMstDiscount
    {
        public Int32 Id { get; set; }
        public String ManualCode { get; set; }
        public String Discount { get; set; }
        public Decimal DiscountRate { get; set; }
    }
}
