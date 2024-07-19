using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranzaksyon.Calculator.Enums;

namespace Tranzaksyon.Calculator.Models
{
    public class CommonVehicle : Vehicle
    {
        public override VehicleType VehicleType { get; protected set; } = VehicleType.Common;
        public override decimal BasicBuyerFeeMinimum { get; protected set; } = 10;
        public override decimal BasicBuyerFeeMaximum { get; protected set; } = 50;
        public override decimal SellersSpecialFeePercentage { get; protected set; } = 0.02m; // 2%
    }
}
