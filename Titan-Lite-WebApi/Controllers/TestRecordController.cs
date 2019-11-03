using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Titan.Data;
using Titan.Data.Entities;

namespace Titan_Lite_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestRecordController : ControllerBase
    {
        private readonly ILogger<TestRecordController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public TestRecordController(ILogger<TestRecordController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult Get()
        {
            IEnumerable<TestRecord> testRecords;
            _dbContext.TestRecords.Add(new TestRecord()
            {
                Name = "Gender",
                Value = "Male"
            });

            _dbContext.SaveChanges();

            testRecords = _dbContext.TestRecords.AsEnumerable();

            _logger.LogInformation("Loaded testRecords for GET: ", testRecords);

            return Ok(testRecords.ToArray());
        }
    }
}
