using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetQuantityForProduct_WidthIs10_LengthIs10_CountProdIs20000000_TypeProdIs1_MaterialIs1() //количество деталей, которые нужно сделать - больше число
        {
            float width = 10;
            int length = 10, count = 20000000, productType = 1, materialType = 1;
            double execept = 2266000000;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(width, length, count, productType, materialType);
            Assert.AreEqual(execept, actual);
        }
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
        public void GetQuantityForProduct_WidthIs10and5_LengthIs20And52_CountProdIs20_TypeProdIs1_MaterialIs1() //ширина и длина - дробные числа
        {
            float width = (float)10.5, length = (float)20.52;
            int count = 20, productType = 1, materialType = 1;
            double execept = 4755;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(width, length, count, productType, materialType);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_WidthIsMin1_LengthIs20_CountProdIs20_TypeProdIs1_MaterialIs1() //ширина - отрицательное число
        {
            float width = -1;
            int length = 20, count = 20, productType = 1, materialType = 1;
            double execept = -1;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(width, length, count, productType, materialType);
            Assert.AreEqual(execept, actual);
        }
        [TestMethod]
        public void GetQuantityForProduct_WidthIs5_LengthIs3_CountProdIs100_TypeProdIs3_MaterialIs2() //все параметры целочисленные
        {
            int width = 5, length = 3, count = 100, productType = 3, materialType = 2;
            double execept = 12661;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(width, length, count, productType, materialType);
            Assert.AreEqual(execept, actual);
        }
        [TestMethod]
        public void GetQuantityForProduct_WidthIs100000_LengthIs150000_CountProdIs100_TypeProdIs2_MaterialIs2() //работа с очень большими числами
        {
            int width = 100000, length = 150000, count = 100, productType = 2, materialType = 2;
            double execept = 3754500000000;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(width, length, count, productType, materialType);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_WidthIs1000_LengthIs1500_CountProdIs100_TypeProdIs2_MaterialIs2() //работа с достаточно большими числами
        {
            int width = 1000, length = 1500, count = 100, productType = 2, materialType = 2;
            double execept = 375450000;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(width, length, count, productType, materialType);
            Assert.AreEqual(execept, actual);
        }
        [TestMethod]
        public void GetQuantityForProduct_WidthIs01_LengthIs01_CountProdIs1_TypeProdIs2_MaterialIs2() //работа с достаточно маленькими числами
        {
            float width = (float)0.1, length = (float)0.1;
            int count = 1, productType = 2, materialType = 2;
            double execept = 1;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(width, length, count, productType, materialType);
            Assert.AreEqual(execept, actual);
        }
        [TestMethod]
        public void GetQuantityForProduct_WidthIs00000000001_LengthIs00000000001_CountProdIs1_TypeProdIs2_MaterialIs2() //работа с очень маленькими числами
        {
            float width = (float)0.0000000001, length = (float)0.0000000001;
            int count = 1, productType = 2, materialType = 2;
            double execept = 1;
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
        public void GetQuantityForProduct_AllDataIs0() //все данные равны 0
        {
            int width = 0, length = 0, count = 0, productType = 0, materialType = 0;
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
