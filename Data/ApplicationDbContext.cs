using Microsoft.EntityFrameworkCore;
using To_Do_App_MVC.Models;

namespace To_Do_App_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<ToDo> ToDos { get; set; }
    }
}