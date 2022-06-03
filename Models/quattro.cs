using System.ComponentModel.DataAnnotations;

namespace AudiRsWeb.Models
{
    public class quattro
    {
        [Key]
        public int id { get; set; }
        public string img1 { get; set; }
        public string text1 { get; set; }
        public string img2 { get; set; }
        public string text2 { get; set; }
        public string img3 { get; set; }
        public string text3 { get; set; }
        public string img4 { get; set; }
        public string text4 { get; set; }
        

    }
}