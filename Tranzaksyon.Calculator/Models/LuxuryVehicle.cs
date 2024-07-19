using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranzaksyon.Calculator.Enums;

namespace Tranzaksyon.Calculator.Models
{
    public class LuxuryVehicle : Vehicle
    {
        public override VehicleType VehicleType { get; protected set; } = VehicleType.Luxury;

        public override decimal BasicBuyerFeeMinimum { get; protected set; } = 25;
        public override decimal BasicBuyerFeeMaximum { get; protected set; } = 200;
        public override decimal SellersSpecialFeePercentage { get; protected set; } = 0.04m; //4%
    }
}
