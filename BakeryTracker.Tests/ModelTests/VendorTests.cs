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
      Assert.AreEqual(typeof(Vendor), 0.GetType());
    }
  }
}