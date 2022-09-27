using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiMVc.Models
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options) { }

        public DbSet<Fornecedor> Fornecedores { get; set; }

    }
}
