using Clever.Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Clever.Infra.Data.EntityFrameworkCore;

public class CleverDbContext : DbContext
{
    public CleverDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Categoria> Categoria { get; set; }
}