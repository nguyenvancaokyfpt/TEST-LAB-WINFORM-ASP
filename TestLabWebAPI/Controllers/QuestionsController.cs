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
using TestLabWebAPI.Responses;

namespace TestLabWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly TracNghiemOnlineContext _context;
        private readonly IMapper _mapper;

        public QuestionsController(TracNghiemOnlineContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Questions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuestionRes>>> GetQuestions()
        {
            var questions = await _context.Questions
                .ToListAsync();
            var subjects = await _context.Subjects
                .ToListAsync();

            List<QuestionRes> res = new List<QuestionRes>();
            foreach (var question in questions)
            {
                var subject = subjects.Find(s => s.IdSubject == question.IdSubject);
                res.Add(new QuestionRes
                {
                    IdQuestion = question.IdQuestion,
                    Content = question.Content,
                    Unit = question.Unit,
                    ImgContent = question.ImgContent,
                    AnswerA = question.AnswerA,
                    AnswerB = question.AnswerB,
                    AnswerC = question.AnswerC,
                    AnswerD = question.AnswerD,
                    CorrectAnswer = question.CorrectAnswer,
                    SubjectName = subject.SubjectName
                });
            }

            return res;
        }


        // GET: api/Questions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Question>> GetQuestion(int id)
        {
            var question = await _context.Questions.FindAsync(id);

            if (question == null)
            {
                return NotFound();
            }

            return question;
        }

        // PUT: api/Questions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuestion(int id, QuestionDTO questionDTO)
        {
            var question = _context.Questions.Find(id);

            if (id != question.IdQuestion)
            {
                return BadRequest();
            }

            var oldImage = question.ImgContent;
            question = _mapper.Map(questionDTO, question);

            // if image64 is not null, update image and save to disk then delete the old image
            if (questionDTO.ImgBase64 != null)
            {
                byte[] image = Convert.FromBase64String(questionDTO.ImgBase64);
                // Save image to disk
                string imgName = Guid.NewGuid().ToString() + ".png";
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", imgName);
                // check if directory exists
                if (!Directory.Exists(Path.GetDirectoryName(path)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                System.IO.File.WriteAllBytes(path, image);
                question.ImgContent = imgName;
                // delete old image
                if (oldImage != null)
                {
                    string oldPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", oldImage);
                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);
                    }
                }
            }

            _context.Entry(question).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionExists(id))
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

        // POST: api/Questions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Question>> PostQuestion(QuestionDTO questionDTO)
        {
            var question = _mapper.Map<Question>(questionDTO);

            if (questionDTO.ImgBase64 != null)
            {
                byte[] image = Convert.FromBase64String(questionDTO.ImgBase64);
                // Save image to disk
                string imgName = Guid.NewGuid().ToString() + ".png";
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", imgName);
                // check if directory exists
                if (!Directory.Exists(Path.GetDirectoryName(path)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                System.IO.File.WriteAllBytes(path, image);
                question.ImgContent = imgName;
            }

            _context.Questions.Add(question);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuestion", new { id = question.IdQuestion }, question);
        }

        // DELETE: api/Questions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuestion(int id)
        {
            var question = await _context.Questions.FindAsync(id);
            if (question == null)
            {
                return NotFound();
            }

            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QuestionExists(int id)
        {
            return _context.Questions.Any(e => e.IdQuestion == id);
        }
    }
}
