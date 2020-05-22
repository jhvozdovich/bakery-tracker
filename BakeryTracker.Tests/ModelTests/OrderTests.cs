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
      Order newOrder = new Order("Baguette", 2, "delicous crust", 9, "November 8");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetType_ReturnsType_String()
    {
      string type = "Baguette";
      int quantity = 2;
      string description = "delicious crust";
      double price = 9;
      string dueDate = "November 8";
      Order newOrder = new Order(type, quantity, description, price, dueDate);
      string result = newOrder.Type;
      Assert.AreEqual(type, result);
    }

    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int()
    {
      string type = "Baguette";
      int quantity = 2;
      string description = "delicious crust";
      double price = 9;
      string dueDate = "November 8";
      Order newOrder = new Order(type, quantity, description, price, dueDate);
      int result = newOrder.Quantity;
      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string type = "Baguette";
      int quantity = 2;
      string description = "delicious crust";
      double price = 9;
      string dueDate = "November 8";
      Order newOrder = new Order(type, quantity, description, price, dueDate);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
     public void GetId_ReturnsId_Int()
    {
      string type1 = "Baguette";
      int quantity1 = 2;
      string description1 = "delicious crust";
      double price1 = 9;
      string dueDate1 = "November 8";
      string type2 = "Croissant";
      int quantity2 = 10;
      string description2 = "soft and flakey";
      double price2 = 3;
      string dueDate2 = "November 11";
      string type3 = "Brioche";
      int quantity3 = 4;
      string description3 = "like a little cloud";
      double price3 = 4;
      string dueDate3 = "November 10";
      Order newOrder1 = new Order(type1, quantity1, description1, price1, dueDate1);
      Order newOrder2 = new Order(type2, quantity2, description2, price2, dueDate2);
      Order newOrder3 = new Order(type3, quantity3, description3, price3, dueDate3);
      int result = newOrder3.Id;
      Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void ClearAll_ClearsAllOrders_Int()
    {
      string type1 = "Baguette";
      int quantity1 = 2;
      string description1 = "delicious crust";
      double price1 = 9;
      string dueDate1 = "November 8";
      string type2 = "Croissant";
      int quantity2 = 10;
      string description2 = "soft and flakey";
      double price2 = 3;
      string dueDate2 = "November 11";
      string type3 = "Brioche";
      int quantity3 = 4;
      string description3 = "like a little cloud";
      double price3 = 4;
      string dueDate3 = "November 10";
      Order newOrder1 = new Order(type1, quantity1, description1, price1, dueDate1);
      Order newOrder2 = new Order(type2, quantity2, description2, price2, dueDate2);
      Order newOrder3 = new Order(type3, quantity3, description3, price3, dueDate3);
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
      string description1 = "delicious crust";
      double price1 = 9;
      string dueDate1 = "November 8";
      string type2 = "Croissant";
      int quantity2 = 10;
      string description2 = "soft and flakey";
      double price2 = 3;
      string dueDate2 = "November 11";
      string type3 = "Brioche";
      int quantity3 = 4;
      string description3 = "like a little cloud";
      double price3 = 4;
      string dueDate3 = "November 10";
      Order newOrder1 = new Order(type1, quantity1, description1, price1, dueDate1);
      Order newOrder2 = new Order(type2, quantity2, description2, price2, dueDate2);
      Order newOrder3 = new Order(type3, quantity3, description3, price3, dueDate3);
      List<Order> newList = new List<Order> { newOrder1, newOrder2, newOrder3 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_FindSpecifiedOrder_Object()
    {
      string type1 = "Baguette";
      int quantity1 = 2;
      string description1 = "delicious crust";
      double price1 = 9;
      string dueDate1 = "November 8";
      string type2 = "Croissant";
      int quantity2 = 10;
      string description2 = "soft and flakey";
      double price2 = 3;
      string dueDate2 = "November 11";
      string type3 = "Brioche";
      int quantity3 = 4;
      string description3 = "like a little cloud";
      double price3 = 4;
      string dueDate3 = "November 10";
      Order newOrder1 = new Order(type1, quantity1, description1, price1, dueDate1);
      Order newOrder2 = new Order(type2, quantity2, description2, price2, dueDate2);
      Order newOrder3 = new Order(type3, quantity3, description3, price3, dueDate3);
      Order result = Order.Find(2);
      Assert.AreEqual(result, newOrder2);
    }
  }
}