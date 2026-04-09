using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DealerPlatform.Demain.UserInfo;
using Microsoft.EntityFrameworkCore;

namespace DealerPlatform.Core.Core
{
    public class DearlerPlatformDBContext : DbContext
    {
        
        public DbSet<User> Users { get; set; }
        public DearlerPlatformDBContext()
        {

        }

        public DearlerPlatformDBContext(DbContextOptions<DearlerPlatformDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("tb_users");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
                entity.Property(e => e.UserName).HasColumnName("username").IsRequired().HasMaxLength(50).HasComment("用户名");
                entity.Property(e => e.Password).HasColumnName("password").HasComment("密码");
                entity.Property(e => e.Email).HasColumnName("email").HasComment("邮箱");
                entity.Property(e => e.CreatedAt).HasColumnName("created_at").HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });
           base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "server=localhost;port=3306;database=dealerplatform;user=root;password=root;";
                optionsBuilder.UseMySql(
                    connectionString,
                    new MySqlServerVersion(new Version(8, 0, 33))
                );
            }
        }
    }
}