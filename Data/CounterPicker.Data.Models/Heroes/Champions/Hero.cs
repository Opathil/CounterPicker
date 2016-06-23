namespace CounterPicker.Data.Models.Heroes.Champions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Spells;
    public class Hero
    {
        public Hero()
        {
            this.tags = new List<string>();
            this.skins = new List<Skin>();
            this.recommended = new List<Recommended>();
            this.spells = new List<Spell>();
        }
        public int id { get; set; }

        public string key { get; set; }

        public string name { get; set; }

        public string title { get; set; }

        public HeroImage image { get; set; }

        public List<Skin> skins { get; set; }

        public string lore { get; set; }

        public string blurb { get; set; }

        public List<string> allytips { get; set; }

        public List<string> enemytips { get; set; }

        public List<string> tags { get; set; }

        public string partype { get; set; }

        public Info info { get; set; }

        public HeroStats stats { get; set; }

        public Passive passive { get; set; }

        public List<Recommended> recommended { get; set; }

        public List<Spell> spells { get; set; }
    }
}
