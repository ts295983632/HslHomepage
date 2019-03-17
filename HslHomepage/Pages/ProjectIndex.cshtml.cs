using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HslHomepage.Data;

namespace HslHomepage.Pages
{
    public class ProjectIndexModel : PageModel
    {
        public List<ProjectItem> ProjectItems { get; set; }

        public void OnGet()
        {
            ProjectItems = new List<ProjectItem>( )
            {
                new ProjectItem( )
                {
                    Name = "这是一个测试的项目信息",
                    PublishDate = new DateTime(2019,3,15),
                    Status = 1,
                    Details = "实现一个基本的数据采集和显示的功能",
                    Topics = new List<string>(){ "三菱PLC", "西门子PLC" },
                },
            };
        }
    }
}