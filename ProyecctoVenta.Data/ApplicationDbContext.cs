﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoVenta.Model;

namespace ProyectoVenta.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //public DbSet<Oficina> Oficina { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
       // public DbSet<Slider> Slider { get; set; }
    }
}
