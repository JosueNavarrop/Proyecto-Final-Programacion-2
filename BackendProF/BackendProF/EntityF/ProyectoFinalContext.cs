using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BackendProF.EntityF;

public partial class ProyectoFinalContext : DbContext
{
    public ProyectoFinalContext()
    {
    }

    public ProyectoFinalContext(DbContextOptions<ProyectoFinalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Pelicula> Peliculas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-QKAAT8O; Database=ProyectoFInal; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pelicula>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Año)
                .HasColumnType("date")
                .HasColumnName("año");
            entity.Property(e => e.Director)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("director");
            entity.Property(e => e.Genero)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Poster)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("titulo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
