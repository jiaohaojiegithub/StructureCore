using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MYBlog.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYBlog.MVC.Data
{
    public class MYBlogContext: IdentityDbContext<MYBlogUser>
    {
        public MYBlogContext()
        {

        }
        public MYBlogContext(DbContextOptions<MYBlogContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("data source=118.24.129.186;initial catalog=DBMYBLOG;persist security info=True;user id=sa;password=fnhYSPK7FPjIg;MultipleActiveResultSets=True;");
                optionsBuilder.UseSqlServer("Server=.;Database=MYBlog;Trusted_Connection=True;MultipleActiveResultSets=true");
                //ConfigurationManager.ConnectionStrings["BloggingDatabase"].ConnectionString
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
