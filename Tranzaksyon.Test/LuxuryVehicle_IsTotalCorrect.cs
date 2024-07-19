using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranzaksyon.Calculator.Models;

namespace Tranzaksyon.Test
{
    [TestClass]
    public class LuxuryVehicle_IsTotalCorrect
    {
        [TestMethod]
        public void IsVehicle_BaseIs1800_Calculate()
        {
            LuxuryVehicle commonVehicle = new()
            {
                BasePrice = 1800.00m
            };

            commonVehicle.Calculate();

            Assert.AreEqual(1800.00m, commonVehicle.BasePrice);
            Assert.AreEqual(180.00m, commonVehicle.BasicBuyerFee);
            Assert.AreEqual(72.00m, commonVehicle.SellersSpecialFee);
            Assert.AreEqual(15.00m, commonVehicle.AssociationFee);
            Assert.AreEqual(100.00m, commonVehicle.StorageFee);
            Assert.AreEqual(2167.00m, commonVehicle.Total);
        }

        [TestMethod]
        public void IsVehicle_BaseIs1000000_Calculate()
        {
            LuxuryVehicle commonVehicle = new()
            {
                BasePrice = 1000000.00m
            };

            commonVehicle.Calculate();

            Assert.AreEqual(1000000.00m, commonVehicle.BasePrice);
            Assert.AreEqual(200.00m, commonVehicle.BasicBuyerFee);
            Assert.AreEqual(40000.00m, commonVehicle.SellersSpecialFee);
            Assert.AreEqual(20.00m, commonVehicle.AssociationFee);
            Assert.AreEqual(100.00m, commonVehicle.StorageFee);
            Assert.AreEqual(1040320.00m, commonVehicle.Total);
        }
    }
}
