using GetRandomWordAPI.Service;
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
