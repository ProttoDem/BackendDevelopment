using Domain;
using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendLab.Controllers
{
    [Route("[controller]/[action]/{id?}")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        [HttpPost]
        public ActionResult CreateRecord([FromBody] Record record)
        {
            RecordRepository recordRepository = RecordRepository.GetInstance();
            recordRepository.AddNewRecord(record);
            return Ok($"Added new record with sum: {record.Sum}");
        }

        [HttpGet]
        public ActionResult<Record> GetRecord(int id)
        {
            RecordRepository recordRepository = RecordRepository.GetInstance();
            return Ok(recordRepository.Record(id));
        }

        [HttpGet]
        public ActionResult<List<Record>> GetRecords()
        {
            RecordRepository recordRepository = RecordRepository.GetInstance();
            return Ok(recordRepository.Records());
        }

        [HttpGet("{userId}")]
        public ActionResult<List<Record>> GetRecords(int userId)
        {
            RecordRepository recordRepository = RecordRepository.GetInstance();                        
            return Ok(recordRepository.RecordsByUserId(userId));
        }

        [HttpGet("{userId}/{categoryId}")]
        public ActionResult<List<Record>> GetRecords(int userId, int categoryId)
        {
            RecordRepository recordRepository = RecordRepository.GetInstance();            
            return Ok(recordRepository.RecordsByCategoryIdAndUserId(categoryId, userId));
        }

    }
}
