using System;
using System.Collections.Generic;
using Gun_Identification_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Gun_Identification_App.Data;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Handgun> Handguns { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=laptop-94o8d071;Initial Catalog=GunIdTool;Persist Security Info=True;Trust Server Certificate=True;User ID=admin;Password=2xBz=kd!npJ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Handgun>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Handguns__3213E83FB704E63F");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Image)
                .HasColumnType("text")
                .HasColumnName("image");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
