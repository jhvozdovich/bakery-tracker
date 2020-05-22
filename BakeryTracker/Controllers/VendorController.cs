using BakeryTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BakeryTracker.Controllers
{
  public class VendorController: Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string address, string description)
    {
      Vendor newVendor = new Vendor(name, address, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{vendorid}")]
    public ActionResult Show(int vendorId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor vendor = Vendor.Find(vendorId);
      List<Order> vendorOrders = vendor.Orders;
      model.Add("vendor", vendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorid}/orders")]
    public ActionResult Create(int vendorId, string type, int quantity, string description, double price, string dueDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor vendor = Vendor.Find(vendorId);
      Order newOrder = new Order(type, quantity, description, price, dueDate);
      vendor.AddOrder(newOrder);
      List<Order> vendorOrders = vendor.Orders;
      model.Add("vendor", vendor);
      model.Add("orders", vendorOrders);
      return View("Show", model);
    }

    [HttpPost("/vendors/deleteAll")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return View();
    }

    // [HttpPost("/vendors/delete/{vendorId}")]
    // public ActionResult DeleteOne(int vendorId)
    // {
    //   Vendor.DeleteVendor(Id);
    //   return View();
    // }

  }
}