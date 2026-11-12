using Microsoft.AspNetCore.Mvc;
using PairProgrammingBackEnd;
using PairProgrammingBackEnd.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecordControllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        public IRecordRepository Repo { get; set; }


        public RecordController(IRecordRepository repo) { 
            Repo = repo;
        }

        // GET: api/<RecordController>
        [HttpGet]
        public IEnumerable<IRecord> Get()
        {
            return Repo.GetAllRecords();
        }

        // GET api/<RecordController>/5
        [HttpGet("{id}")]
        public IRecord Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/<RecordController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RecordController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RecordController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
