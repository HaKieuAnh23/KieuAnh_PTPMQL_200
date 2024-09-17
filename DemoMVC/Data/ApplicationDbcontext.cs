using DemoMVC.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
 
namespace DemoMVC.Data;
 
public class ApplicationDbContext : IdentityDbContext<IdentityApp>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
 
    public DbSet<Student> Students { get; set; }
    
}