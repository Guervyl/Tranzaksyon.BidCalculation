using Microsoft.AspNetCore.Mvc;
using Tranzaksyon.BidCalculation.Api.Dtos;
using Tranzaksyon.Calculator.Models;

namespace Tranzaksyon.BidCalculation.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehiculeCalculatorController : ControllerBase
    {
        [HttpPost]
        public Vehicle Post([FromBody] VehiculeInputDto dto)
        {
            dto.Vehicule.Calculate();
            return dto.Vehicule;
        }
    }
}
