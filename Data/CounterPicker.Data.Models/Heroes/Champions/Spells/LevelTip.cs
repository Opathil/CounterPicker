namespace CounterPicker.Data.Models.Heroes.Champions.Spells
{
    using System.Collections.Generic;

    public class LevelTip
    {
        public LevelTip()
        {
            this.label = new List<string>();
            this.effect = new List<string>();
        }

        public List<string> label { get; set; }

        public List<string> effect { get; set; }
    }
}