using System.ComponentModel.DataAnnotations;

namespace Labb3Api.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Phone {  get; set; }

    }

    
}
