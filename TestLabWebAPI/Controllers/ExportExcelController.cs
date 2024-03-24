using AutoMapper;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestLabWebAPI.Models;

namespace TestLabWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportExcelController : ControllerBase
    {
        private readonly TracNghiemOnlineContext _context;
        private readonly IMapper _mapper;

        public ExportExcelController(TracNghiemOnlineContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        private IActionResult SendExcel(XLWorkbook wb, string filename)
        {
            var stream = new MemoryStream();
            wb.SaveAs(stream);
            stream.Position = 0;

            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", filename);
        }

        [HttpGet("ClassStudents/{classId}")]
        public IActionResult ExportStudentListOfAClass(int classId)
        {
            var @class = _context.Classes.Find(classId);
            if (@class == null)
            {
                return NotFound("Class with id " + classId + " not found.");
            }
            var students = _context.Students.Where(s => s.IdClass == classId).ToList();

            using var wb = new XLWorkbook();

            var sheet = wb.AddWorksheet(@class.ClassName);
            
            // Add header
            sheet.Cell(1, 1).Value = "ID";
            sheet.Cell(1, 2).Value = "Name";
            sheet.Cell(1, 3).Value = "Email";
            sheet.Cell(1, 4).Value = "Birthday";
            sheet.Cell(1, 5).Value = "Gender";
            sheet.Cell(1, 6).Value = "Phone";

            // Add data
            for (int i = 0; i < students.Count; i++)
            {
                sheet.Cell(i + 2, 1).Value = students[i].IdStudent;
                sheet.Cell(i + 2, 2).Value = students[i].Name;
                sheet.Cell(i + 2, 3).Value = students[i].Email;
                sheet.Cell(i + 2, 4).Value = students[i].Birthday.Value.ToShortDateString();
                sheet.Cell(i + 2, 5).Value = students[i].Gender;
                sheet.Cell(i + 2, 6).Value = students[i].Phone;
            }

            // Get the last cell with data
            var lastCell = sheet.LastCellUsed();
            var table = sheet.Range(sheet.Cell(1, 1), lastCell).CreateTable();
            table.Theme = XLTableTheme.TableStyleMedium9;

            return SendExcel(wb, @class.ClassName + ".xlsx");
        }

        [HttpGet("TestScores/{testCode}")]
        public IActionResult ExportTestScores(int testCode)
        {
            var test = _context.Tests
                .Include(t => t.IdSubjectNavigation)
                .FirstOrDefault(t => t.TestCode == testCode);
            if (test == null)
            {
                return NotFound("Test with code " + testCode + " not found.");
            }

            var scores = _context.Scores.Where(s => s.TestCode == testCode)
                .Include(s => s.IdStudentNavigation)
                .ToList();

            using var wb = new XLWorkbook();

            var sheet = wb.AddWorksheet(test.TestName);

            // Add header
            sheet.Cell(1, 1).Value = "ID";
            sheet.Cell(1, 2).Value = "Name";
            sheet.Cell(1, 3).Value = "Score";

            // Add data
            for (int i = 0; i < scores.Count; i++)
            {
                sheet.Cell(i + 2, 1).Value = scores[i].IdStudent;
                sheet.Cell(i + 2, 2).Value = scores[i].IdStudentNavigation.Name;
                sheet.Cell(i + 2, 3).Value = scores[i].ScoreNumber;
            }

            // Get the last cell with data
            var lastCell = sheet.LastCellUsed();
            var table = sheet.Range(sheet.Cell(1, 1), lastCell).CreateTable();
            table.Theme = XLTableTheme.TableStyleMedium9;

            return SendExcel(wb, test.TestName + ".xlsx");
        }
    }
}
