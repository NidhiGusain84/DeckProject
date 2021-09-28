using DeckOfCards.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DeckOfCards.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            string domain = "https://deckofcardsapi.com";
            string path = "/api/deck/new";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(domain);
            var connection = await client.GetAsync(path);// Async means our function will pause and wait until GetAsync finishes. 
            //Then come back and pick up where we left off.
            DeckResponse result = await connection.Content.ReadAsAsync<DeckResponse>();

            return View(result);
        }

     

        public async Task<IActionResult> DrawCard(string deckId)
        {
            string domain = "https://deckofcardsapi.com";
            string path = $"/api/deck/{deckId}/draw/?count=5";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(domain);
            
            var connection = await client.GetAsync(path);// Async means our function will pause and wait until GetAsync finishes. 
            //Then come back and pick up where we left off.
           
            DrawCardResponse result = await connection.Content.ReadAsAsync<DrawCardResponse>();

            return View(result);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
