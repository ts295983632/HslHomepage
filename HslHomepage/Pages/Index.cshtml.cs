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
        public string X = "";
        public string Y = "";
        public List<string> x_text = new List<string>( );
        public List<int> y_count = new List<int>( );

        public void OnGet()
        {
            HslHomepage.Data.StaticInfomation.AccessCount++;

            int i = (int)(DateTime.Now.Date - Data.StaticInfomation.start).TotalDays;
            lock (Data.StaticInfomation.Tmp)
            {
                ushort value = BitConverter.ToUInt16( Data.StaticInfomation.Tmp, i * 2 );
                value++;
                BitConverter.GetBytes( value ).CopyTo( Data.StaticInfomation.Tmp, i * 2 );

                int startIndex = i;
                for (int j = 0; j < 30; j++)
                {
                    x_text.Add( DateTime.Now.Date.AddDays( j - 29 ).Day.ToString( ) + "日" );
                    if (j < 29 - startIndex)
                    {
                        y_count.Add( 0 );
                    }
                    else
                    {
                        y_count.Add( BitConverter.ToUInt16( Data.StaticInfomation.Tmp, (startIndex + j - 29) * 2 ) );
                    }
                }

                for (int j = 0; j < 30; j++)
                {
                    if(j == 29)
                    {
                        X += "'" + x_text[j] + "'";
                        Y += y_count[j].ToString( );
                    }
                    else
                    {
                        X += "'" + x_text[j] + "',";
                        Y += y_count[j].ToString( ) + ",";
                    }
                }


                System.IO.File.WriteAllBytes( "Tmp.txt", Data.StaticInfomation.Tmp );
            }

            Utils.SoftUtils.NumericalOrder.GetLongOrder( );
        }
    }
}
