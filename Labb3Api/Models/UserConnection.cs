namespace Labb3Api.Models
{
    public class UserConnection
    {
        public int ID { get; set; }

        public int UserID { get; set; } 
        public User User { get; set; }
        public int InterestsID { get; set; }
        public Interests Interests { get; set; }
        public int? LinksID { get; set; }
        public Links Links { get; set; }
    }
}
