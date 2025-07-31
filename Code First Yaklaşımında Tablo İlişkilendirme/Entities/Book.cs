namespace Code_First_Yaklaşımında_Tablo_İlişkilendirme.Entities
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
