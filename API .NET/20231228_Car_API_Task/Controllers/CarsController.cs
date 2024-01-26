using _20231228_Car_API_Task.DataLayer.Respositories;
using _20231228_Car_API_Task.Dto_Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _20231228_Car_API_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        public readonly ICarRespository _respository;

        public CarsController(ICarRespository respository)
        {
            _respository = respository;
        }

        [HttpGet]
        public IEnumerable<GetCarDto> GetAllCars()
        {
            return _respository.GetAll();
        }
        [HttpGet("FilterByColor")]
        public IEnumerable<GetCarDto> GetCarsByColor([FromQuery] string color)
        {
            return _respository.GetByColor(color);
        }
        [HttpPost]
        public long Post(CreateUpdateCarDto newCar)
        {
            return _respository.Insert(newCar);
        }
        [HttpPut]
        public void Put([FromQuery] int id, [FromBody] CreateUpdateCarDto car)
        {
            _respository.Update(id, car);
        }
        [HttpDelete]
        public void Delete([FromQuery] int id)
        {
            _respository.Delete(id);
        }
    }
}
