using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HslHomepage.Data
{
    public class ProjectItem
    {
        public string Name { get; set; }

        public DateTime PublishDate { get; set; }

        /// <summary>
        /// 1就是等待揭榜，2是已揭榜
        /// </summary>
        public int Status { get; set; }

        public string Details { get; set; }

        public List<string> Topics { get; set; }

        /// <summary>
        /// 预算
        /// </summary>
        public double Budgets { get; set; }

        public string GetBudgets()
        {
            if (Budgets <= 0) return "未填写";
            if (Budgets < 10000) return Budgets + " 元";
            if (Budgets < 100000) return (Budgets / 10000).ToString( "F1" ) + " 万元";
            return (Budgets / 10000).ToString( "F0" ) + " 万元";
        }
    }
}
