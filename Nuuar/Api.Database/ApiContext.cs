using System;
using Microsoft.EntityFrameworkCore;

namespace Api.Database
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
           : base(options)
        {
        }
        public DbSet<Nuvvor.Entites.Ad> Ad { get; set; }
        public DbSet<Nuvvor.Entites.AdImage> AdImage { get; set; }
        public DbSet<Nuvvor.Entites.Language> Language { get; set; }
    }
}
