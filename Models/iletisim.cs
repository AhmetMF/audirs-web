using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class iletisim
    {
        [Key]
        public int id { get; set; }
        public string mail { get; set; }
        public string adres { get; set; }
        public string tel { get; set; }
      
    }
}