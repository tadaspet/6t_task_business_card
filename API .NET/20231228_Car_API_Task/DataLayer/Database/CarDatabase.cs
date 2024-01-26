using _20231228_Car_API_Task.DataLayer.Models;
using System.ComponentModel;
using System.Security.Claims;

namespace _20231228_Car_API_Task.DataLayer.Database
{
    public class CarDatabase
    {
        private List<Car> carList = new List<Car>
        {
            new Car(1,"Toyota", "Corolla", 2022, "White", 1.8),
            new Car(2, "Honda", "Civic", 2021, "Black", 2.0),
            new Car(3, "Ford", "Mustang", 2020, "Red", 5.0),
            new Car(4, "Chevrolet", "Camaro", 2019, "Blue", 6.2),
            new Car(5, "Nissan", "Altima", 2018, "Silver", 2.5),
            new Car(6, "BMW", "3 Series", 2017, "Gray", 2.0),
            new Car(7, "Mercedes-Benz", "C-Class", 2016, "Black", 2.0),
            new Car(8, "Audi", "A4", 2015, "White", 2.0),
            new Car(9, "Volkswagen", "Jetta", 2014, "Blue", 2.0),
            new Car(10, "Hyundai", "Sonata", 2013, "Silver", 2.4),
        };
        public List<Car> GetAll()
        {
            return carList;
        }
    }
}
