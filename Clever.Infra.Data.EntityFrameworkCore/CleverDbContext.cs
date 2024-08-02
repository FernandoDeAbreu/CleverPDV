using Clever.Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Clever.Infra.Data.EntityFrameworkCore;

public class CleverDbContext : DbContext
{
    public CleverDbContext(DbContextOptions<CleverDbContext> options) : base(options)
    {
    }
    public DbSet<Produto> Produtos { get; set; }
}