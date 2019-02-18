#define Json //XML --使用不同的方式读取配置
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using TestDB.Models;

namespace TestDB
{
    public class TestContext:DbContext
    {
        public TestContext()
        {

        }
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {

        }

        public virtual DbSet<TodoItem> TodoItmes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("data source=118.24.129.186;initial catalog=DBMYBLOG;persist security info=True;user id=sa;password=fnhYSPK7FPjIg;MultipleActiveResultSets=True;");
                optionsBuilder.UseSqlServer("Server=.;Database=TestALL;Trusted_Connection=True;MultipleActiveResultSets=true");
                //ConfigurationManager.ConnectionStrings["BloggingDatabase"].ConnectionString
#if (Json)
                #region 使用Json读取配置文件
                optionsBuilder.UseSqlServer(GetSetting.GetJsonConfig("JsonResource.json").GetSection("ConnectionString:TestDb").Value);

                #endregion
#elif (XML)
                #region 使用XML读取配置文件
                optionsBuilder.UseSqlServer(GetSetting.GetXmlConfig("XMLResource.xml").GetSection("ConnectionString:TestDb:value").Value);
                #endregion
#endif
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
#region 验证模型
            builder.Entity<TodoItem>(entity =>
            {
                entity.ToTable("TodoItme_StartOne");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.IsComplete).HasColumnType("bit").HasDefaultValue(1);//默认值
#region 枚举类型装换
                ////方法一
                //entity.Property(e => e.state).HasConversion(v => v.ToString(), v => (StateCode)Enum.Parse(typeof(StateCode), v));//枚举类型装换
                ////方法二
                //var converter = new ValueConverter<StateCode, string>(v => v.ToString(), v => (StateCode)Enum.Parse(typeof(StateCode), v));
                //entity.Property(e => e.state).HasConversion(converter);
                //方法三
                var converter1 = new EnumToStringConverter<StateCode>();
                entity.Property(e => e.state).HasConversion(converter1);
#endregion
            });
#endregion

        }
    }
}
