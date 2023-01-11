using GetRandomWordAPI.Service;

namespace GetRandomWordAPI.Repository;

public class WordRepository
{
    private DataService DataService;

    public WordRepository(DataService dataService)
    {
        this.DataService = dataService;
    }
    
    public List<string> GetAllWords()
    {
        return DataService.wordlist;
    }
    
    public IEnumerable<string> GetWord(int amount)
    {
        if (amount == 0)
        {
            amount = 1;
        }
        return DataService.wordlist.AsEnumerable().OrderBy(n => Guid.NewGuid()).Take(amount);
    }
}
