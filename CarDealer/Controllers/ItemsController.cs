using Microsoft.AspNetCore.Mvc;
using CarDealer.Models;
using System.Collections.Generic;

namespace CarDealer.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
     List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpPost("/items")]
    public ActionResult Create(string model, int miles, int price)
    {
        Car myCar = new Car(model, miles, price);
        return RedirectToAction("Index");
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
        return View();
    }
}
}
