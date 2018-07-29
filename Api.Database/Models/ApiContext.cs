using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Api.Database.Models
{
    public partial class ApiContext : DbContext
    {
        public virtual DbSet<Ad> Ad { get; set; }
        public virtual DbSet<AdCategory> AdCategory { get; set; }
        public virtual DbSet<AdComments> AdComments { get; set; }
        public virtual DbSet<AdImages> AdImages { get; set; }
        public virtual DbSet<AdMainImages> AdMainImages { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<TblCities> TblCities { get; set; }
        public virtual DbSet<TblCountries> TblCountries { get; set; }
        public virtual DbSet<TblStates> TblStates { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
        : base(options)
        { }       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ad>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AdBusinessName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.PenduUserName).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Rating).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.TermDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CategoryDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryImageReference)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.TermDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdComments>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CommentDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CommentTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.TermDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdImages>(entity =>
            {
                entity.HasKey(e => e.ImageId);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.ImageTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TermDate).HasColumnType("datetime");

                entity.Property(e => e.UrlReference)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ad)
                    .WithMany(p => p.AdImages)
                    .HasForeignKey(d => d.AdId)
                    .HasConstraintName("FK_dbo.AdIdImage");
            });

            modelBuilder.Entity<AdMainImages>(entity =>
            {
                entity.HasKey(e => e.MainImageId);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.MainImageTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TermDate).HasColumnType("datetime");

                entity.Property(e => e.UrlReference)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ad)
                    .WithMany(p => p.AdMainImages)
                    .HasForeignKey(d => d.AdId)
                    .HasConstraintName("FK_dbo.AdIdMainImage");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblCities>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("tbl_cities");

                entity.Property(e => e.CityId).ValueGeneratedNever();

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TblCities)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cities_States");
            });

            modelBuilder.Entity<TblCountries>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("tbl_countries");

                entity.Property(e => e.CountryId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SortName)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblStates>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("tbl_states");

                entity.Property(e => e.StateId).ValueGeneratedNever();

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblStates)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_States_Countries");
            });
        }
    }
}
