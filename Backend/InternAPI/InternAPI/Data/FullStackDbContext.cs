using InternAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InternAPI.Data
{
    public class FullStackDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public FullStackDbContext (DbContextOptions options) : base(options)
            {
            }

        DbSet<Models.Interns> interns { get; set; }

    }
}
