using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Unalm_Api.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Unalm_Api.Data
{
    public partial class unalmContext : DbContext
    {

        public unalmContext(DbContextOptions<unalmContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mensaje> BandejaMensajes { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci");

            modelBuilder.Entity<Mensaje>(entity =>
            {
                entity.ToTable("bandeja_mensajes");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("comentarios");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nombres");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(255)
                    .HasColumnName("telefono");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.ToTable("cursos");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("codigo")
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Creditos).HasColumnName("creditos");

                entity.Property(e => e.HorasPractica).HasColumnName("horas_practica");

                entity.Property(e => e.HorasTeoria).HasColumnName("horas_teoria");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.Sumilla)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("sumilla");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
