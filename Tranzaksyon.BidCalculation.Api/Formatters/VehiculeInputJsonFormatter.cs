using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Text;
using System.Text.Json;
using Tranzaksyon.BidCalculation.Api.Dtos;
using Tranzaksyon.Calculator.Models;

namespace Tranzaksyon.BidCalculation.Api.Formatters
{
    public class VehiculeInputJsonFormatter : TextInputFormatter
    {
        SystemTextJsonInputFormatter _formatter;

        public VehiculeInputJsonFormatter(ILogger<SystemTextJsonInputFormatter> logger)
        {
            _formatter = new SystemTextJsonInputFormatter(new JsonOptions(), logger);

            var mediaTypes = _formatter.SupportedMediaTypes.ToList();

            foreach (var mediType in mediaTypes)
            {
                SupportedMediaTypes.Add(mediType);
            }

            var encodings = _formatter.SupportedEncodings.ToList();

            foreach (var encoding in encodings)
            {
                SupportedEncodings.Add(encoding);
            }
        }

        protected override bool CanReadType(Type type)
        {
            return typeof(VehiculeInputDto).IsAssignableTo(type);
        }

        public override async Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
        {
            var result = await _formatter.ReadRequestBodyAsync(context);

            if (!result.HasError && result.IsModelSet)
            {
                try
                {
                    var dto = result.Model as VehiculeInputDto;
                    _ = dto.Vehicule;
                }
                catch (ArgumentException ex)
                {
                    context.ModelState.TryAddModelError("VehicleType", ex.Message);
                    return InputFormatterResult.Failure();
                }
            }

            return result;
        }

        public override Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context, Encoding encoding)
        {
            throw new NotImplementedException();
        }
    }
}
