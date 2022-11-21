using GetRandomWordAPI.Repository;

namespace GetRandomWordAPI.Service;

public class GetRandomWordService
{
    private GetRandomWordRepository GetRandomWordRepository;

    public GetRandomWordService(GetRandomWordRepository getRandomWordRepository)
    {
        this.GetRandomWordRepository = getRandomWordRepository;
    }
    public List<string> GetAllWords()
    {
        return GetRandomWordRepository.GetAllWords();
    }
    
    public IEnumerable<string> GetWord(int number)
    {
        return GetRandomWordRepository.GetWord(number);
    }
}