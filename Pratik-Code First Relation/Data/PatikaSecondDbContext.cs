using Microsoft.EntityFrameworkCore;
using Pratik_Code_First_Relation.Data.Entities;

namespace Pratik_Code_First_Relation.Data
{
    public class PatikaSecondDbContext : DbContext
    {
        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=PatikaCodeFirstDb2;Trusted_Connection=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostEntity>(entity =>
            {
                //burada birden çoka ilişki kurulu
                entity.HasOne(x => x.User)
                      .WithMany(x => x.Posts)
                      .HasForeignKey(x => x.UserId);
            });

        }
    }
}