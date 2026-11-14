
using ConsoleApp1;


Calculator calc = new Calculator();



Console.WriteLine(string.Join(", ", calc.algorithm(100)));
Console.WriteLine(string.Join(", ", calc.algorithm(101)));
Console.WriteLine(string.Join(", ", calc.algorithm(64)));
Console.WriteLine(string.Join(", ", calc.algorithm(20)));
Console.WriteLine(string.Join(", ", calc.algorithm(10000000)));

//Fra opgaven
Console.WriteLine(string.Join(", ", calc.algorithm(6561)));   //9,4  (ikke 3,8)
Console.WriteLine(string.Join(", ", calc.algorithm(3125)));   //5,5