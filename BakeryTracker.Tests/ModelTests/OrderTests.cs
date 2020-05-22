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
      Assert.AreEqual(0, result);
    }
  }
}