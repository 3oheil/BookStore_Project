namespace BookStore_Project.Models.Entity
{
    public class Author
    {
        public int Auther_Id { get; set; }
        public string FullName { get; set; }
        public string? Biography { get; set; }
        public int BirthYear { get; set; }
        public string? Country { get; set; }


        public ICollection<Book> Books { get; set; }

    }
}
