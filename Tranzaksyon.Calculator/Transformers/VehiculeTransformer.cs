using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranzaksyon.Calculator.Enums;
using Tranzaksyon.Calculator.Models;

namespace Tranzaksyon.Calculator.Transformers
{
    public static class VehiculeTransformer
    {
        public static Vehicle Transform(VehicleType type, decimal basePrice)
        {
            if (type == Calculator.Enums.VehicleType.Common)
            {
                return new CommonVehicle
                {
                    BasePrice = basePrice,
                };
            }

            if (type == Calculator.Enums.VehicleType.Luxury)
            {
                return new LuxuryVehicle
                {
                    BasePrice = basePrice,
                };
            };

            throw new ArgumentException("Vehicule type not supported.");
        }
    }
}
