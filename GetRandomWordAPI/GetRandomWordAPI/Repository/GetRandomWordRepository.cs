using System.Security.Cryptography;
using GetRandomWordAPI.Service;

namespace GetRandomWordAPI.Repository;

public class GetRandomWordRepository
{
    private DataService DataService;

    public GetRandomWordRepository(DataService dataService)
    {
        this.DataService = dataService;
    }
    
    public List<string> GetAllWords()
    {
        return DataService.wordlist;
    }
    
    public IEnumerable<string> GetWord(int number)
    {
        if (number == 0)
        {
            number = 1;
        }
        return DataService.wordlist.AsEnumerable().OrderBy(n => Guid.NewGuid()).Take(number);
    }
}
