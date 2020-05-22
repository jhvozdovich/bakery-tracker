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
    public ActionResult Create(string name, string address)
    {
      Vendor newVendor = new Vendor(name, address);
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
    public ActionResult Create(int vendorId, string type, int quantity)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor vendor = Vendor.Find(vendorId);
      Order newOrder = new Order(type, quantity);
      vendor.AddOrder(newOrder);
      List<Order> vendorOrders = vendor.Orders;
      model.Add("vendor", vendor);
      model.Add("orders", vendorOrders);
      return View("Show", model);
    }
  }
}