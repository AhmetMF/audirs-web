using System.Data.Entity;

namespace AudiRsWeb.Models
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AnaSayfa> anaSayfas { get; set; }  
        public DbSet<iletisim> iletisims { get; set; }  
        public DbSet<infopage> infopages { get; set; }  
        public DbSet<quattro> quattros { get; set; }    
        public DbSet<servis> servis { get; set; }

    }
}