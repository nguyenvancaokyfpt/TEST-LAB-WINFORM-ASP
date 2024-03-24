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
    public class QuestsOfTestsController : ControllerBase
    {
        private readonly TracNghiemOnlineContext _context;
        private readonly IMapper _mapper;

        public QuestsOfTestsController(TracNghiemOnlineContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/QuestsOfTests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuestsOfTest>>> GetQuestsOfTests()
        {
            return await _context.QuestsOfTests.ToListAsync();
        }

        // GET: api/QuestsOfTests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QuestsOfTest>> GetQuestsOfTest(int id)
        {
            var questsOfTest = await _context.QuestsOfTests.FindAsync(id);

            if (questsOfTest == null)
            {
                return NotFound();
            }

            return questsOfTest;
        }

        // GET: api/QuestsOfTests/GetQuestsByTestCode/5
        [HttpGet("GetQuestsByTestCode/{code}")]
        public async Task<ActionResult<IEnumerable<QuestsOfTest>>> GetQuestsByTestId(int code)
        {
            var questsOfTest = await _context.QuestsOfTests.Where(q => q.TestCode == code).ToListAsync();

            if (questsOfTest == null)
            {
                return NotFound();
            }

            return questsOfTest;
        }

        // PUT: api/QuestsOfTests/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuestsOfTest(int id, QuestsOfTestDTO questsOfTestDTO)
        {
            var questsOfTest = _context.QuestsOfTests.Find(id);

            if (id != questsOfTest.Id)
            {
                return BadRequest();
            }

            questsOfTest = _mapper.Map(questsOfTestDTO, questsOfTest);

            _context.Entry(questsOfTest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestsOfTestExists(id))
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

        // POST: api/QuestsOfTests
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<QuestsOfTest>> PostQuestsOfTest(QuestsOfTestDTO questsOfTestDTO)
        {
            var questsOfTest = _mapper.Map<QuestsOfTest>(questsOfTestDTO);
            _context.QuestsOfTests.Add(questsOfTest);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuestsOfTest", new { id = questsOfTest.Id }, questsOfTest);
        }

        // DELETE: api/QuestsOfTests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuestsOfTest(int id)
        {
            var questsOfTest = await _context.QuestsOfTests.FindAsync(id);
            if (questsOfTest == null)
            {
                return NotFound();
            }

            _context.QuestsOfTests.Remove(questsOfTest);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QuestsOfTestExists(int id)
        {
            return _context.QuestsOfTests.Any(e => e.Id == id);
        }
    }
}
