using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework_Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace homework_Exercise.Tests
{
    [TestClass()]
    public class ProductTests
    {
        private List<ProductModel> Products = new List<ProductModel>();

        [TestInitialize()]
        public void MyTestInitialize()
        {
            Products.Add(new ProductModel { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            Products.Add(new ProductModel { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            Products.Add(new ProductModel { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            Products.Add(new ProductModel { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            Products.Add(new ProductModel { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            Products.Add(new ProductModel { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            Products.Add(new ProductModel { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            Products.Add(new ProductModel { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            Products.Add(new ProductModel { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            Products.Add(new ProductModel { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            Products.Add(new ProductModel { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            Products.Clear();
        }

        [TestMethod()]
        public void GroupSumTest_GroupBy_3_Cost_Show_6_15_24_21()
        {
            //Arrange
            var expected = new List<int> { 6, 15, 24, 21 };
            //Act
            var actual = Product.GroupSum(Products, 3, "Cost");
            //Assert
            expected.ShouldBeEquivalentTo(actual);
        }

        [TestMethod()]
        public void GroupSumTest_GroupBy_4_Revenue_Show_50_66_60()
        {
            //Arrange
            var expected = new List<int> { 50, 66, 60 };
            //Act
            var actual = Product.GroupSum(Products, 4, "Revenue");
            //Assert
            expected.ShouldBeEquivalentTo(actual);
        }

        [TestMethod()]
        public void GroupSumTest_GroupBy_5_SellPrice_Show_115_140_31()
        {
            //Arrange
            var expected = new List<int> { 115, 140, 31 };
            //Act
            var actual = Product.GroupSum(Products, 5, "SellPrice");
            //Assert
            expected.ShouldBeEquivalentTo(actual);
        }

        [TestMethod()]
        public void GroupSumTest_GroupBy_99_Cost_Show_66()
        {
            //Arrange
            var expected = new List<int> { 66 };
            //Act
            var actual = Product.GroupSum(Products, 99, "Cost");
            //Assert
            expected.ShouldBeEquivalentTo(actual);
        }
    }
}