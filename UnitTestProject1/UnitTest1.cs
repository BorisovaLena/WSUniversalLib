using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetQuantityForProduct_WidthIs10and5_LengthIs20_CountProdIs20_TypeProdIs1_MaterialIs1() //ширина - дробное число
        {
            float width = (float)10.5;
            int length = 20, count = 20, productType = 1, materialType = 1;
            double execept = 4634;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(width, length, count, productType, materialType);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_WidthIs5_LengthIs3_CountProdIs2_TypeProdIs3_MaterialIs2() //все параметры целочисленные
        {
            int width = 5, length = 3, count = 100, productType = 3, materialType = 2;
            double execept = 12661;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(width, length, count, productType, materialType);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_WidthIsZero() // ширина = 0
        {
            int width = 0, length = 20, count = 20, productType = 1, materialType = 1;
            double execept = -1;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(width, length, count, productType, materialType);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_LengthIsZero() // длина = 0
        {
            int width = 10, length = 0, count = 20, productType = 1, materialType = 1;
            double execept = -1;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(width, length, count, productType, materialType);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_CountProdIsZero() // количество продукции, которое нужно сделать = 0
        {
            int width = 10, length = 20, count = 0, productType = 1, materialType = 1;
            double execept = -1;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(width, length, count, productType, materialType);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType() // несуществующий тип продукта 
        {
            int width = 10, length = 20, count = 20, productType = 10, materialType = 1;
            double execept = -1;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(width, length, count, productType, materialType);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentMaterial() // несуществующий тип материала
        {
            int width = 10, length = 20, count = 20, productType = 1, materialType = 10;
            double execept = -1;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(width, length, count, productType, materialType);
            Assert.AreEqual(execept, actual);
        }
    }
}
