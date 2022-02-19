using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class RepSalesReportPerMonthSummaryReportEntity
    {
        public Int32 Year { get; set; }
        public Decimal JanuaryAmount { get; set; }
        public Decimal FebruaryAmount { get; set; }
        public Decimal MarchAmount { get; set; }
        public Decimal AprilAmount { get; set; }
        public Decimal MayAmount { get; set; }
        public Decimal JuneAmount { get; set; }
        public Decimal JulyAmount { get; set; }
        public Decimal AugustAmount { get; set; }
        public Decimal SeptemberAmount { get; set; }
        public Decimal OctoberAmount { get; set; }
        public Decimal NovemberAmount { get; set; }
        public Decimal DecemberAmount { get; set; }
    }
}
