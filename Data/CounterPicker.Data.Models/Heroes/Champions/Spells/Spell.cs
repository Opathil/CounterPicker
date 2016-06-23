namespace CounterPicker.Data.Models.Heroes.Champions.Spells
{
    using System.Collections.Generic;

    public class Spell
    {
        public Spell()
        {
            this.cost = new List<int>();
            this.cooldown = new List<string>();
            this.effect = new List<List<double?>>();
            this.effectBurn = new List<string>();
            this.vars = new List<Vars>();
            this.range = new List<int>();
        }

        public string name { get; set; }

        public string description { get; set; }

        public string sanitizedDescription { get; set; }

        public LevelTip leveltip { get; set; }

        public SpellImage image { get; set; }

        public string resource { get; set; }

        public List<int> cost { get; set; }

        public string costType { get; set; }

        public string costBurn { get; set; }

        public List<string> cooldown { get; set; }

        public string cooldownBurn { get; set; }

        public List<List<double?>> effect { get; set; }

        public List<string> effectBurn { get; set; }

        public List<Vars> vars { get; set; }

        public List<int> range { get; set; }

        public string rangeBurn { get; set; }

        public string tooltip { get; set; }

        public string sanitizedTooltip { get; set; }

        public string key { get; set; }

        public int maxrank { get; set; }






    }
}