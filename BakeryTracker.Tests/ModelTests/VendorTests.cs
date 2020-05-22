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
  }
}