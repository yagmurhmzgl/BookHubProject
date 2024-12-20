using BookHub.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.DataAccesLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=YAGMUR\\SQLEXPRESS;initial catalog=BookHubProject;integrated security=true;TrustServerCertificate=True;Trusted_Connection=True;");
			
		}
        
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Bulten> Bultenler { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Hikaye> Hikayeler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Okuyucu> Okuyucular { get; set; }
        public DbSet<Begeni> Begeniler { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }

    }
}
