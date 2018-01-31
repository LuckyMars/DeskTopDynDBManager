using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskTopDynDBManager
{
    public class MyPipeline
    {
        public SearchCondition[] Conditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Projects { get; set; }

    }

    public class SearchCondition
    {
        /// <summary>
        /// 数据库字段名称
        /// </summary>
        public string FieldName { get; set; }
        /// <summary>
        /// 查询操作
        /// </summary>
        public EnumSearchOpera Opera { get; set; }
        /// <summary>
        /// 查询内容常量
        /// </summary>
        public object Constant { get; set; }
    }

    public enum EnumSearchOpera
    {
        包含,
        等于,
        不等于,
        大于,
        小于,
        大于等于,
        小于等于,
        多个等于
    }
}
