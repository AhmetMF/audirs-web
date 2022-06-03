using System.ComponentModel.DataAnnotations;

namespace AudiRsWeb.Models
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string isim { get; set; }    
        public string sifre { get; set; }       
    }
}