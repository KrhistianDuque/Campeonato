using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiCampeonato.Models
{
    public partial class DB_CAMPEONATOContext : DbContext
    {
        public DB_CAMPEONATOContext()
        {
        }

        public DB_CAMPEONATOContext(DbContextOptions<DB_CAMPEONATOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Equipo> Equipo { get; set; }
        public virtual DbSet<EquipoResultado> EquipoResultado { get; set; }
        public virtual DbSet<Posicion> Posicion { get; set; }
        public virtual DbSet<Resultado> Resultado { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-GQBS7UB\\SQLEXPRESS;Database=DB_CAMPEONATO;MultipleActiveResultSets=true;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipo>(entity =>
            {
                entity.HasKey(e => e.EquId);

                entity.ToTable("equipo");

                entity.Property(e => e.EquId)
                    .HasColumnName("equ_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EquNombre)
                    .IsRequired()
                    .HasColumnName("equ_nombre")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EquipoResultado>(entity =>
            {
                entity.HasKey(e => e.EreId);

                entity.ToTable("equipo_resultado");

                entity.Property(e => e.EreId)
                    .HasColumnName("ere_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EreIdEquipo).HasColumnName("ere_id_equipo");

                entity.Property(e => e.EreIdResultado).HasColumnName("ere_id_resultado");

                entity.HasOne(d => d.EreIdEquipoNavigation)
                    .WithMany(p => p.EquipoResultado)
                    .HasForeignKey(d => d.EreIdEquipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_equipo_resultado_equipo_resultado");

                entity.HasOne(d => d.EreIdResultadoNavigation)
                    .WithMany(p => p.EquipoResultado)
                    .HasForeignKey(d => d.EreIdResultado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_equipo_resultado_resultado");
            });

            modelBuilder.Entity<Posicion>(entity =>
            {
                entity.HasKey(e => e.PosId);

                entity.ToTable("posicion");

                entity.Property(e => e.PosId)
                    .HasColumnName("pos_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PosGolesContra).HasColumnName("pos_goles_contra");

                entity.Property(e => e.PosGolesFavor).HasColumnName("pos_goles_favor");

                entity.Property(e => e.PosIdEquipo).HasColumnName("pos_id_equipo");

                entity.Property(e => e.PosPuntos).HasColumnName("pos_puntos");

                entity.HasOne(d => d.PosIdEquipoNavigation)
                    .WithMany(p => p.Posicion)
                    .HasForeignKey(d => d.PosIdEquipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_posicion_equipo");
            });

            modelBuilder.Entity<Resultado>(entity =>
            {
                entity.HasKey(e => e.EncId);

                entity.ToTable("resultado");

                entity.Property(e => e.EncId)
                    .HasColumnName("enc_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EncGolesContra).HasColumnName("enc_goles_contra");

                entity.Property(e => e.EncGolesFavor).HasColumnName("enc_goles_favor");

                entity.Property(e => e.EncIdEquipoRival).HasColumnName("enc_id_equipo_rival");

                entity.Property(e => e.EncPuntos).HasColumnName("enc_puntos");

                entity.HasOne(d => d.EncIdEquipoRivalNavigation)
                    .WithMany(p => p.Resultado)
                    .HasForeignKey(d => d.EncIdEquipoRival)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_resultado_resultado");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
