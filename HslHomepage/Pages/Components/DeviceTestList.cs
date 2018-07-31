using HslHomepage.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HslHomepage.Pages.Components
{
    [ViewComponent(Name = "DeviceTestList" )]
    public class DeviceTestList : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync( DeviceTest deviceTest)
        {
            return await Task.Run<IViewComponentResult>( ( ) => View( deviceTest ) );
        }
        
    }
}
