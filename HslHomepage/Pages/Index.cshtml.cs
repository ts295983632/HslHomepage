using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HslHomepage.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            HslHomepage.Data.StaticInfomation.AccessCount++;

            int i = (int)(DateTime.Now.Date - Data.StaticInfomation.start).TotalDays;
            lock (Data.StaticInfomation.Tmp)
            {
                ushort value = BitConverter.ToUInt16( Data.StaticInfomation.Tmp, i * 2 );
                value++;
                BitConverter.GetBytes( value ).CopyTo( Data.StaticInfomation.Tmp, i * 2 );

                System.IO.File.WriteAllBytes( "Tmp.txt", Data.StaticInfomation.Tmp );
            }

            Utils.SoftUtils.NumericalOrder.GetLongOrder( );
        }
    }
}
