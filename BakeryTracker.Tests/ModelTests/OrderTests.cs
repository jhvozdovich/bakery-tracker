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

    [TestMethod]
    public void ClearAll_ClearsAllOrders_Int()
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
      int beforeClear = Order.GetAll().Count;
      Assert.AreEqual(3, beforeClear);
      Order.ClearAll();
      int result = Order.GetAll().Count;
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrders_OrderList()
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
      List<Order> newList = new List<Order> { newOrder1, newOrder2, newOrder3 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_FindSpecifiedOrder_Object()
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
      Order result = Order.Find(2);
      Assert.AreEqual(result, newOrder2);
    }
  }
}