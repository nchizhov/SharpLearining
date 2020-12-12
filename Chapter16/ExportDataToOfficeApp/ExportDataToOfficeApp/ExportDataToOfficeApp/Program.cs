using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExportDataToOfficeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carsInStock = new List<Car>
            {
                new Car {Color = "Green", Make = "VW", PetName = "Mary"},
                new Car {Color = "Red", Make = "Saab", PetName = "Mel"},
                new Car {Color = "Black", Make = "Ford", PetName = "Hank"},
                new Car {Color = "Yellow", Make = "BMW", PetName = "Davie"}
            };
            ExportToExcel(carsInStock);
            Console.ReadLine();
        }

        static void ExportToExcel(List<Car> carsInStock)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = excelApp.ActiveSheet;
            workSheet.Cells[1, "A"] = "Make";
            workSheet.Cells[1, "B"] = "Color";
            workSheet.Cells[1, "C"] = "PetName";
            int row = 1;
            foreach (Car c in carsInStock)
            {
                row++;
                workSheet.Cells[row, "A"] = c.Make;
                workSheet.Cells[row, "B"] = c.Color;
                workSheet.Cells[row, "C"] = c.PetName;
            }
            workSheet.Range["A1"].AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);
            workSheet.SaveAs($@"{Environment.CurrentDirectory}\Inventory.xlsx");
            excelApp.Quit();
            Console.WriteLine("The Inventory.xslx file has been saved in your app folder");
        }

        static void ExportToExcelManual(List<Car> carsInStock)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add(Type.Missing);
            Excel._Worksheet workSheet = (Excel._Worksheet)excelApp.ActiveSheet;
            ((Excel.Range)excelApp.Cells[1, "A"]).Value2 = "Make";
            ((Excel.Range)excelApp.Cells[1, "B"]).Value2 = "Color";
            ((Excel.Range)excelApp.Cells[1, "C"]).Value2 = "PetName";
            int row = 1;
            foreach (Car c in carsInStock)
            {
                row++;
                ((Excel.Range)excelApp.Cells[row, "A"]).Value2 = c.Make;
                ((Excel.Range)excelApp.Cells[row, "B"]).Value2 = c.Color;
                ((Excel.Range)excelApp.Cells[row, "C"]).Value2 = c.PetName;
            }
            excelApp.get_Range("A1", Type.Missing).AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            workSheet.SaveAs($@"{Environment.CurrentDirectory}\InventoryManual.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            excelApp.Quit();
            Console.WriteLine("The InventoryManual.xslx file has been saved in your app folder");
        }
    }
}
