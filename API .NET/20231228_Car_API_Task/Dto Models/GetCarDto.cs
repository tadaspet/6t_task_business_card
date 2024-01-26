using _20231228_Car_API_Task.DataLayer.Models;

namespace _20231228_Car_API_Task.Dto_Models
{
    public class GetCarDto
    {
        public GetCarDto(Car model)
        {
            Id = model.Id;
            Brand = model.Brand;
            Model = model.Model;
            Manufactured = model.Manufactured;
            Color = model.Color;
            EngineSize = model.EngineSize;
        }

        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Manufactured { get; set; }
        public string Color { get; set; }
        public double EngineSize { get; set; }
    
    }
}
