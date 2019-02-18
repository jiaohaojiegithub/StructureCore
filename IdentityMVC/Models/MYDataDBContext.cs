using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityMVC.Models
{
    public class MYDataDBContext: DbContext
    {
        public MYDataDBContext()
        {

        }
        public MYDataDBContext(DbContextOptions<MYDataDBContext> options) : base(options)
        {

        }
        public virtual DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("data source=118.24.129.186;initial catalog=DBMYBLOG;persist security info=True;user id=sa;password=fnhYSPK7FPjIg;MultipleActiveResultSets=True;");
                optionsBuilder.UseSqlServer("Server=.;Database=MYDataDB;Trusted_Connection=True;MultipleActiveResultSets=true");
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
                entity.Property(e => e.CreateTime).HasDefaultValue(DateTime.Now);
            });
            #endregion
        }
    }
}
