using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TalentAgencyWebApplication
{
    public partial class TalentAgencyContext : DbContext
    {
        public TalentAgencyContext()
        {
        }

        public TalentAgencyContext(DbContextOptions<TalentAgencyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<ArtistActivity> ArtistActivities { get; set; }
        public virtual DbSet<ArtistAward> ArtistAwards { get; set; }
        public virtual DbSet<ArtistMedia> ArtistMedias { get; set; }
        public virtual DbSet<ArtistProject> ArtistProjects { get; set; }
        public virtual DbSet<Award> Awards { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<MediaType> MediaTypes { get; set; }
        public virtual DbSet<Portfolio> Portfolios { get; set; }
        public virtual DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server= DESKTOP-UBOM267\\SQLEXPRESS; Database=TalentAgency; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.Property(e => e.Activity1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Activity");
            });

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.Property(e => e.Biography)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Artists)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Artists_Genders");
            });

            modelBuilder.Entity<ArtistActivity>(entity =>
            {
                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ArtistActivities)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtistActivities_Activities");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.ArtistActivities)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtistActivities_Artists");
            });

            modelBuilder.Entity<ArtistAward>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.ArtistAwards)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtistAwards_Artists");

                entity.HasOne(d => d.Award)
                    .WithMany(p => p.ArtistAwards)
                    .HasForeignKey(d => d.AwardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtistAwards_Awards");
            });

            modelBuilder.Entity<ArtistMedia>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.ArtistMedia)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtistMedia_Artists");

                entity.HasOne(d => d.MediaTypes)
                    .WithMany(p => p.ArtistMedia)
                    .HasForeignKey(d => d.MediaTypesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtistMedia_MediaTypes");
            });

            modelBuilder.Entity<ArtistProject>(entity =>
            {
                entity.Property(e => e.Info).HasMaxLength(100);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.ArtistProjects)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtistProjects_Artists");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ArtistProjects)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtistProjects_Projects");
            });

            modelBuilder.Entity<Award>(entity =>
            {
                entity.Property(e => e.Award1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Award");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.Property(e => e.Gender1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Gender");
            });

            modelBuilder.Entity<MediaType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Portfolio>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Photo).IsRequired();

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.Portfolios)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Portfolio_Artists");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projects_Activities");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
