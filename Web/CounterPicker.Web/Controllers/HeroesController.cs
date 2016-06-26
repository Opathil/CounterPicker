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
        public Dictionary<string, int> HeroKeys { get; set; }

        public HeroesController()
        {
            this.HeroKeys = new Dictionary<string, int>();
        }

        public async Task<ActionResult> Index()
        {
            var champions = await GetAllHeroesPictures();
            return View(champions);
        }


        public async Task<Dictionary<string,int>> GetChampionKeys()
        {

            var championInfoAsString = await "https://global.api.pvp.net/api/lol/static-data/eune/v1.2/champion?api_key=25cc7067-a2aa-49de-a49e-6e4055c2037c"
                .GetStringAsync();

            var championInfo = JsonConvert.DeserializeObject<Champion>(championInfoAsString);

            foreach(var hero in championInfo.data)
            {
                HeroKeys.Add(hero.Value.key, hero.Value.id);
            }

            return HeroKeys;
        }

        [HttpGet]
        public async Task<List<Hero>> GetAllHeroesPictures()
        {
            var championImageAsString = await "https://global.api.pvp.net/api/lol/static-data/eune/v1.2/champion?champData=image&api_key=25cc7067-a2aa-49de-a49e-6e4055c2037c"
                .GetStringAsync();
            var championsImages = JsonConvert.DeserializeObject<Champion>(championImageAsString);

            List<Hero> champions = new List<Hero>();

            foreach (var champion in championsImages.data)
            {
                champions.Add(champion.Value);
            }           

            return champions;
        }

        [HttpGet]
        public async Task<ActionResult> Hero(string id)
        {
            await GetChampionKeys();

            var fullChampionInfoAsString = await ("https://global.api.pvp.net/api/lol/static-data/eune/v1.2/champion/" + HeroKeys[id] + "?champData=all&api_key=25cc7067-a2aa-49de-a49e-6e4055c2037c")
                .GetStringAsync();

            var fullChampionInfo = JsonConvert.DeserializeObject<Hero>(fullChampionInfoAsString);
            
            return View(fullChampionInfo);
        }
    }
}