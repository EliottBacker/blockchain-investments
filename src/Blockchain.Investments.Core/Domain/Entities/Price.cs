using System;

namespace Blockchain.Investments.Core.Model
{
    public class Price : BaseEntity
    {
        public Security Security {get; set;}
        public DateTime Modified {get;set;}
        public string Source {get;set;}
        public PricingType Type {get;set;}
        public double Value {get;set;}
    }
    public enum PricingType 
    {
        Bid = 1,
        Ask = 2,
        Last = 3,
        NetAssetValue = 4
    }
}
