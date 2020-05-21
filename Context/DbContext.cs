using Microsoft.EntityFrameworkCore;
using MyWebsite.Models;

namespace MyWebsite
{
    public class DbContext : DbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        public DbSet<News> News { get; set; }
        public DbSet<Homework> Homework { get; set; }

        //設定外來鍵，唯一值
    }
}