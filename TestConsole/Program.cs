using FileRead_Help;
using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"获取Json文件数据：{GetSetting.GetJsonConfig("MyTestResource.json").GetSection("ConnectionString:TestDb").Value}," +
                $"\n获取XML文件数据：{GetSetting.GetXmlConfig("XMLResource.xml").GetSection("ConnectionString:TestDb:value").Value}\n当前文件路径：{AppContext.BaseDirectory.ToString()}");
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
