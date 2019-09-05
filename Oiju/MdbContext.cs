using Microsoft.EntityFrameworkCore;
using Oiju.Models;

namespace Oiju
{
    public class MdbContext : DbContext
    {
        public MdbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }
    }
}
