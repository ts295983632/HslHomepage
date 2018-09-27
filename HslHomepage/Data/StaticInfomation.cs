using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HslHomepage.Data
{
    public static class StaticInfomation
    {
        static StaticInfomation( )
        {
            if (System.IO.File.Exists( "Tmp.txt" ))
            {
                Tmp = System.IO.File.ReadAllBytes( "Tmp.txt" );
            }
            else
            {
                System.IO.File.WriteAllBytes( "Tmp.txt", Tmp );
            }
        }

        public static int AccessCount { get; set; } = 0;

        public static DateTime start = new DateTime( 2018, 9, 27 );
        public static byte[] Tmp = new byte[10000];

    }
}
