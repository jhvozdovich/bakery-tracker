using BakeryTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BakeryTracker.Controllers
{
  public class OrderController: Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>{};
      Vendor vendor = Vendor.Find(vendorId);
      Order order = Order.Find(orderId);
      model.Add("vendor", vendor);
      model.Add("order", order);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders/deleteAll")]
    public ActionResult DeleteAll(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      vendor.Orders.Clear();
      return View();
    }

    [HttpPost("/vendors/delete/{vendorId}")]
    public ActionResult Destroy(int vendorId, int orderId)
    {
      Vendor.DeleteVendor(vendorId);
      return View();
    }
  }
}