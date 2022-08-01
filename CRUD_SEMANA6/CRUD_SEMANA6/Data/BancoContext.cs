using Microsoft.EntityFrameworkCore;
using CRUD_SEMANA6.Models;

namespace CRUD_SEMANA6.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<CaminhaoModel> Caminhoes { get; set; }
    }
}
