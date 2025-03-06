﻿using FinalProje.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalProje.Data
{
    public class ApplicationDbContext:IdentityDbContext<AppUser, AppRole, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Products>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Slider>? Sliders { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderItem>? OrderItems { get; set; }
    }
}
