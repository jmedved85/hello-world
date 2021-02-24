using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Fakultet.Models;

#nullable disable

namespace Fakultet.Models
{
    public partial class faxContext : DbContext
    {
        public faxContext()
        {
        }

        public faxContext(DbContextOptions<faxContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dvorana> Dvoranas { get; set; }
        public virtual DbSet<Ispit> Ispits { get; set; }
        public virtual DbSet<Mjesto> Mjestos { get; set; }
        public virtual DbSet<Nastavnik> Nastavniks { get; set; }
        public virtual DbSet<Orgjed> Orgjeds { get; set; }
        public virtual DbSet<Pred> Preds { get; set; }
        public virtual DbSet<PredmetiDvorane> PredmetiDvoranes { get; set; }
        public virtual DbSet<Rezervacija> Rezervacijas { get; set; }
        public virtual DbSet<Stud> Studs { get; set; }
        public virtual DbSet<VMjestoZupanija> VMjestoZupanijas { get; set; }
        public virtual DbSet<VNastavniciInnerJoinMjesto> VNastavniciInnerJoinMjestos { get; set; }
        public virtual DbSet<VProlaznostIspitum> VProlaznostIspita { get; set; }
        public virtual DbSet<VRezervacijePredmetiRightJoin> VRezervacijePredmetiRightJoins { get; set; }
        public virtual DbSet<VStanovanje> VStanovanjes { get; set; }
        public virtual DbSet<VStudLeftJoinIspit> VStudLeftJoinIspits { get; set; }
        public virtual DbSet<VStudentiIspiti> VStudentiIspitis { get; set; }
        public virtual DbSet<Zupanija> Zupanijas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=fax;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Croatian_CI_AS");

            modelBuilder.Entity<Dvorana>(entity =>
            {
                entity.HasKey(e => e.OznDvorana);

                entity.ToTable("dvorana");

                entity.HasIndex(e => e.OznDvorana, "dvoranaUnique")
                    .IsUnique();

                entity.Property(e => e.OznDvorana)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("oznDvorana")
                    .IsFixedLength(true);

                entity.Property(e => e.Kapacitet)
                    .HasColumnName("kapacitet")
                    .HasDefaultValueSql("((40))");
            });

            modelBuilder.Entity<Ispit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ispit");

                entity.Property(e => e.DatIspit)
                    .HasColumnType("datetime")
                    .HasColumnName("datIspit");

                entity.Property(e => e.MbrStud).HasColumnName("mbrStud");

                entity.Property(e => e.Ocjena)
                    .HasColumnName("ocjena")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SifNastavnik).HasColumnName("sifNastavnik");

                entity.Property(e => e.SifPred).HasColumnName("sifPred");

                entity.HasOne(d => d.MbrStudNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MbrStud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ispit_stud");

                entity.HasOne(d => d.SifNastavnikNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.SifNastavnik)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ispit_nastavnik");

                entity.HasOne(d => d.SifPredNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.SifPred)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ispit_pred");
            });

            modelBuilder.Entity<Mjesto>(entity =>
            {
                entity.HasKey(e => e.Pbr);

                entity.ToTable("mjesto");

                entity.HasIndex(e => e.Pbr, "mjestoPbr")
                    .IsUnique();

                entity.HasIndex(e => e.NazMjesto, "mjestoUnique");

                entity.Property(e => e.Pbr)
                    .ValueGeneratedNever()
                    .HasColumnName("pbr");

                entity.Property(e => e.NazMjesto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("nazMjesto")
                    .IsFixedLength(true);

                entity.Property(e => e.SifZupanija).HasColumnName("sifZupanija");

                entity.HasOne(d => d.SifZupanijaNavigation)
                    .WithMany(p => p.Mjestos)
                    .HasForeignKey(d => d.SifZupanija)
                    .HasConstraintName("FK_mjesto_zupanija");
            });

            modelBuilder.Entity<Nastavnik>(entity =>
            {
                entity.HasKey(e => e.SifNastavnik);

                entity.ToTable("nastavnik");

                entity.HasIndex(e => e.SifNastavnik, "nastavnikUnique")
                    .IsUnique();

                entity.Property(e => e.SifNastavnik)
                    .ValueGeneratedNever()
                    .HasColumnName("sifNastavnik");

                entity.Property(e => e.ImeNastavnik)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("imeNastavnik")
                    .IsFixedLength(true);

                entity.Property(e => e.Koef)
                    .HasColumnType("decimal(3, 2)")
                    .HasColumnName("koef");

                entity.Property(e => e.PbrStan).HasColumnName("pbrStan");

                entity.Property(e => e.PrezNastavnik)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("prezNastavnik")
                    .IsFixedLength(true);

                entity.Property(e => e.SifOrgjed).HasColumnName("sifOrgjed");

                entity.HasOne(d => d.PbrStanNavigation)
                    .WithMany(p => p.Nastavniks)
                    .HasForeignKey(d => d.PbrStan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_nastavnik_mjesto");

                entity.HasOne(d => d.SifOrgjedNavigation)
                    .WithMany(p => p.Nastavniks)
                    .HasForeignKey(d => d.SifOrgjed)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_nastavnik_orgjed");
            });

            modelBuilder.Entity<Orgjed>(entity =>
            {
                entity.HasKey(e => e.SifOrgjed);

                entity.ToTable("orgjed");

                entity.HasIndex(e => e.SifOrgjed, "orgjedUnique")
                    .IsUnique();

                entity.Property(e => e.SifOrgjed)
                    .ValueGeneratedNever()
                    .HasColumnName("sifOrgjed");

                entity.Property(e => e.NazOrgjed)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("nazOrgjed")
                    .IsFixedLength(true);

                entity.Property(e => e.SifNadorgjed).HasColumnName("sifNadorgjed");

                entity.HasOne(d => d.SifNadorgjedNavigation)
                    .WithMany(p => p.InverseSifNadorgjedNavigation)
                    .HasForeignKey(d => d.SifNadorgjed)
                    .HasConstraintName("FK_orgjed_orgjed");
            });

            modelBuilder.Entity<Pred>(entity =>
            {
                entity.HasKey(e => e.SifPred);

                entity.ToTable("pred");

                entity.HasIndex(e => e.SifPred, "predUnique")
                    .IsUnique();

                entity.Property(e => e.SifPred)
                    .ValueGeneratedNever()
                    .HasColumnName("sifPred");

                entity.Property(e => e.BrojSatiTjedno).HasColumnName("brojSatiTjedno");

                entity.Property(e => e.KratPred)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("kratPred")
                    .IsFixedLength(true);

                entity.Property(e => e.NazPred)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("nazPred")
                    .IsFixedLength(true);

                entity.Property(e => e.SifOrgjed).HasColumnName("sifOrgjed");

                entity.Property(e => e.UpisanoStud).HasColumnName("upisanoStud");

                entity.HasOne(d => d.SifOrgjedNavigation)
                    .WithMany(p => p.Preds)
                    .HasForeignKey(d => d.SifOrgjed)
                    .HasConstraintName("FK_pred_orgjed");
            });

            modelBuilder.Entity<PredmetiDvorane>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PredmetiDvorane");

                entity.Property(e => e.NazPred)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("nazPred")
                    .IsFixedLength(true);

                entity.Property(e => e.OznDvorana)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("oznDvorana")
                    .IsFixedLength(true);

                entity.Property(e => e.Sat).HasColumnName("sat");
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rezervacija");

                entity.Property(e => e.OznDvorana)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("oznDvorana")
                    .IsFixedLength(true);

                entity.Property(e => e.OznVrstaDan)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("oznVrstaDan")
                    .IsFixedLength(true);

                entity.Property(e => e.Sat).HasColumnName("sat");

                entity.Property(e => e.SifPred).HasColumnName("sifPred");

                entity.HasOne(d => d.OznDvoranaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.OznDvorana)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rezervacija_dvorana");

                entity.HasOne(d => d.SifPredNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.SifPred)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rezervacija_pred");
            });

            modelBuilder.Entity<Stud>(entity =>
            {
                entity.HasKey(e => e.MbrStud);

                entity.ToTable("stud");

                entity.HasIndex(e => e.MbrStud, "studUnique")
                    .IsUnique();

                entity.Property(e => e.MbrStud)
                    .ValueGeneratedNever()
                    .HasColumnName("mbrStud");

                entity.Property(e => e.DatRodStud)
                    .HasColumnType("datetime")
                    .HasColumnName("datRodStud");

                entity.Property(e => e.ImeStud)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("imeStud");

                entity.Property(e => e.JmbgStud)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("jmbgStud")
                    .IsFixedLength(true);

                entity.Property(e => e.PbrRod).HasColumnName("pbrRod");

                entity.Property(e => e.PbrStan).HasColumnName("pbrStan");

                entity.Property(e => e.PrezStud)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("prezStud");

                entity.HasOne(d => d.PbrRodNavigation)
                    .WithMany(p => p.StudPbrRodNavigations)
                    .HasForeignKey(d => d.PbrRod)
                    .HasConstraintName("FK_stud_mjesto");

                entity.HasOne(d => d.PbrStanNavigation)
                    .WithMany(p => p.StudPbrStanNavigations)
                    .HasForeignKey(d => d.PbrStan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_stud_mjesto1");
            });

            modelBuilder.Entity<VMjestoZupanija>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_mjesto_zupanija");

                entity.Property(e => e.Mjesto)
                    .HasMaxLength(40)
                    .IsFixedLength(true);

                entity.Property(e => e.Županija)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VNastavniciInnerJoinMjesto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_nastavnici_inner_join_mjesto");

                entity.Property(e => e.ImeNastavnik)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("imeNastavnik")
                    .IsFixedLength(true);

                entity.Property(e => e.Koef)
                    .HasColumnType("decimal(3, 2)")
                    .HasColumnName("koef");

                entity.Property(e => e.MjestoGdjeŽivi)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("Mjesto gdje živi")
                    .IsFixedLength(true);

                entity.Property(e => e.Pbr).HasColumnName("pbr");

                entity.Property(e => e.PbrStan).HasColumnName("pbrStan");

                entity.Property(e => e.PrezNastavnik)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("prezNastavnik")
                    .IsFixedLength(true);

                entity.Property(e => e.SifNastavnik).HasColumnName("sifNastavnik");

                entity.Property(e => e.SifOrgjed).HasColumnName("sifOrgjed");
            });

            modelBuilder.Entity<VProlaznostIspitum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProlaznostIspita");

                entity.Property(e => e.ImeNastavnik)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("imeNastavnik")
                    .IsFixedLength(true);

                entity.Property(e => e.ImeStud)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("imeStud");

                entity.Property(e => e.Ocjena).HasColumnName("ocjena");

                entity.Property(e => e.PrezNastavnik)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("prezNastavnik")
                    .IsFixedLength(true);

                entity.Property(e => e.PrezStud)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("prezStud");
            });

            modelBuilder.Entity<VRezervacijePredmetiRightJoin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_rezervacije_predmeti_right_join");

                entity.Property(e => e.BrojSatiTjedno).HasColumnName("brojSatiTjedno");

                entity.Property(e => e.KratPred)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("kratPred")
                    .IsFixedLength(true);

                entity.Property(e => e.NazPred)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("nazPred")
                    .IsFixedLength(true);

                entity.Property(e => e.Sat).HasColumnName("sat");

                entity.Property(e => e.SifOrgjed).HasColumnName("sifOrgjed");

                entity.Property(e => e.SifPred).HasColumnName("sifPred");

                entity.Property(e => e.UpisanoStud).HasColumnName("upisanoStud");
            });

            modelBuilder.Entity<VStanovanje>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_stanovanje");

                entity.Property(e => e.ImeNastavnik)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("imeNastavnik")
                    .IsFixedLength(true);

                entity.Property(e => e.NazMjesto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("nazMjesto")
                    .IsFixedLength(true);

                entity.Property(e => e.PrezNastavnik)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("prezNastavnik")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VStudLeftJoinIspit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_stud_left_join_ispit");

                entity.Property(e => e.DatIspit)
                    .HasColumnType("datetime")
                    .HasColumnName("datIspit");

                entity.Property(e => e.DatRodStud)
                    .HasColumnType("datetime")
                    .HasColumnName("datRodStud");

                entity.Property(e => e.ImeStud)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("imeStud");

                entity.Property(e => e.JmbgStud)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("jmbgStud")
                    .IsFixedLength(true);

                entity.Property(e => e.MbrStud).HasColumnName("mbrStud");

                entity.Property(e => e.Ocjena).HasColumnName("ocjena");

                entity.Property(e => e.PbrRod).HasColumnName("pbrRod");

                entity.Property(e => e.PbrStan).HasColumnName("pbrStan");

                entity.Property(e => e.PrezStud)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("prezStud");

                entity.Property(e => e.SifNastavnik).HasColumnName("sifNastavnik");

                entity.Property(e => e.SifPred).HasColumnName("sifPred");
            });

            modelBuilder.Entity<VStudentiIspiti>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_studenti_ispiti");

                entity.Property(e => e.ImeStud)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("imeStud");

                entity.Property(e => e.MbrStud).HasColumnName("mbrStud");

                entity.Property(e => e.Ocjena).HasColumnName("ocjena");

                entity.Property(e => e.SifPred).HasColumnName("sifPred");
            });

            modelBuilder.Entity<Zupanija>(entity =>
            {
                entity.HasKey(e => e.SifZupanija);

                entity.ToTable("zupanija");

                entity.HasIndex(e => e.SifZupanija, "zupanijaUnique")
                    .IsUnique();

                entity.Property(e => e.SifZupanija)
                    .ValueGeneratedNever()
                    .HasColumnName("sifZupanija");

                entity.Property(e => e.NazZupanija)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("nazZupanija")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
