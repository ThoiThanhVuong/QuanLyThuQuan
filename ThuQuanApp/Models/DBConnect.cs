using Microsoft.EntityFrameworkCore;

namespace ThuQuanApp.Models
{
    public class DBConnect : DbContext
    {
        public DbSet<MemberModel> Members { get; set; }
        public DBConnect(DbContextOptions options) : base(options)
        {
        }

        protected DBConnect()
        {
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<MemberModel>().ToTable("member");
            model.Entity<MemberModel>().HasKey(mem => mem.MemberID);
        }
    }
}
