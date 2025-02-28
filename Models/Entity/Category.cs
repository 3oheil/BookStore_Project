namespace BookStore_Project.Models.Entity
{
    public class Category
    {
        public int Category_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
