using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Item
    {
        public Item()
        {
            this.JoinEntries = new HashSet<CategoryItemTag>();
        }

        public int ItemId { get; set; }
        public string Description { get; set; }

        public ICollection<CategoryItemTag> JoinEntries { get;}
    }
}