using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SweeftApiAbstractions.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SweeftApiAbstractions.Services
{
    public class CountryService: ICountryService
    { 
        private readonly HttpClient _httpClient;

        public CountryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<int>  GenerateCountryDataFiles()
        {
            try
            {
               
                HttpResponseMessage response = await _httpClient.GetAsync(_httpClient.BaseAddress);

                
                if (response.IsSuccessStatusCode)
                {
                   
                    string json = await response.Content.ReadAsStringAsync();

                    var countries = JsonSerializer.Deserialize<List<Country>>(json);

                    // Get the wwwroot path
                    string wwwrootPath = Path.Combine("~./wwwroot", "CountryData");

                    // Create the directory if it doesn't exist
                    Directory.CreateDirectory(wwwrootPath);

                    // Generate a text file for each country in the wwwroot directory
                    foreach (var country in countries)
                    {
                        string fileName = $"{country.name.common}.txt";
                        string filePath = Path.Combine(wwwrootPath, fileName);
                        string fileContent = $"Name: {country.name.common}\nPopulation: {country.population}\nregion: {country.region}";

                        File.WriteAllText(filePath, fileContent);
                    }

                    return StatusCodes.Status200OK;
                }
                else
                {
                    return StatusCodes.Status400BadRequest;
                }
            }
            catch (Exception ex)
            {
                return StatusCodes.Status400BadRequest;
            }


        }
    }
}
