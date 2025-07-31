namespace Code_First_Yaklaşımında_Tablo_İlişkilendirme.Entities
{
    public class Post : Entity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
