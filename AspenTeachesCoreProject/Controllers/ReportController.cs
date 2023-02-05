using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace AspenTeachesCoreProject.Controllers
{
    public class ReportController : Controller
    {
        //Static Excel list
        public IActionResult Index()
        {
            ExcelPackage excelPackage = new ExcelPackage();
            var workSheet = excelPackage.Workbook.Worksheets.Add("Worksheet1");
            workSheet.Cells[1, 1].Value = "Intsructor ID";
            workSheet.Cells[1, 2].Value = "Intsructor Name";
            workSheet.Cells[1, 3].Value = "Intsructor Surname";

            workSheet.Cells[1, 1].Value = "1";
            workSheet.Cells[1, 2].Value = "Test";
            workSheet.Cells[1, 3].Value = "Test";

            return View();
        }
    }
}
