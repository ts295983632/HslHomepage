using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HslHomepage.Pages.Components
{
    [ViewComponent( Name = "Division" )]
    public class DivisionViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync( string description )
        {
            return await Task.Run<IViewComponentResult>( ( ) => View<string>( description ) );
        }
        
    }
}
