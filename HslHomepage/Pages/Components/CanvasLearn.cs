using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HslHomepage.Pages.Components
{
    [ViewComponent(Name = "CanvasLearn" )]
    public class CanvasLearn : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync( string description )
        {
            return await Task.Run<IViewComponentResult>( ( ) => View<string>( description ) );
        }
    }
}
