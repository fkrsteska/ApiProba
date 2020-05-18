using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppWithApi.Models;
using AppWithApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AppWithApi.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonUstanoviService UstanovaService;
        public List <Records> Ustanovi { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonUstanoviService ustanoviService)
        {
            _logger = logger;
            UstanovaService = ustanoviService;           
        }
        public void OnGet()
        {
            // Ustanovi = UstanovaService.GetUstanovi();
        }
    }
}
