using Microsoft.EntityFrameworkCore;

namespace DotnetExample.WebApi.Models;

#pragma warning disable CS1591
public class TestContext : DbContext
{
    public TestContext(DbContextOptions<TestContext> options) : base(options){}
    public DbSet<TestItem> TestItems { get; set; } = null!;
}
#pragma warning restore CS1591