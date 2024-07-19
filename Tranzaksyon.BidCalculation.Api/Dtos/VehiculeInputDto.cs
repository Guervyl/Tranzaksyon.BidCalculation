using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tranzaksyon.Calculator.Enums;
using Tranzaksyon.Calculator.Models;
using Tranzaksyon.Calculator.Transformers;

namespace Tranzaksyon.BidCalculation.Api.Dtos
{
    public class VehiculeInputDto
    {
        [Required]
        [EnumDataType(typeof(VehicleType))]
        public VehicleType VehicleType { get; set; }

        [Required]
        [Range(1, double.MaxValue)]
        public decimal BasePrice { get; set; }

        private Vehicle _vehicle;

        [JsonIgnore]
        public Vehicle Vehicule
        {
            get
            {
                if (_vehicle == null)
                {
                    _vehicle = VehiculeTransformer.Transform(VehicleType, BasePrice);
                }

                return _vehicle;
            }
        }
    }
}
