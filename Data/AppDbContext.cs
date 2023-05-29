﻿using System.ComponentModel.DataAnnotations.Schema;
using GraphQlApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQlApi.Data;

public class AppDbContext : DbContext
{
    public DbSet<Platform> Platforms { get; set; }

    public DbSet<Command> Commands { get; set; }

    public AppDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Platform>()
            .HasMany(p => p.Commands)
            .WithOne(c => c.Platform!)
            .HasForeignKey(c => c.PlatformId);

        modelBuilder
            .Entity<Command>()
            .HasOne(c => c.Platform)
            .WithMany(p => p.Commands)
            .HasForeignKey(c => c.PlatformId);
    }
}
