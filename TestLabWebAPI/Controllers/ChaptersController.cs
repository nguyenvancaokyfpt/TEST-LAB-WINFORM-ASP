using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestLabEntity.AutoDB;
using TestLabLibrary.Repository;
using TestLabWebAPI.Response;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestLabWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChaptersController : ControllerBase
    {
        private readonly IQuestionRepository _repository;
        private readonly IMapper _mapper;

        public ChaptersController(IQuestionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        // GET: api/<ChapterController>
        [HttpGet]
        public IEnumerable<TlChapterRes> Get()
        {
            var chapters = _repository.GetChapters();
            var chaptersRes = _mapper.Map<IEnumerable<TlChapterRes>>(chapters);
            return chaptersRes;
        }

        // GET api/<ChapterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ChapterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ChapterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ChapterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
