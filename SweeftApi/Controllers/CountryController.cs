using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SweeftApiAbstractions.Services;

namespace SweeftApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : Controller
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }


        [HttpGet("countries")]
        public async Task<ActionResult> generateCountries()
        {
            try
            {
                _countryService.GenerateCountryDataFiles();
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest();
            }

          
        }
    }
}
