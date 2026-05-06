using OllamaSharp;

var client = OllamaClientFactory.Create();

var culinaryAgent = new CulinaryAgent(client);

Console.WriteLine("Me conta: quais ingredientes você tem aí e quanto tempo você pode dedicar ao preparo?"); 
var input = Console.ReadLine() ?? "";


await culinaryAgent.Handle(input);
Console.WriteLine("Bom apetite!");
