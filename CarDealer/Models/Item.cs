using System.Collections.Generic;

namespace CarDealer.Models
{
    public class Car
    {
        public string Model { get; set; }
        public int Miles { get; set; }
        public int Price { get; set; }
        private static List<Car> _cars = new List<Car> {};

    public Car (string model, int miles, int price)
        {
            Model = model;
            Miles = miles;
            Price = price;
            _cars.Add(this);
        }

    public static List<Car> GetAll()
        {
            return _cars;
        }
    }
}