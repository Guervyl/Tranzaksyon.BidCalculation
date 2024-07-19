using Microsoft.AspNetCore.Mvc;
using Tranzaksyon.Calculator.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tranzaksyon.BidCalculation.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehiculeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Vehicle> Get()
        {
            return new Vehicle[] {
                new CommonVehicle{
                    BasePrice = 0,
                }, new LuxuryVehicle{
                    BasePrice = 0
                }
            };
        }
    }
}
