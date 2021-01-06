namespace ToDoList.Models
{
  public class CategoryItemTag
    {       
        public int CategoryItemTagId { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public int? TagId { get; set; }
        public Tag Tag { get; set; }
    }
}