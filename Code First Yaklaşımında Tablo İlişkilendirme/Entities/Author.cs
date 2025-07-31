namespace Code_First_Yaklaşımında_Tablo_İlişkilendirme.Entities
{
    public class Author : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> Books { get; set; }
    }
}
