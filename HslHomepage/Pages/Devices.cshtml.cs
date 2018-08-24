using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HslHomepage.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HslHomepage.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }


        /// <summary>
        /// 三菱的Qna兼容3E
        /// </summary>
        public DeviceTest deviceMelsecMC { get; set; }
        /// <summary>
        /// 三菱的Qna兼容1E
        /// </summary>
        public DeviceTest deviceMelsec1E { get; set; }
        /// <summary>
        /// 三菱Fx串口协议
        /// </summary>
        public DeviceTest deviceMelsecFx { get; set; }
        /// <summary>
        /// 西门子s7
        /// </summary>
        public DeviceTest deviceSiemensS7 { get; set; }
        /// <summary>
        /// 西门子fetch/write协议
        /// </summary>
        public DeviceTest deviceSiemensFW { get; set; }
        /// <summary>
        /// 欧姆龙的fins协议
        /// </summary>
        public DeviceTest deviceOmronFins { get; set; }
        /// <summary>
        /// Modbus-Tcp协议
        /// </summary>
        public DeviceTest deviceModbusTcp { get; set; }
        /// <summary>
        /// Modbus-Rtu协议
        /// </summary>
        public DeviceTest deviceModbusRtu { get; set; }


        public ContactModel( )
        {
            deviceMelsecMC = new DeviceTest( )
            {
                Protocol = "Qna-3E",
                Classes = new List<string>( ) { "MelsecMcNet", "MelsecMcAsciiNet" },
                TestItems = new List<DeviceTestItem>( )
                {
                    new DeviceTestItem( )
                    {
                        Model = "QJ71E71-100",
                        Name = "杭州-Richard.Hu",
                        DateTime = new DateTime(2018,1,1),
                    },
                    new DeviceTestItem( )
                    {
                        Model = "Q02 PLC",
                        Name = "杭州-Richard.Hu",
                        DateTime = new DateTime(2018,07,30),
                    },
                    new DeviceTestItem( )
                    {
                        Model = "L02 PLC",
                        Name = "杭州-Richard.Hu",
                        DateTime = new DateTime(2018,07,30),
                    },
                    new DeviceTestItem( )
                    {
                        Model = "Q06UDV PLC",
                        Name = "泉州-hwdq0012",
                        DateTime = new DateTime(2018,8,24),
                    },
                    new DeviceTestItem( )
                    {
                        Model = "Fx5u PLC",
                        Name = "山楂",
                        DateTime = new DateTime(2018,8,24),
                    }
                }
            };
            deviceMelsec1E = new DeviceTest( )
            {
                Protocol = "Qna-1E",
                Classes = new List<string>( ) { "MelsecA1ENet" },
                TestItems = new List<DeviceTestItem>( )
                {
                    new DeviceTestItem( )
                    {
                        Model = "Fx 3U",
                        Name = "Unknown",
                        DateTime = new DateTime(2018,07,30),
                    }
                }
            };
            deviceMelsecFx = new DeviceTest( )
            {
                Protocol = "Fx串口协议",
                Classes = new List<string>( ) { "MelsecFxSerial" },
                TestItems = new List<DeviceTestItem>( )
                {
                    new DeviceTestItem( )
                    {
                        Model = "Fx 3U",
                        Name = "江阴-  ∮溪风-⊙_⌒",
                        DateTime = new DateTime(2018, 08,24),
                    }
                }
            };
            deviceSiemensS7 = new DeviceTest( )
            {
                Protocol = "S7",
                Classes = new List<string>( ) { "SiemensS7Net" },
                TestItems = new List<DeviceTestItem>( )
                {
                    new DeviceTestItem( )
                    {
                        Model = "1215C",
                        Name = "Richard.Hu",
                        DateTime = new DateTime(2018,07,30),
                    },
                }
            };
            deviceSiemensFW = new DeviceTest( )
            {
                Protocol = "Fetch/Write",
                Classes = new List<string>( ) { "SiemensFetchWriteNet" },
                TestItems = new List<DeviceTestItem>( )
                {
                    new DeviceTestItem( )
                    {
                        Model = "s7-314",
                        Name = "Richard.Hu",
                        DateTime = new DateTime(2018,07,30),
                    },
                }
            };
            deviceOmronFins = new DeviceTest( )
            {
                Protocol = "Fins-Tcp",
                Classes = new List<string>( ) { "OmronFinsNet" },
                TestItems = new List<DeviceTestItem>( )
                {
                    new DeviceTestItem( )
                    {
                        Model = "example",
                        Name = "Richard.Hu",
                        DateTime = new DateTime(2018,07,30),
                    },
                }
            };
            deviceModbusTcp = new DeviceTest( )
            {
                Protocol = "Modbus-Tcp",
                Classes = new List<string>( ) { "ModbusTcpNet" },
                TestItems = new List<DeviceTestItem>( )
                {
                    new DeviceTestItem( )
                    {
                        Model = "Siemens 1215C",
                        Name = "Richard.Hu",
                        DateTime = new DateTime(2018,07,30),
                    },
                }
            };
            deviceModbusRtu = new DeviceTest( )
            {
                Protocol = "Modbus-Rtu",
                Classes = new List<string>( ) { "ModbusRtu" },
                TestItems = new List<DeviceTestItem>( )
                {
                    new DeviceTestItem( )
                    {
                        Model = "伺服驱动器",
                        Name = "Richard.Hu",
                        DateTime = new DateTime(2018,07,30),
                    },
                }
            };
        }


        public void OnGet()
        {
            Message = "Your contact page.";
        }
    }
}
