using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestLabWebAPI.DTOs;
using TestLabWebAPI.Models;

namespace TestLabWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentTestDetailsController : ControllerBase
    {
        private readonly TracNghiemOnlineContext _context;
        private readonly IMapper _mapper;

        public StudentTestDetailsController(TracNghiemOnlineContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/StudentTestDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentTestDetail>>> GetStudentTestDetails()
        {
            return await _context.StudentTestDetails.ToListAsync();
        }

        // GET: api/StudentTestDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentTestDetail>> GetStudentTestDetail(int id)
        {
            var studentTestDetail = _context.StudentTestDetails.FirstOrDefault(td => td.Id == id);

            if (studentTestDetail == null)
            {
                return NotFound();
            }

            return studentTestDetail;
        }

        // PUT: api/StudentTestDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentTestDetail(int id, StudentTestDetailDTO studentTestDetailDTO)
        {
            var studentTestDetail = _mapper.Map<StudentTestDetail>(studentTestDetailDTO);
            studentTestDetail.IdStudent = id;
            _context.Entry(studentTestDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentTestDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/StudentTestDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StudentTestDetail>> PostStudentTestDetail(StudentTestDetailDTO studentTestDetailDTO)
        {
            var studentTestDetail = _mapper.Map<StudentTestDetail>(studentTestDetailDTO);
            _context.StudentTestDetails.Add(studentTestDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StudentTestDetailExists(studentTestDetail.IdStudent))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStudentTestDetail", new { id = studentTestDetail.IdStudent }, studentTestDetail);
        }

        // DELETE: api/StudentTestDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentTestDetail(int id)
        {
            var studentTestDetail = _context.StudentTestDetails.FirstOrDefault(td => td.Id == id);
            if (studentTestDetail == null)
            {
                return NotFound();
            }

            _context.StudentTestDetails.Remove(studentTestDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentTestDetailExists(int id)
        {
            return _context.StudentTestDetails.Any(e => e.IdStudent == id);
        }
    }
}
