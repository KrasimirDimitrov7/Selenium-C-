using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp.Pages
{

    public class ReadXLS
    {
        public (List<string>, List<string>) ReadExcel(string path, int sheet = 0)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            FileInfo existingFile = new FileInfo(path);
            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                //get the first worksheet in the workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets[sheet];
                int colCount = worksheet.Dimension.End.Column;  //get Column Count
                int rowCount = worksheet.Dimension.End.Row;     //get row count
                List<string> list = new List<string>();

                for (int row = 1; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        //Console.WriteLine(" Row:" + row + " column:" + col + " Value:" + worksheet.Cells[row, col].Value?.ToString().Trim());
                        var test1 = worksheet.Cells[row, col].Value.ToString();
                        list.Add(test1);
                    }
                }

                List<string> data1 = new List<string>();
                List<string> data2 = new List<string>();

                for (int i = 0; i < list.Count; i++)
                {
                    if (i % 2 == 0) data1.Add(list[i]);
                    else data2.Add(list[i]);
                }
                return (data1, data2);               
            }
        }
    }
}
