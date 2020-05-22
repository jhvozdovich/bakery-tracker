using BakeryTracker.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesOrderInstance_Object()
    {
      Order newOrder = new Order("Baguette", 2);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetType_ReturnsType_String()
    {
      string type = "Baguette";
      int quantity = 2;
      Order newOrder = new Order(type, quantity);
      string result = newOrder.Type;
      Assert.AreEqual(type, result);
    }

    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int()
    {
      string type = "Baguette";
      int quantity = 2;
      Order newOrder = new Order(type, quantity);
      int result = newOrder.Quantity;
      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
     public void GetId_ReturnsId_Int()
    {
      string type1 = "Baguette";
      int quantity1 = 2;
      string type2 = "Croissant";
      int quantity2 = 10;
      string type3 = "Brioche";
      int quantity3 = 4;
      Order newOrder1 = new Order(type1, quantity1);
      Order newOrder2 = new Order(type2, quantity2);
      Order newOrder3 = new Order(type3, quantity3);
      int result = newOrder3.Id;
      Assert.AreEqual(3, result);
    }
  }
}