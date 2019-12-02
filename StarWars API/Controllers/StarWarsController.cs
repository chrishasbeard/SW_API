using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StarWars_API.Models;

namespace StarWars_API.Controllers
{
    public class StarWarsController : Controller
    {
        public readonly HttpClient _client;

        public StarWarsController(IHttpClientFactory client)
        {
            _client = client.CreateClient();
            _client.BaseAddress = new Uri("https://swapi.co/api");
            
        }

        public async Task<IActionResult> DisplayThing(string tag)
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> DisplayPlanet()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DisplayPlanet(string tag)
        {
            var response = await _client.GetAsync($"planet/:{tag}");
            var results = await response.Content.ReadAsStringAsync();

            HttpContext.Session.SetString("Planet", results);

            var planets = JsonConvert.DeserializeObject<PlanetRoot>(results);

            return View(planets);
        }

        [HttpGet]
        public async Task<IActionResult> DisplayPeople()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DisplayPeople(int tag)
        {
            var response = await _client.GetAsync($"/people/:{tag}/");
            var results = await response.Content.ReadAsStringAsync();

            HttpContext.Session.SetString("Persons", results);

            var people = JsonConvert.DeserializeObject<PeopleRoot>(results);

            return View(results); 
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}