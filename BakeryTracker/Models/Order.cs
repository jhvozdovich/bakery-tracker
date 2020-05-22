using System.Collections.Generic;

namespace BakeryTracker.Models
{
  public class Order
  {
    public string Type { get; set;}
    public int Quantity { get; set;}
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string type, int quantity)
    {
      Type = type;
      Quantity = quantity;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int orderId)
    {
      return _instances[orderId - 1];
    }
  }
}