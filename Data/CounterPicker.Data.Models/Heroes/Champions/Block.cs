
namespace CounterPicker.Data.Models.Heroes.Champions
{
    using System.Collections.Generic;

    public class Block
    {
        public Block()
        {
            this.items = new List<Item>();
        }

        public string type { get; set; }

        public List<Item> items { get; set; }

        public bool? recMath { get; set; }
    }
}