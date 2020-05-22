using BakeryTracker.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;


namespace BakeryTracker.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreateVendorInstance_Object()
    {
      Vendor newVendor = new Vendor("Howl Jenkins Pendragon", "111 Howl's Moving Castle, Ingary", "A castle that moves, good luck with the delivery!");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Haku";
      string address = "Yubaba's Bathhouse";
      string description = "A nice vacation spot, but don't sign any contracts!";
      Vendor newVendor = new Vendor(name, address, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetAddress_ReturnsAddress_String()
    {
      string name = "Haku";
      string address = "Yubaba's Bathhouse";
      string description = "A nice vacation spot, but don't sign any contracts!";
      Vendor newVendor = new Vendor(name, address, description);
      string result = newVendor.Address;
      Assert.AreEqual(address, result);
    }

    [TestMethod]
     public void GetId_ReturnsId_Int()
    {
      string name1 = "Howl Jenkins Pendragon";
      string address1 = "111 Howl's Moving Castle, Ingary";
      string description1 = "A castle that moves, good luck with the delivery!";
      string name2 = "Haku";
      string address2 = "Yubaba's Bathhouse";
      string description2 = "A nice vacation spot, but don't sign any contracts!";
      Vendor newVendor1 = new Vendor(name1, address1, description1);
      Vendor newVendor2 = new Vendor(name2, address2, description2);
      int result = newVendor2.Id;
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      string name1 = "Howl Jenkins Pendragon";
      string address1 = "111 Howl's Moving Castle, Ingary";
      string description1 = "A castle that moves, good luck with the delivery!";
      string name2 = "Haku";
      string address2 = "Yubaba's Bathhouse";
      string description2 = "A nice vacation spot, but don't sign any contracts!";
      Vendor newVendor1 = new Vendor(name1, address1, description1);
      Vendor newVendor2 = new Vendor(name2, address2, description2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ClearAll_ClearsAllVendors_Int()
    {
      string name1 = "Howl Jenkins Pendragon";
      string address1 = "111 Howl's Moving Castle, Ingary";
      string description1 = "A castle that moves, good luck with the delivery!";
      string name2 = "Haku";
      string address2 = "Yubaba's Bathhouse";
      string description2 = "A nice vacation spot, but don't sign any contracts!";
      Vendor newVendor1 = new Vendor(name1, address1, description1);
      Vendor newVendor2 = new Vendor(name2, address2, description2);
      int beforeClear = Vendor.GetAll().Count;
      Assert.AreEqual(2, beforeClear);
      Vendor.ClearAll();
      int result = Vendor.GetAll().Count;
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Find_FindSpecifiedVendor_Object()
    {
      string name1 = "Howl Jenkins Pendragon";
      string address1 = "111 Howl's Moving Castle, Ingary";
      string description1 = "A castle that moves, good luck with the delivery!";
      string name2 = "Haku";
      string address2 = "Yubaba's Bathhouse";
      string description2 = "A nice vacation spot, but don't sign any contracts!";
      Vendor newVendor1 = new Vendor(name1, address1, description1);
      Vendor newVendor2 = new Vendor(name2, address2, description2);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(result, newVendor2);
    }

    [TestMethod]
    public void AddOrder_UpdateOrderListWithNewOrder_ObjectList()
    {
      string name = "Howl Jenkins Pendragon";
      string address = "111 Howl's Moving Castle, Ingary";
      string description = "A castle that moves, good luck with the delivery!";
      Vendor newVendor = new Vendor(name, address, description);
      string type1 = "Baguette";
      int quantity1 = 2;
      string type2 = "Croissant";
      int quantity2 = 10;
      string type3 = "Brioche";
      int quantity3 = 4;
      Order newOrder1 = new Order(type1, quantity1);
      Order newOrder2 = new Order(type2, quantity2);
      Order newOrder3 = new Order(type3, quantity3);
      newVendor.AddOrder(newOrder1);
      newVendor.AddOrder(newOrder2);
      newVendor.AddOrder(newOrder3);
      List<Order> newOrders = new List<Order> { newOrder1, newOrder2, newOrder3};
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(result, newOrders);
    }
  }
}