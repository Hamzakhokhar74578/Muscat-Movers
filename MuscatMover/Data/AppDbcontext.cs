using Microsoft.EntityFrameworkCore;
using MuscatMover.Models;

namespace MuscatMover.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {

        }
        public DbSet<login> login { get; set; }

    }
}
