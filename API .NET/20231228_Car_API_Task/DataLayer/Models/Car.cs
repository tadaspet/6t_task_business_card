namespace _20231228_Car_API_Task.DataLayer.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Manufactured { get; set; }
        public string Color { get; set; }
        public double EngineSize { get; set; }

        public Car(int id, string brand, string model, int manufactured, string color, double engineSize)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Manufactured = manufactured;
            Color = color;
            EngineSize = engineSize;
        }
        public Car()
        {
        }
    }
}
