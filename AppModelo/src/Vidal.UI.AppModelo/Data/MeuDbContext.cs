using Microsoft.EntityFrameworkCore;
using Vidal.UI.AppModelo.Models;

namespace Vidal.UI.AppModelo.Data
{

    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
   

}

