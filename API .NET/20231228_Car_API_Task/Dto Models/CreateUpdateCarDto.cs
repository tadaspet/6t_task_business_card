using _20231228_Car_API_Task.DataLayer.Models;

namespace _20231228_Car_API_Task.Dto_Models
{
    public class CreateUpdateCarDto
    {
        public CreateUpdateCarDto()
        {
        }
        public CreateUpdateCarDto(Car model)
        {
            Brand = model.Brand;
            Model = model.Model;
            Manufactured = model.Manufactured;
            Color = model.Color;
            EngineSize = model.EngineSize;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Manufactured { get; set; }
        public string Color { get; set; }
        public double EngineSize { get; set; }

        public Car CreateModel(CreateUpdateCarDto newCar)
        {
            return new Car()
            {
                Brand = newCar.Brand,
                Model = newCar.Model,
                Manufactured = newCar.Manufactured,
                Color = newCar.Color,
                EngineSize = newCar.EngineSize,
            };
        }
        public Car UpdateCarModel(Car oldCar, CreateUpdateCarDto newCar)
        {
            oldCar.Brand = newCar.Brand;
            oldCar.Model = newCar.Model;
            oldCar.Manufactured = newCar.Manufactured;
            oldCar.Color = newCar.Color;
            oldCar.EngineSize = newCar.EngineSize;
            return oldCar;
        }
    }
}
