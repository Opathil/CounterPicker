namespace CounterPicker.Data.Models.Heroes.Champions.Spells
{
    using System.Collections.Generic;

    public class Vars
    {
        public Vars()
        {
            this.coeff = new List<double>();
        }

        public string key { get; set; }

        public string link { get; set; }

        public List<double> coeff { get; set; }
    }
}