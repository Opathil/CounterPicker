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
            var champions = await GetAllHeroes();
            return View(champions);
        }

        [HttpGet]
        public async Task<List<Hero>> GetAllHeroes()
        {
            var championImageString = await "https://global.api.pvp.net/api/lol/static-data/eune/v1.2/champion?champData=image&api_key=25cc7067-a2aa-49de-a49e-6e4055c2037c"
                .GetStringAsync();        
            var championsImages = JsonConvert.DeserializeObject<Champion>(championImageString);

            List<Hero> champions = new List<Hero>();

            foreach(var champion in championsImages.data)
            {
                champions.Add(champion.Value);
            }

            return champions;
        }

        [HttpGet]
        public async Task<ActionResult> Hero(int championId)
        {
            var championFullInfoAsString = await ("https://global.api.pvp.net/api/lol/static-data/eune/v1.2/champion/" + championId + "?champData=all&api_key=25cc7067-a2aa-49de-a49e-6e4055c2037c")
                .GetStringAsync();

            var championFullInfo = JsonConvert.DeserializeObject<Hero>(championFullInfoAsString);

            return View(championFullInfo);
        }
    }
}