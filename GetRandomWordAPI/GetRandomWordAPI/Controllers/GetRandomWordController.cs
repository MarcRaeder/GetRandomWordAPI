using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetRandomWordAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetRandomWordAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetRandomWordController : ControllerBase
    {
        private GetRandomWordService GetRandomWordService;

        public GetRandomWordController(GetRandomWordService getRandomWordService)
        {
            this.GetRandomWordService = getRandomWordService;
        }
        // GET: api/GetRandomWord
        [HttpGet("/all")]
        public List<string> GetAllWords()
        {
            return GetRandomWordService.GetAllWords();
        }

        // GET: api/GetRandomWord/5
        [HttpGet("/word")]
        public IEnumerable<string> GetWord(int number)
        {
            return GetRandomWordService.GetWord(number);
        }
        
    }
}
