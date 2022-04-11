using OfficeOpenXml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OfficeOpenXml.Style;
using System.IO;
using System.Linq;
using System.Threading;

namespace ConsoleApp.Pages
{
    
    public partial class AddMachine
    {

        public void FillInMachineDataWithExel()
        {
            var exel = new ReadXLS();
            var data = exel.ReadExcel(@"C:\Users\Krasi\Desktop\TestData.xlsx");
            var names = data.Item1;
            var descr = data.Item2;

            MachinesBtn.Click();
            for (int i = 0; i < names.Count; i++)
            {
                Thread.Sleep(2000);
                AddMachineBtn.Click();
                MachineName.SendKeys(names[i]);
                MachineLocation.SendKeys(descr[i]);
                MachineDescription.SendKeys("This machine is for coffee");
                AddMachineBtnInPopUp.Click();
            }
        }

        public void FillIn61Machines()
        {
            MachinesBtn.Click();
            for (int i = 1000; i < 1061; i++)
            {
                Thread.Sleep(1000);
                AddMachineBtn.Click();
                MachineName.SendKeys(i.ToString());
                MachineLocation.SendKeys(i.ToString());
                MachineDescription.SendKeys("This machine is for coffee");
                AddMachineBtnInPopUp.Click();
            }
        }
        public void Delete61Machines()
        {
            MachinesBtn.Click();
            for (int i = 1000; i < 1061; i++)
            {
                Thread.Sleep(2000);
                DelеteMachineTrashIcon.Click();
                DeleteMachineBtn.Click();
            }
        }
    }
}






































//public static string TestDataFileConnection()
//{
//    var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
//    path = path.Substring(6) + @"\Data\TestData.xlsx";
//    var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", path);
//    return con;
//}

//[DynamicData(nameof(ReadExcel), DynamicDataSourceType.Method)]
//[TestMethod]

//public void DataDrivenTestingUsingExcelSheet(string name, string desc)
//{

//}
//public static IEnumerable<object[]> ReadExel()
//{
//    //Create worksheet object
//    using ExcelPackage package = new ExcelPackage(new System.IO.FileInfo("TestData.xlsx"));
//    ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
//    int rowCount = worksheet.Dimension.End.Row;

//    for (int i = 1; i <= rowCount; i++)
//    {
//        yield return new object[]
//        {
//                worksheet.Cells[i,1].Value?.ToString().Trim(), //Name
//                worksheet.Cells[i,2].Value?.ToString().Trim(), //Desc
//                                                               //worksheet.Cells[i,3].Value?.ToString().Trim(),
//        };
//    }
//}
