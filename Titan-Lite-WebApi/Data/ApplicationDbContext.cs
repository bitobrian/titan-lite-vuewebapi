using Microsoft.EntityFrameworkCore;
using Titan.Data.Entities;

namespace Titan.Data {
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<TestRecord> TestRecords {get;set;}
    }
}