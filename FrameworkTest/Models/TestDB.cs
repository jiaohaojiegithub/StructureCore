namespace FrameworkTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TestDB : DbContext
    {
        public TestDB()
            : base("name=TestDB")
        {
        }

        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<ArticleType> ArticleTypes { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Comment_Reply> Comment_Reply { get; set; }
        public virtual DbSet<Forum> Fora { get; set; }
        public virtual DbSet<Lable> Lables { get; set; }
        public virtual DbSet<User_Card> User_Card { get; set; }
        public virtual DbSet<User_Login> User_Login { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
