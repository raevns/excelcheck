using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace excelcheck.service
{
    class excelService
    {
        public static int ExcelColumsRow(string file_name)
        {
            int c_rows = 0;

            Application excelApp = null;
            Workbook wb = null;
            Worksheet ws = null;
            Range wRng = null;

            try
            {
                excelApp = new Application();
                wb = excelApp.Workbooks.Open(file_name);
                ws = wb.Worksheets.get_Item(1) as Worksheet;
                wRng = ws.UsedRange;

                c_rows = wRng.Columns.Count;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                Marshal.ReleaseComObject(wRng);
                Marshal.ReleaseComObject(ws);
                wb.Close();
                Marshal.ReleaseComObject(wb);
                excelApp.Quit();
                Marshal.ReleaseComObject(excelApp);
            }
            return c_rows;
        }
    }
}
