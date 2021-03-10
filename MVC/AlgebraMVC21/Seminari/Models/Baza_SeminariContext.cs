using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Seminari.Models
{
    public partial class Baza_SeminariContext : DbContext
    {
        public Baza_SeminariContext()
        {
        }

        public Baza_SeminariContext(DbContextOptions<Baza_SeminariContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Predbiljezba> Predbiljezbas { get; set; }
        public virtual DbSet<Seminar> Seminars { get; set; }
        public virtual DbSet<Zaposlenik> Zaposleniks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-MAN7GV7\\SQLExpress;Database=Baza_Seminari;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Croatian_CI_AS");

            modelBuilder.Entity<Predbiljezba>(entity =>
            {
                entity.HasKey(e => e.IdPredbiljezba);

                entity.ToTable("predbiljezba");

                entity.Property(e => e.IdPredbiljezba).HasColumnName("ID_predbiljezba");

                entity.Property(e => e.Adresa)
                    .HasMaxLength(50)
                    .HasColumnName("adresa");

                entity.Property(e => e.Datum)
                    .HasColumnType("date")
                    .HasColumnName("datum");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.IdSeminar).HasColumnName("ID_seminar");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ime");

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("prezime");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(50)
                    .HasColumnName("telefon");

                entity.HasOne(d => d.IdSeminarNavigation)
                    .WithMany(p => p.Predbiljezbas)
                    .HasForeignKey(d => d.IdSeminar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_predbiljezba_seminar");
            });

            modelBuilder.Entity<Seminar>(entity =>
            {
                entity.HasKey(e => e.IdSeminar);

                entity.ToTable("seminar");

                entity.Property(e => e.IdSeminar)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_seminar");

                entity.Property(e => e.Datum)
                    .HasColumnType("date")
                    .HasColumnName("datum");

                entity.Property(e => e.IdZaposlenik).HasColumnName("ID_zaposlenik");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("naziv");

                entity.Property(e => e.Opis)
                    .HasMaxLength(250)
                    .HasColumnName("opis");

                entity.Property(e => e.Popunjen).HasColumnName("popunjen");

                entity.HasOne(d => d.IdZaposlenikNavigation)
                    .WithMany(p => p.Seminars)
                    .HasForeignKey(d => d.IdZaposlenik)
                    .HasConstraintName("FK_seminar_zaposlenik");
            });

            modelBuilder.Entity<Zaposlenik>(entity =>
            {
                entity.HasKey(e => e.IdZaposlenik);

                entity.ToTable("zaposlenik");

                entity.Property(e => e.IdZaposlenik).HasColumnName("ID_zaposlenik");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ime");

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("korisnicko_ime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("prezime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
