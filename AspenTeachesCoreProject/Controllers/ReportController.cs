using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspenTeachesCoreProject.Models;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace AspenTeachesCoreProject.Controllers
{
    [AllowAnonymous]
    public class ReportController : Controller
    {
        public IActionResult ReportList()
        {
            return View();
        }

        // static excel list
        public IActionResult StaticExcel()
        {
            ExcelPackage excelPackage = new ExcelPackage();
            var workSheet = excelPackage.Workbook.Worksheets.Add("Worksheet1");
            workSheet.Cells[1, 1].Value = "Intsructor ID";
            workSheet.Cells[1, 2].Value = "Intsructor Name";
            workSheet.Cells[1, 3].Value = "Intsructor Surname";

            workSheet.Cells[1, 1].Value = "0001";
            workSheet.Cells[1, 2].Value = "Deniz";
            workSheet.Cells[1, 3].Value = "Gök";

            var bytes = excelPackage.GetAsByteArray();
            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","instructors.xlsx");

        }

        public List<InstructorViewModel> InstructorList()
        {

            List<InstructorViewModel> instructorViewModels = new List<InstructorViewModel>();
            using (var context = new Context())
            {
                instructorViewModels = context.Instructors.Select(x => new InstructorViewModel
                {
                    Name = x.Name,
                    Surname = x.Surname,
                    Title = x.Title,
                    GithubUrl = x.GitHubUrl,
                    LinkedlnUrl = x.LinkedinUrl

                }).ToList();
            }
            return instructorViewModels;
        }

        // dynamic excel list
        public IActionResult DynamicExcel()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Instructor List");
                workSheet.Cell(1, 1).Value = "Name";
                workSheet.Cell(1, 2).Value = "Surname";
                workSheet.Cell(1, 3).Value = "Title";
                workSheet.Cell(1, 4).Value = "Github";
                workSheet.Cell(1, 5).Value = "Linkedln";

                int rowCount = 2;

                foreach(var item in InstructorList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.Name;
                    workSheet.Cell(rowCount, 2).Value = item.Surname;
                    workSheet.Cell(rowCount, 3).Value = item.Title;
                    workSheet.Cell(rowCount, 4).Value = item.GithubUrl;
                    workSheet.Cell(rowCount, 5).Value = item.LinkedlnUrl;
                    rowCount++;
                }
                using(var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "instructors.xlsx");
                }
            }
        }

        // static pdf
        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "Instructor.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            Paragraph paragraph = new Paragraph("Aspen Teaches - Pdf Report");
            document.Add(paragraph);
            document.Close();
            return File("/PdfReports/Instructor.pdf", "application/pdf", "Instructor.pdf"); 

        }
    }
}
