using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranzaksyon.Calculator.Enums;

namespace Tranzaksyon.Calculator.Models
{
    public abstract class Vehicle
    {
        public abstract VehicleType VehicleType { get; protected set; }
        public decimal BasePrice { get; set; }
        public decimal BasicBuyerFee { get; protected set; }
        public decimal BasicBuyerFeePercentage { get; protected set; } = 0.10m;
        public abstract decimal BasicBuyerFeeMinimum { get; protected set; }
        public abstract decimal BasicBuyerFeeMaximum { get; protected set; }
        public decimal SellersSpecialFee { get; protected set; }
        public abstract decimal SellersSpecialFeePercentage { get; protected set; }
        public decimal AssociationFee { get; protected set; }
        public decimal StorageFee { get; protected set; } = 100;

        public decimal Total { get; protected set; }

        public decimal Calculate()
        {
            CalculateBasicBuyerFee();
            CalculateSellersSpecialFee();
            CalculateAssociationFee();

            return Total = BasePrice + BasicBuyerFee + SellersSpecialFee + AssociationFee + StorageFee;
        }

        protected void CalculateBasicBuyerFee()
        {
            decimal fee = BasePrice * BasicBuyerFeePercentage;

            BasicBuyerFee = Math.Min(Math.Max(fee, BasicBuyerFeeMinimum), BasicBuyerFeeMaximum);
        }

        protected void CalculateSellersSpecialFee()
        {
            SellersSpecialFee = BasePrice * SellersSpecialFeePercentage;
        }

        protected void CalculateAssociationFee()
        {
            if (BasePrice <= 500)
            {
                AssociationFee = 5;
            }
            else if (BasePrice <= 1000)
            {
                AssociationFee = 10;
            }
            else if (BasePrice <= 3000)
            {
                AssociationFee = 15;
            }
            else
            {
                AssociationFee = 20;
            }
        }
    }
}
