namespace CounterPicker.Web.Controllers
{
    using CounterPicker.Data.Models.Heroes;
    using Data.Models.Heroes.Champions;
    using Flurl.Http;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;

    public class HeroesController : Controller
    {
        // GET: Heroes
        public async Task<ActionResult> Index()
        {
            await GetAllHeroes();
            return View();
        }

        [HttpGet]
        public async Task<Champion> GetAllHeroes()
        {
            var responseString = await "https://global.api.pvp.net/api/lol/static-data/eune/v1.2/champion/105?champData=all&api_key=25cc7067-a2aa-49de-a49e-6e4055c2037c"
                .GetStringAsync();         
            var champion = JsonConvert.DeserializeObject<Hero>(responseString);
            return null;
        }
    }
}