using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using CoreMVCTestDB;
using PassWord_Help;
using Microsoft.AspNetCore.Authentication.Cookies;
using CoreMVCTestMVC.Models;

namespace CoreMVCTestMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddDbContext<CoreMVCTestContext>(options =>
                   options.UseSqlServer(
                       Configuration.GetConnectionString("DefaultConnection")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            //services.Configure<WebSetting>(Configuration);
            #region 登录验证
            /*
            b.Cookie.Name：就是cookie的名字，对应第一小节谷歌浏览器截图的Name；
            b.LoginPath：设置登陆失败或者未登录授权的情况下，直接跳转的路径这里，这是/login；
            b.Cookie.Domain：指定cookie对应的域名，这里我没域名和没设置本地host所以屏蔽，屏蔽的或默认localhost；
            b.Cookie.HttpOnly：设置cookie只读情况；
            b.Cookie.Expiration：cookie过期时间；
             */
            //配置Authorrize
            services.AddAuthentication(b =>
            {
                b.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                b.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                b.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(b =>
            {
                //登陆地址
                b.LoginPath = "/login";
                //sid
                b.Cookie.Name = "My_SessionId";
                // b.Cookie.Domain = "shenniu.core.com";
                b.Cookie.Path = "/";
                b.Cookie.HttpOnly = true;
                b.Cookie.Expiration = new TimeSpan(0, 0, 30);

                b.ExpireTimeSpan = new TimeSpan(0, 0, 30);
            });
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            AddData();//初始化数据库
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                  );
            });
        }

        public void AddData()
        {
            using (var db = new CoreMVCTestContext())
            {
                db.Database.EnsureCreated();
                var user = db.Users.FirstOrDefault();
                if (user == null)
                {
                    user = new CoreMVCTestDB.Models.PublicModel.Users();
                    user.UserName = "jiaohaojie";
                    user.Email = "2351592225@qq.com";
                    user.NormalizedEmail = "2351592225@QQ.COM";
                    user.EmailConfirmed = true;
                    user.PasswordHash = PassWordHelp.MD5Encrypt16("000000");
                    db.Users.Add(user);
                }
                db.SaveChanges();

            }
        }
    }
}
