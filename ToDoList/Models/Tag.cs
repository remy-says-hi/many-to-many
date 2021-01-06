using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Tag
    {
        public Tag()
        {
            this.Items = new HashSet<CategoryItemTag>();
        }

        public int TagId { get; set; }
        public string Title { get; set; }
        public virtual ICollection<CategoryItemTag> Items { get; set; }
    }
}