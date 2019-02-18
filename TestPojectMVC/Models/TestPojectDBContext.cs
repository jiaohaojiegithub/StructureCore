using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestPojectMVC.Models
{
    public class TestPojectDBContext:IdentityDbContext<Users>
    {
        public TestPojectDBContext()
        {

        }
        public TestPojectDBContext(DbContextOptions<TestPojectDBContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("data source=118.24.129.186;initial catalog=DBMYBLOG;persist security info=True;user id=sa;password=fnhYSPK7FPjIg;MultipleActiveResultSets=True;");
                optionsBuilder.UseSqlServer("Server=.;Database=TestPojectDB;Trusted_Connection=True;MultipleActiveResultSets=true");
                //ConfigurationManager.ConnectionStrings["BloggingDatabase"].ConnectionString
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            #region 验证模型
            builder.Entity<Users>(entity =>
            {
                entity.Property(e => e.MD5PassWord).IsRequired();
                entity.Property(e => e.CreateDT).HasDefaultValue(DateTime.Now);
            });
            #endregion
        }
        }
    }
