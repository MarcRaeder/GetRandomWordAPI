using GetRandomWordAPI.Repository;

namespace GetRandomWordAPI.Service;

public class WordService
{
    private WordRepository WordRepository;

    public WordService(WordRepository wordRepository)
    {
        this.WordRepository = wordRepository;
    }
    public List<string> GetAllWords()
    {
        return WordRepository.GetAllWords();
    }
    
    public IEnumerable<string> GetWords(int amount)
    {
        return WordRepository.GetWords(amount);
    }
}
