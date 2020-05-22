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
  }
}