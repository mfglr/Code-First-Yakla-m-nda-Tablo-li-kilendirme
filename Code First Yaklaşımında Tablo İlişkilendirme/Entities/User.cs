namespace Code_First_Yaklaşımında_Tablo_İlişkilendirme.Entities
{
    public class User : Entity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public List<Post> Posts { get; set; }
    }
}
