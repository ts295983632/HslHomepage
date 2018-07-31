using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HslHomepage.Data
{
    public class DeviceTestItem
    {
        /// <summary>
        /// 规格型号
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// 测试人
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 测试日期
        /// </summary>
        public DateTime DateTime { get; set; }
    }



    public class DeviceTest
    {
        /// <summary>
        /// 协议
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// 使用的类列表
        /// </summary>
        public List<string> Classes { get; set; }

        /// <summary>
        /// 测试项列表
        /// </summary>
        public List<DeviceTestItem> TestItems { get; set; }
    }
}
