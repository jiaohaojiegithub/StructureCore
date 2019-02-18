using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StructureCore.JSONModel;
using StructureCore.Models;

namespace StructureCore.Controllers
{
    public class HomeController : Controller
    {
        public readonly IOptions<ConnectionStrings> connection;
        private readonly erp_baseContext _context;
        public HomeController(IOptions<ConnectionStrings> optionAccessor,erp_baseContext context)
        {
            connection = optionAccessor;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            #region 获取json配置文件的两种方法
            //直接读取文件
            
            string ConfigPath = Environment.CurrentDirectory + @"\appsettings.json";//IIS配置
            ConfigPath = $@"E:\projectAll\StructureCore\StructureCore\appsettings.json";
            string json = System.IO.File.ReadAllText(ConfigPath, Encoding.Default);
            JObject jsonConfig = (JObject)JsonConvert.DeserializeObject(json);
            string value = jsonConfig["ConnectionStrings"]["DefaultConnection"].ToString();
            //通过依赖注入获取
            string str = connection.Value.CoreMVCConnection;
            //读取文件
            IConfiguration Configuration;
            Configuration = new ConfigurationBuilder()
            .Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true })
            .Build();
            string x = Configuration.GetConnectionString("DefaultConnection");
            #endregion
            //return Content(value);
            //return View();
            return Json(_context.HmBaseFabric.ToList());
            //using (var db = new erp_baseContext())
            //{
            //    return View(db.HmBaseFabric.ToList());
            //}
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
