using Microsoft.VisualStudio.TestTools.UnitTesting;
using LR_3;
using System;

namespace LR_3_TestProject
{
    [TestClass]
    public class AdditionalTests
    {
        [TestMethod]
        public void TestMaterialWithZeroPrice()
        {
            // Arrange
            var material = new Material { PricePerUnit = 0m };

            // Assert
            Assert.AreEqual(0m, material.PricePerUnit); // Добавлено "m" после 0
        }

        [TestMethod]
        public void TestPartWithMultipleMaterials()
        {
            // Arrange
            var part = new Part { Name = "Сложная деталь" };
            var material1 = new Material { Name = "Материал 1" };
            var material2 = new Material { Name = "Материал 2" };

            // Act
            part.RequiredMaterials.Add(material1);
            part.RequiredMaterials.Add(material2);

            // Assert
            Assert.AreEqual(2, part.RequiredMaterials.Count);
            Assert.AreEqual("Материал 1", part.RequiredMaterials[0].Name);
            Assert.AreEqual("Материал 2", part.RequiredMaterials[1].Name);
        }

        [TestMethod]
        public void TestOrderItemWithZeroQuantity()
        {
            // Arrange
            var orderItem = new OrderItem { Quantity = 0 };
            orderItem.Materials.Add(new Material { PricePerUnit = 100m });

            // Act
            orderItem.CalculateTotalCost();

            // Assert
            Assert.AreEqual(0m, orderItem.TotalCost);
        }
    }
}