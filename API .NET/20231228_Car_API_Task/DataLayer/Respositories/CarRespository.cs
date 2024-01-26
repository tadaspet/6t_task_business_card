using _20231228_Car_API_Task.DataLayer.Database;
using _20231228_Car_API_Task.DataLayer.Models;
using _20231228_Car_API_Task.Dto_Models;

namespace _20231228_Car_API_Task.DataLayer.Respositories
{

    public class CarRespository : ICarRespository
    {
        private readonly List<Car> _database;
        public CarRespository()
        {
            _database = new CarDatabase().GetAll();
        }
        public IEnumerable<GetCarDto> GetAll()
        {
            var allCars = _database.Select(c => new GetCarDto(c));
            return allCars;
        }
        public IEnumerable<GetCarDto> GetByColor(string color)
        {
            var colorFilteredCars = _database.Where(c => string.Equals(c.Color, color, StringComparison.OrdinalIgnoreCase));
            var ConvertToDto = colorFilteredCars.Select(c => new GetCarDto(c));
            return ConvertToDto;
        }
        public long Insert(CreateUpdateCarDto newCar)
        {
            var newId = _database.Max(c => c.Id)+1;
            var newCarfromDto = new CreateUpdateCarDto().CreateModel(newCar);
            newCarfromDto.Id = newId;
            _database.Add(newCarfromDto);
            return newId;
        }
        public void Update(int id, CreateUpdateCarDto car)
        {
            var selectedCarIndex = _database.FindIndex(c => c.Id == id);
            var updatedCar = new CreateUpdateCarDto().UpdateCarModel(_database[selectedCarIndex], car);
        }
        public void Delete(int id)
        {
            var selectedCarIndex = _database.FindIndex(c => c.Id == id);
            _database.RemoveAt(selectedCarIndex);
        }

    }

    public interface ICarRespository
    {
        void Delete(int id);
        IEnumerable<GetCarDto> GetAll();
        IEnumerable<GetCarDto> GetByColor(string color);
        long Insert(CreateUpdateCarDto newCar);
        void Update(int id, CreateUpdateCarDto car);
    }
}
