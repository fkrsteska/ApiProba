using AppWithApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppWithApi.Services
{
    public class JsonUstanoviService
    {
        public JsonUstanoviService(IWebHostEnvironment webHostEnviorment)
        {
            webHostEnviorment = webHostEnviorment;
        }

        public IWebHostEnvironment WebHostEnviorment { get; }
       
      
       
        public async Task<UstanovaModel> GetUstanovi()
        {
            using (var client=new HttpClient())
            {
                //client.BaseAddress = new Uri("http://data.gov.mk");
                //var response = await client.GetAsync($"/api/3/action/datastore_search?q=Аптеки&resource_id=505db453-4de2-4761-8a81-2800f7820b06");
                var url = new Uri($"http://data.gov.mk/api/3/action/datastore_search?q=Аптеки&resource_id=505db453-4de2-4761-8a81-2800f7820b06&limit=2");
                var respnse = await client.GetAsync(url);
                string json;
                using(var content = respnse.Content)
                {
                    json = await content.ReadAsStringAsync();
                }

                return JsonConvert.DeserializeObject<UstanovaModel>(json);
                    /*response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    var result= JsonConvert.DeserializeObject<UstanovaModel>(stringResult);
                return result;*/
               
            }
        }


    }
}
