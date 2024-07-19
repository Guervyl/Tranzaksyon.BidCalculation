using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranzaksyon.Calculator.Enums;
using Tranzaksyon.Calculator.Models;

namespace Tranzaksyon.Test
{
    [TestClass]
    public class CommonVehicle_IsTotalCorrect
    {
        [TestMethod]
        public void IsVehicle_BaseIs398_Calculate()
        {
            CommonVehicle commonVehicle = new()
            {
                BasePrice = 398
            };

            commonVehicle.Calculate();

            Assert.AreEqual(398, commonVehicle.BasePrice);
            Assert.AreEqual(39.80m, commonVehicle.BasicBuyerFee);
            Assert.AreEqual(7.96m, commonVehicle.SellersSpecialFee);
            Assert.AreEqual(5, commonVehicle.AssociationFee);
            Assert.AreEqual(100, commonVehicle.StorageFee);
            Assert.AreEqual(550.76m, commonVehicle.Total);
        }

        [TestMethod]
        public void IsVehicle_BaseIs501_Calculate()
        {
            CommonVehicle commonVehicle = new()
            {
                BasePrice = 501
            };

            commonVehicle.Calculate();

            Assert.AreEqual(501.00m, commonVehicle.BasePrice);
            Assert.AreEqual(50.00m, commonVehicle.BasicBuyerFee);
            Assert.AreEqual(10.02m, commonVehicle.SellersSpecialFee);
            Assert.AreEqual(10.00m, commonVehicle.AssociationFee);
            Assert.AreEqual(100.00m, commonVehicle.StorageFee);
            Assert.AreEqual(671.02m, commonVehicle.Total);
        }

        [TestMethod]
        public void IsVehicle_BaseIs57_Calculate()
        {
            CommonVehicle commonVehicle = new()
            {
                BasePrice = 57
            };

            commonVehicle.Calculate();

            Assert.AreEqual(57.00m, commonVehicle.BasePrice);
            Assert.AreEqual(10.00m, commonVehicle.BasicBuyerFee);
            Assert.AreEqual(1.14m, commonVehicle.SellersSpecialFee);
            Assert.AreEqual(5.00m, commonVehicle.AssociationFee);
            Assert.AreEqual(100.00m, commonVehicle.StorageFee);
            Assert.AreEqual(173.14m, commonVehicle.Total);
        }

        [TestMethod]
        public void IsVehicle_BaseIs1100_Calculate()
        {
            CommonVehicle commonVehicle = new()
            {
                BasePrice = 1100.00m
            };

            commonVehicle.Calculate();

            Assert.AreEqual(1100.00m, commonVehicle.BasePrice);
            Assert.AreEqual(50.00m, commonVehicle.BasicBuyerFee); 
            Assert.AreEqual(22.00m, commonVehicle.SellersSpecialFee);
            Assert.AreEqual(15.00m, commonVehicle.AssociationFee);
            Assert.AreEqual(100.00m, commonVehicle.StorageFee);
            Assert.AreEqual(1287.00m, commonVehicle.Total);
        }
    }
}
