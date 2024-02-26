
using HarmoniBackendAdmin.Models;
using Microsoft.EntityFrameworkCore;

namespace HarmoniBackendAdmin.Data;

public class HarmoniDbContext : DbContext
{
public HarmoniDbContext(DbContextOptions<HarmoniDbContext> options) : base (options){  }

public DbSet<Product> Products {get; set;}
public DbSet<Staff> Staffs {get; set;}

public DbSet<Booking> Bookings {get; set;}

public DbSet<Treatment> Treatments {get; set;}
}