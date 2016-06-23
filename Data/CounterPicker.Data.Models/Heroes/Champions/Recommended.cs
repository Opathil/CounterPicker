namespace CounterPicker.Data.Models.Heroes.Champions
{
    using System.Collections.Generic;

    public class Recommended
    {
        public Recommended()
        {
            this.blocks = new List<Block>();
        }

        public string champion { get; set; }

        public string title { get; set; }

        public string type { get; set; }

        public string map { get; set; }

        public string mode { get; set; }

        public bool priority { get; set; }

        public List<Block> blocks { get; set; }
    }
}