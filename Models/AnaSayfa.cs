using System.ComponentModel.DataAnnotations;

namespace AudiRsWeb.Models
{
    public class AnaSayfa
    {
        [Key]
        public int id  { get; set; } 
        public string banner1 { get; set; }
        public string banner2 { get; set; }    
        public string banner3 { get; set; }    
        public string  oz1 { get; set; }
        public string oz2 { get; set; }
        public string ozimg { get; set; }
        public string raceimg { get; set; } 
        public string racetext { get; set; }    
        public string infotext { get; set; }    
        public string info1 { get; set; }   
        public string info2 { get; set; }
        public string info3 { get; set; }
        public string info4 { get; set; } 
    }
}