using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AppWithApi.Helper;
using AppWithApi.Models;
using AppWithApi.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AppWithApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public HomeController(JsonUstanoviService ustanovaService)
        {
            this.UstanoviService = ustanovaService;
        }
        public JsonUstanoviService UstanoviService { get; }

        [HttpGet]
        public async Task<IActionResult> Get()        
        {           
            var result = await UstanoviService.GetUstanovi();
            return Ok(result);
        }
        
        /*
        UstanovaAPI _api = new UstanovaAPI();
        public async Task <IActionResult> Index()
        {
            List<UstanovaData> ustanovi = new List<UstanovaData>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/ustanovi");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                ustanovi = JsonConvert.DeserializeObject<List<UstanovaData>>(results);
            }
            return View(ustanovi);
        }
        */
    }
}