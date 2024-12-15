﻿
using Microsoft.EntityFrameworkCore;
using Project1.Model;

namespace Project1.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    public DbSet<Student> Students { get; set; }
}



