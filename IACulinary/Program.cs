using OllamaSharp;

var client = OllamaClientFactory.Create();

var culinaryAgent = new CulinaryAgent(client);

Console.WriteLine("Tell me: what ingredients do you have on hand, and how much time can you spend preparing it?"); 
var input = Console.ReadLine() ?? "";


await culinaryAgent.Handle(input);
Console.WriteLine("Enjoy your meal!");
