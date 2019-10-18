﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class MstCustomer
    {
        public Int32 Id { get; set; }
        public String Customer { get; set; }
        public String Address { get; set; }
        public String ContactPerson { get; set; }
        public String ContactNumber { get; set; }
        public String CreditLimit { get; set; }
        public Int32 TermId { get; set; }
        public String Term { get; set; }
        public String TIN { get; set; }
        public Boolean WithReward { get; set; }
        public String RewardNumber { get; set; }
        public Decimal RewardConversion { get; set; }
        public Decimal AvailableReward { get; set; }
        public Int32 AccountId { get; set; }
        public String Account { get; set; }
        public Int32 EntryUserId { get; set; }
        public String EntryUserName { get; set; }
        public String EntryDateTime { get; set; }
        public Int32 UpdateUserId { get; set; }
        public String UpdatedUserName { get; set; }
        public String UpdateDateTime { get; set; }
        public Boolean IsLocked { get; set; }
        public String DefaultPriceDescription { get; set; }
        public String CustomerCode { get; set; }
    }
}
