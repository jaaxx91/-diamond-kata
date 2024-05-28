
using DiamondKata;

var diamondKataService = new DiamondKataService();

Console.WriteLine("Hello, please provide letter to print diamond!");

var character = Console.ReadLine();

var diamondPrint = diamondKataService.GetDiamondPrint(character[0]);

Console.WriteLine(diamondPrint);