using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MYBLOGDB.Models
{
    public partial class DBMYBLOGContext : DbContext
    {
        public DBMYBLOGContext()
        {
        }

        public DBMYBLOGContext(DbContextOptions<DBMYBLOGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<ArticleType> ArticleType { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<CommentReply> CommentReply { get; set; }
        public virtual DbSet<Forum> Forum { get; set; }
        public virtual DbSet<Lable> Lable { get; set; }
        public virtual DbSet<UserCard> UserCard { get; set; }
        public virtual DbSet<UserLogin> UserLogin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=118.24.129.186;initial catalog=DBMYBLOG;persist security info=True;user id=sa;password=fnhYSPK7FPjIg;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(e => e.ArticleId).HasColumnName("Article_ID");

                entity.Property(e => e.ArticleAbstract).HasColumnName("Article_Abstract");

                entity.Property(e => e.ArticleContent).HasColumnName("Article_Content");

                entity.Property(e => e.ArticleCreateDt)
                    .HasColumnName("Article_CreateDT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ArticleImg).HasColumnName("Article_Img");

                entity.Property(e => e.ArticleTitle).HasColumnName("Article_Title");

                entity.Property(e => e.ArticleTypeId).HasColumnName("ArticleType_ID");

                entity.Property(e => e.LableId)
                    .IsRequired()
                    .HasColumnName("Lable_ID");

                entity.Property(e => e.UserCardId).HasColumnName("UserCard_ID");
            });

            modelBuilder.Entity<ArticleType>(entity =>
            {
                entity.Property(e => e.ArticleTypeId).HasColumnName("ArticleType_ID");

                entity.Property(e => e.ArticleTypeName)
                    .IsRequired()
                    .HasColumnName("ArticleType_Name");

                entity.Property(e => e.ForumId).HasColumnName("Forum_ID");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.CommentId).HasColumnName("Comment_ID");

                entity.Property(e => e.ArticleId).HasColumnName("Article_ID");

                entity.Property(e => e.CommentContene)
                    .HasColumnName("Comment_Contene")
                    .HasMaxLength(500);

                entity.Property(e => e.CommentCreatDt)
                    .HasColumnName("Comment_CreatDT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserCardId).HasColumnName("UserCard_ID");
            });

            modelBuilder.Entity<CommentReply>(entity =>
            {
                entity.ToTable("Comment_Reply");

                entity.Property(e => e.CommentReplyId).HasColumnName("Comment_Reply_ID");

                entity.Property(e => e.CommentId).HasColumnName("Comment_ID");

                entity.Property(e => e.CommentReplyContene)
                    .HasColumnName("Comment_Reply_Contene")
                    .HasMaxLength(500);

                entity.Property(e => e.CommentReplyCreatDt)
                    .HasColumnName("Comment_Reply_CreatDT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserCardId).HasColumnName("UserCard_ID");
            });

            modelBuilder.Entity<Forum>(entity =>
            {
                entity.Property(e => e.ForumId).HasColumnName("Forum_ID");

                entity.Property(e => e.ForumName).HasColumnName("Forum_Name");
            });

            modelBuilder.Entity<Lable>(entity =>
            {
                entity.Property(e => e.LableId).HasColumnName("Lable_ID");

                entity.Property(e => e.LableCreatDt)
                    .HasColumnName("Lable_CreatDT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LableRemark)
                    .IsRequired()
                    .HasColumnName("Lable_Remark")
                    .HasMaxLength(150);

                entity.Property(e => e.LableText)
                    .IsRequired()
                    .HasColumnName("Lable_Text");
            });

            modelBuilder.Entity<UserCard>(entity =>
            {
                entity.ToTable("User_Card");

                entity.HasIndex(e => e.UserLoginId);

                entity.Property(e => e.UserCardId).HasColumnName("UserCard_ID");

                entity.Property(e => e.UserCardBirthday).HasColumnName("UserCard_Birthday");

                entity.Property(e => e.UserCardChatHeadImg).HasColumnName("UserCard_ChatHeadImg");

                entity.Property(e => e.UserCardCreatDt).HasColumnName("UserCard_CreatDt");

                entity.Property(e => e.UserCardGmLevel).HasColumnName("UserCard_GmLevel");

                entity.Property(e => e.UserCardMobilPhone).HasColumnName("UserCard_MobilPhone");

                entity.Property(e => e.UserCardNickname)
                    .IsRequired()
                    .HasColumnName("UserCard_Nickname")
                    .HasMaxLength(20);

                entity.Property(e => e.UserCardRemark)
                    .HasColumnName("UserCard_Remark")
                    .HasMaxLength(80);

                entity.Property(e => e.UserCardSex)
                    .IsRequired()
                    .HasColumnName("UserCard_Sex");

                entity.Property(e => e.UserLoginId).HasColumnName("UserLogin_ID");

                entity.HasOne(d => d.UserLogin)
                    .WithMany(p => p.UserCard)
                    .HasForeignKey(d => d.UserLoginId)
                    .HasConstraintName("FK_User_Card_User_Login");
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.ToTable("User_Login");

                entity.HasIndex(e => e.UserLoginGuid)
                    .HasName("AlternateKey_User_Guid")
                    .IsUnique();

                entity.Property(e => e.UserLoginId).HasColumnName("UserLogin_ID");

                entity.Property(e => e.UserLoginCreatDt)
                    .HasColumnName("UserLogin_CreatDT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserLoginGuid)
                    .HasColumnName("UserLogin_Guid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UserLoginName)
                    .IsRequired()
                    .HasColumnName("UserLogin_Name")
                    .HasMaxLength(20);

                entity.Property(e => e.UserLoginPassWord)
                    .IsRequired()
                    .HasColumnName("UserLogin_PassWord")
                    .HasMaxLength(18);

                entity.Property(e => e.UserLoginState).HasColumnName("UserLogin_State");
            });
        }
    }
}
