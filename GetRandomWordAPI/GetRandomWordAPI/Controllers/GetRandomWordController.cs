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
    public class WordController : ControllerBase
    {
        private WordService WordService;

        public WordController(WordService wordService)
        {
            this.WordService = wordService;
        }

        [HttpGet("/all")]
        public List<string> GetAllWords()
        {
            return WordService.GetAllWords();
        }

        [HttpGet("/word")]
        public IEnumerable<string> GetWord(int amount)
        {
            return WordService.GetWord(amount);
        }
    }
}