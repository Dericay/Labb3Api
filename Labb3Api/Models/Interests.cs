using System.ComponentModel.DataAnnotations;

namespace Labb3Api.Models
{
    public class Interests
    {
        [Key]
       public int InterestsID { get; set; }
        [Required]
        public string InterestsName { get; set; }
        public string InterestsDescription { get; set; }

        
    }

   
}
