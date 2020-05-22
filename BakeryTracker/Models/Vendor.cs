using System.Collections.Generic;

namespace BakeryTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Address { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> {};
    public List<Order> Orders { get; set; }

    public Vendor(string name, string address)
    {
      Name = name;
      Address = address;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int vendorId)
    {
      return _instances[vendorId - 1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}