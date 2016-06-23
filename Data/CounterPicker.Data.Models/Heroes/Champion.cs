namespace CounterPicker.Data.Models.Heroes
{
    using Champions;
    using System.Collections.Generic;

    public class Champion
    {
        public string type { get; set; }

        public string format { get; set; }

        public string version { get; set; }
        
        public Dictionary<string,Hero> data { get; set; }

        public Dictionary<int,string> keys { get; set; }
    }
}
