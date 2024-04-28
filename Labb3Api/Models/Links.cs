using System.ComponentModel.DataAnnotations;

namespace Labb3Api.Models
{
    public class Links
    {
        [Key]
        public int LinkID { get; set; }
        public string Link { get; set; }
        

    }

    
}
