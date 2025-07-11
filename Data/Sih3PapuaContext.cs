using System;
using System.Collections.Generic;
using Sih3Papua.Models;
using Microsoft.EntityFrameworkCore;

namespace Sih3Papua.Data;

public partial class Sih3PapuaContext : DbContext
{
    public Sih3PapuaContext()
    {
    }

    public Sih3PapuaContext(DbContextOptions<Sih3PapuaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("uuid-ossp");

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.HasIndex(e => e.Phone, "idx_users_phone");

            entity.HasIndex(e => e.Username, "idx_users_username");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt)
                .HasDefaultValueSql("NULL::timestamp without time zone")
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("deleted_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("email");
            entity.Property(e => e.LastLogin)
                .HasDefaultValueSql("NULL::timestamp without time zone")
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("last_login");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Role)
                .HasMaxLength(255)
                .HasColumnName("role");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("phone");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}