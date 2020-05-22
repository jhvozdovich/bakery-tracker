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
      Vendor newVendor = new Vendor("Howl Jenkins Pendragon", "111 Howl's Moving Castle, Ingary");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Haku";
      string address = "Yubaba's Bathhouse";
      Vendor newVendor = new Vendor(name, address);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetAddress_ReturnsAddress_String()
    {
      string name = "Haku";
      string address = "Yubaba's Bathhouse";
      Vendor newVendor = new Vendor(name, address);
      string result = newVendor.Address;
      Assert.AreEqual(address, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      string name1 = "Howl Jenkins Pendragon";
      string address1 = "111 Howl's Moving Castle, Ingary";
      string name2 = "Haku";
      string address2 = "Yubaba's Bathhouse";
      Vendor newVendor1 = new Vendor(name1, address1);
      Vendor newVendor2 = new Vendor(name2, address2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2, newVendor1 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}