using CoreMVCTestDB.Models.PublicModel;
using Microsoft.EntityFrameworkCore;
using System;

namespace CoreMVCTestDB
{
    public class CoreMVCTestContext: DbContext
    {
        public CoreMVCTestContext()
        {
            //构造函数引用
        }
        public CoreMVCTestContext(DbContextOptions<CoreMVCTestContext> options):base(options)
        {
            //构造函数引用
        }
        #region 表
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RoleClaims> RoleClaims { get; set; }
        public virtual DbSet<UserClaims> UserClaims { get; set; }
        public virtual DbSet<UserLogins> UserLogins { get; set; }
        public virtual DbSet<UserTokens> UserTokens { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("data source=118.24.129.186;initial catalog=DBMYBLOG;persist security info=True;user id=sa;password=fnhYSPK7FPjIg;MultipleActiveResultSets=True;");
                optionsBuilder.UseSqlServer("Server=.;Database=CoreMVCTest;Trusted_Connection=True;MultipleActiveResultSets=true");
                //ConfigurationManager.ConnectionStrings["BloggingDatabase"].ConnectionString
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            #region 验证模型
            builder.Entity<Users>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasDefaultValueSql("REPLACE(NEWID(),'-','')");//LOWER(REPLACE(NEWID(),'-','')) 小写
                entity.Property(e => e.LockoutEnabled).IsUnicode(false);
            });
            builder.Entity<Roles>(entity =>
            {
                entity.ToTable("Roles");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasDefaultValueSql("REPLACE(NEWID(),'-','')");
                entity.Property(e => e.Discriminator).HasDefaultValue("有效");
            });
            builder.Entity<RoleClaims>(entity =>
            {
                entity.ToTable("RoleClaims");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<UserClaims>(entity =>
            {
                entity.ToTable("UserClaims");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });
            builder.Entity<UserLogins>(entity =>
            {
                entity.ToTable("UserLogins");
                entity.HasKey(e => new { e.ProviderKey, e.LoginProvider });
            });
            builder.Entity<UserTokens>(entity =>
            {
                entity.ToTable("UserTokens");
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });
            builder.Entity<UserRoles>(entity =>
            {
                entity.ToTable("UserRoles");
                entity.HasKey(e => new { e.RoleId, e.UserId });
            });
            #endregion
        }
    }
}
