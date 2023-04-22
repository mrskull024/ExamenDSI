using Microsoft.EntityFrameworkCore;

namespace APIExamen.Models;

public partial class DbA97bcaDsiContext : DbContext
{
    public DbA97bcaDsiContext()
    {
    }

    public DbA97bcaDsiContext(DbContextOptions<DbA97bcaDsiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tienda> Tiendas { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=SQL8005.site4now.net;Initial Catalog=db_a97bca_dsi;Persist Security Info=True;User ID=db_a97bca_dsi_admin;Password=Admin.*12345;TrustServerCertificate=True;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tienda>(entity =>
        {
            entity.HasKey(e => e.IdTTienda).HasName("PK__Tiendas__6EC71935B5688C62");

            entity.Property(e => e.IdTTienda).HasColumnName("IdT_Tienda");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Codigo_Postal");
            entity.Property(e => e.Correo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(355)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.NombreTienda)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Nombre_Tienda");
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Creacion");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
