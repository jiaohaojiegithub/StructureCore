using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestDB.Models
{
    public class TodoItem
    {
        [Display(Name ="主键ID")]
        public long Id { get; set; }
        [Display(Name = "名字"),Required,DefaultValue("默认值")]
        public string name { get; set; }

        [Display(Name = "状态"),Required]
        public bool IsComplete { get; set; }
        
        public StateCode state { get; set; }

        [Column(TypeName = "int")]//显式类型装换
        public StateCode stateCode { get; set; }

    }
    /// <summary>
    /// 配置值转换器
    /// </summary>
    public enum StateCode:Int32
    {
        成功 = 1,
        失败 = 2,
        属性错误 = 3

    }
}
