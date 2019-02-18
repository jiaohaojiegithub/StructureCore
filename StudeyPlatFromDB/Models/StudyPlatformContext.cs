using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StudeyPlatFromDB.Models
{
    public partial class StudyPlatformContext : DbContext
    {
        public StudyPlatformContext()
        {
        }

        public StudyPlatformContext(DbContextOptions<StudyPlatformContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SAddress> SAddress { get; set; }
        public virtual DbSet<SAnswer> SAnswer { get; set; }
        public virtual DbSet<SAnswersub> SAnswersub { get; set; }
        public virtual DbSet<SCategory> SCategory { get; set; }
        public virtual DbSet<SComment> SComment { get; set; }
        public virtual DbSet<SCommentReply> SCommentReply { get; set; }
        public virtual DbSet<SCourse> SCourse { get; set; }
        public virtual DbSet<SDepot> SDepot { get; set; }
        public virtual DbSet<SEntryForm> SEntryForm { get; set; }
        public virtual DbSet<SEntryTime> SEntryTime { get; set; }
        public virtual DbSet<SFeedBack> SFeedBack { get; set; }
        public virtual DbSet<SGoods> SGoods { get; set; }
        public virtual DbSet<SGrade> SGrade { get; set; }
        public virtual DbSet<SGradeType> SGradeType { get; set; }
        public virtual DbSet<SIntegral> SIntegral { get; set; }
        public virtual DbSet<SIntegralRole> SIntegralRole { get; set; }
        public virtual DbSet<SManager> SManager { get; set; }
        public virtual DbSet<SMenu> SMenu { get; set; }
        public virtual DbSet<SMobileCode> SMobileCode { get; set; }
        public virtual DbSet<SNotice> SNotice { get; set; }
        public virtual DbSet<SOrder> SOrder { get; set; }
        public virtual DbSet<SReadInfo> SReadInfo { get; set; }
        public virtual DbSet<SRole> SRole { get; set; }
        public virtual DbSet<SRoleMenu> SRoleMenu { get; set; }
        public virtual DbSet<SSubject> SSubject { get; set; }
        public virtual DbSet<STestPaper> STestPaper { get; set; }
        public virtual DbSet<SToken> SToken { get; set; }
        public virtual DbSet<SUserAction> SUserAction { get; set; }
        public virtual DbSet<SUserInfo> SUserInfo { get; set; }
        public virtual DbSet<SUserRole> SUserRole { get; set; }
        public virtual DbSet<SUserType> SUserType { get; set; }
        public virtual DbSet<SVideoInfo> SVideoInfo { get; set; }
        public virtual DbSet<SWxbase> SWxbase { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*
                 Server=.;Database=aspnet-CoreMVC-3177353B-1D03-4DBB-A31E-03685718729D;Trusted_Connection=True;MultipleActiveResultSets=true
                 */
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("data source=192.168.0.81;initial catalog=StudyPlatform;persist security info=True;user id=sa;password=gmxy@as1;MultipleActiveResultSets=True;");
                optionsBuilder.UseSqlServer("Server=.;Database=StudyPlatform;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<SAddress>(entity =>
            {
                entity.ToTable("S_Address");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Areaid)
                    .HasColumnName("areaid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isdefault).HasColumnName("isdefault");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode)
                    .HasColumnName("postcode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Update)
                    .HasColumnName("update")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SAnswer>(entity =>
            {
                entity.ToTable("S_Answer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ischeck).HasColumnName("ischeck");

                entity.Property(e => e.Istest).HasColumnName("istest");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sumscore).HasColumnName("sumscore");

                entity.Property(e => e.Testpaperid).HasColumnName("testpaperid");

                entity.Property(e => e.Testtime).HasColumnName("testtime");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SAnswersub>(entity =>
            {
                entity.ToTable("S_Answersub");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Answer)
                    .HasColumnName("answer")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Answerid).HasColumnName("answerid");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ischeck).HasColumnName("ischeck");

                entity.Property(e => e.Isright).HasColumnName("isright");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Subjectid).HasColumnName("subjectid");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SCategory>(entity =>
            {
                entity.ToTable("S_Category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Categoryname)
                    .HasColumnName("categoryname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Cruid)
                    .HasColumnName("cruid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Parentid).HasColumnName("parentid");

                entity.Property(e => e.Permit)
                    .HasColumnName("permit")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<SComment>(entity =>
            {
                entity.ToTable("S_Comment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(4000);

                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Integral).HasColumnName("integral");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SCommentReply>(entity =>
            {
                entity.ToTable("S_CommentReply");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Commentid).HasColumnName("commentid");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(4000);

                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Integral).HasColumnName("integral");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SCourse>(entity =>
            {
                entity.ToTable("S_Course");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bgimg)
                    .HasColumnName("bgimg")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Cruid)
                    .HasColumnName("cruid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fileurl)
                    .HasColumnName("fileurl")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Permit)
                    .HasColumnName("permit")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Readnum).HasColumnName("readnum");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50);

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Update)
                    .HasColumnName("update")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upuid)
                    .HasColumnName("upuid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Videoimg)
                    .HasColumnName("videoimg")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SDepot>(entity =>
            {
                entity.ToTable("S_Depot");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepotName)
                    .HasColumnName("depotName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SEntryForm>(entity =>
            {
                entity.ToTable("S_EntryForm");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Depotname)
                    .HasColumnName("depotname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Timeid).HasColumnName("timeid");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SEntryTime>(entity =>
            {
                entity.ToTable("S_EntryTime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SFeedBack>(entity =>
            {
                entity.ToTable("S_FeedBack");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(1000);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isreply).HasColumnName("isreply");

                entity.Property(e => e.Reply)
                    .HasColumnName("reply")
                    .HasMaxLength(1000);

                entity.Property(e => e.Replydate)
                    .HasColumnName("replydate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Replyname)
                    .HasColumnName("replyname")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SGoods>(entity =>
            {
                entity.ToTable("S_Goods");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExchangeTime)
                    .HasColumnName("exchangeTime")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Goodsimg)
                    .HasColumnName("goodsimg")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Goodsname)
                    .HasColumnName("goodsname")
                    .HasMaxLength(200);

                entity.Property(e => e.Integral).HasColumnName("integral");

                entity.Property(e => e.Online).HasColumnName("online");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<SGrade>(entity =>
            {
                entity.ToTable("S_Grade");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Allcourse).HasColumnName("allcourse");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Feedback).HasColumnName("feedback");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.Gradename)
                    .HasColumnName("gradename")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Greenhand).HasColumnName("greenhand");

                entity.Property(e => e.Professionalknowledge).HasColumnName("professionalknowledge");

                entity.Property(e => e.Reg).HasColumnName("reg");

                entity.Property(e => e.Reply).HasColumnName("reply");

                entity.Property(e => e.Salesskill).HasColumnName("salesskill");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SGradeType>(entity =>
            {
                entity.ToTable("S_GradeType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.Gradename)
                    .HasColumnName("gradename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Staus)
                    .HasColumnName("staus")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SIntegral>(entity =>
            {
                entity.ToTable("S_Integral");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(100);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Integral).HasColumnName("integral");

                entity.Property(e => e.Relateid).HasColumnName("relateid");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SIntegralRole>(entity =>
            {
                entity.ToTable("S_IntegralRole");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Integral).HasColumnName("integral");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rolename)
                    .HasColumnName("rolename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SManager>(entity =>
            {
                entity.ToTable("S_Manager");

                entity.HasIndex(e => e.Uid)
                    .HasName("UQ__s_Manage__DD701265117F9D94")
                    .IsUnique();

                entity.HasIndex(e => e.Userid)
                    .HasName("UQ__s_Manage__CBA1B2560EA330E9")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Headimgurl)
                    .HasColumnName("headimgurl")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SMenu>(entity =>
            {
                entity.ToTable("S_Menu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Cruid)
                    .HasColumnName("cruid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Imgurl)
                    .HasColumnName("imgurl")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Menuname)
                    .HasColumnName("menuname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<SMobileCode>(entity =>
            {
                entity.ToTable("S_MobileCode");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SNotice>(entity =>
            {
                entity.ToTable("S_Notice");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(1000);

                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Readdate)
                    .HasColumnName("readdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Relateid).HasColumnName("relateid");

                entity.Property(e => e.Replyuid)
                    .HasColumnName("replyuid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unread).HasColumnName("unread");
            });

            modelBuilder.Entity<SOrder>(entity =>
            {
                entity.ToTable("S_Order");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Addressid).HasColumnName("addressid");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Goodsid).HasColumnName("goodsid");

                entity.Property(e => e.Goodsname)
                    .HasColumnName("goodsname")
                    .HasMaxLength(200);

                entity.Property(e => e.Integral).HasColumnName("integral");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Step).HasColumnName("step");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SReadInfo>(entity =>
            {
                entity.ToTable("S_ReadInfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lastdate)
                    .HasColumnName("lastdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Readtime).HasColumnName("readtime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Times).HasColumnName("times");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SRole>(entity =>
            {
                entity.ToTable("S_Role");

                entity.HasIndex(e => e.Rolename)
                    .HasName("UQ__s_Role__4685A0621FCDBCEB")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Cruid)
                    .HasColumnName("cruid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rolename)
                    .HasColumnName("rolename")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<SRoleMenu>(entity =>
            {
                entity.ToTable("S_RoleMenu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Cruid)
                    .HasColumnName("cruid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Menuid).HasColumnName("menuid");

                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<SSubject>(entity =>
            {
                entity.ToTable("S_Subject");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Option)
                    .HasColumnName("option")
                    .HasMaxLength(500);

                entity.Property(e => e.Right)
                    .HasColumnName("right")
                    .HasMaxLength(500);

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Testpaperid).HasColumnName("testpaperid");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<STestPaper>(entity =>
            {
                entity.ToTable("S_TestPaper");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bgimg)
                    .HasColumnName("bgimg")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isaward)
                    .HasColumnName("isaward")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Isend)
                    .HasColumnName("isend")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Papertime).HasColumnName("papertime");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SToken>(entity =>
            {
                entity.ToTable("S_Token");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Update)
                    .HasColumnName("update")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SUserAction>(entity =>
            {
                entity.ToTable("S_UserAction");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Elapsedtime).HasColumnName("elapsedtime");

                entity.Property(e => e.Pagename)
                    .HasColumnName("pagename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Telversion)
                    .HasColumnName("telversion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SUserInfo>(entity =>
            {
                entity.ToTable("S_UserInfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllIntegral).HasColumnName("all_integral");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Commentnum).HasColumnName("commentnum");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Depotid)
                    .HasColumnName("depotid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depotname)
                    .HasColumnName("depotname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Feedbacknum).HasColumnName("feedbacknum");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.Headimgurl)
                    .HasColumnName("headimgurl")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Isreg)
                    .HasColumnName("isreg")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nickname)
                    .HasColumnName("nickname")
                    .HasMaxLength(50);

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RealIntegral).HasColumnName("real_integral");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Replynum).HasColumnName("replynum");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unionid)
                    .HasColumnName("unionid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Upuid)
                    .HasColumnName("upuid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50);

                entity.Property(e => e.Usertype)
                    .HasColumnName("usertype")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SUserRole>(entity =>
            {
                entity.ToTable("S_UserRole");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Cruid)
                    .HasColumnName("cruid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Roleid)
                    .HasColumnName("roleid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SUserType>(entity =>
            {
                entity.ToTable("S_UserType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Typename)
                    .HasColumnName("typename")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SVideoInfo>(entity =>
            {
                entity.ToTable("S_VideoInfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Crdate)
                    .HasColumnName("crdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Iswatchsure).HasColumnName("iswatchsure");

                entity.Property(e => e.Lastdate)
                    .HasColumnName("lastdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sumwatchtime).HasColumnName("sumwatchtime");

                entity.Property(e => e.Times).HasColumnName("times");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Videoname)
                    .HasColumnName("videoname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SWxbase>(entity =>
            {
                entity.ToTable("S_WXbase");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Appid)
                    .HasColumnName("appid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Appsecret)
                    .HasColumnName("appsecret")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tab).HasColumnName("tab");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Update)
                    .HasColumnName("update")
                    .HasColumnType("datetime");
            });
        }
    }
}
