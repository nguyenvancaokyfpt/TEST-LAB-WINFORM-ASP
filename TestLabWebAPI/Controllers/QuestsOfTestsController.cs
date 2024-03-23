using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestLabWebAPI.Models;

namespace TestLabWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestsOfTestsController : ControllerBase
    {
        private readonly TracNghiemOnlineContext _context;

        public QuestsOfTestsController(TracNghiemOnlineContext context)
        {
            _context = context;
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

        // PUT: api/QuestsOfTests/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuestsOfTest(int id, QuestsOfTest questsOfTest)
        {
            if (id != questsOfTest.Id)
            {
                return BadRequest();
            }

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
        public async Task<ActionResult<QuestsOfTest>> PostQuestsOfTest(QuestsOfTest questsOfTest)
        {
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
