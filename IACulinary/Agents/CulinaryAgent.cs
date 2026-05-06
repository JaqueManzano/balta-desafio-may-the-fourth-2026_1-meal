using System.Text;
using OllamaSharp;

public class CulinaryAgent
{
    private readonly OllamaApiClient _client;
    private readonly string _prompt;

    public CulinaryAgent(OllamaApiClient client)
    {
        _client = client;
        _prompt = File.ReadAllText("Prompts/culinary.md");
    }

    public async Task Handle(string input)
    {
        var fullPrompt = $"{_prompt}\n";

        fullPrompt += $"User: {input}";

        var response = new StringBuilder();

        await foreach (var chunk in _client.GenerateAsync(fullPrompt))
        {
            Console.Write(chunk?.Response);
        }
    }
}