using System;
using System.Collections.Generic;

namespace Dealership.Models {

  public class Car
  {
    private static List<Car> _instances = new List<Car> { };

    // private string _MakeModel;
    // private int _Price;
    // private int _Miles;

    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _instances.Add(this);
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

  public static List<Car> GetAll()
    {
      return _instances;
    }


  }

}