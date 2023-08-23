using BasicAPI.Model;
using Microsoft.EntityFrameworkCore;
namespace BasicAPI.Data
{
    public class AppDbCOntext:DbContext
    {
        public AppDbCOntext(DbContextOptions<AppDbCOntext> options)
            :base(options)

        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
