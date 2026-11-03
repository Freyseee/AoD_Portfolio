
using Task_3;

Recursion recursion = new Recursion();

Console.WriteLine(recursion.additive("123")); //True
Console.WriteLine(recursion.additive("321")); //False
Console.WriteLine(recursion.additive("12222223")); //False
Console.WriteLine(recursion.additive("93749279")); //True
Console.WriteLine(recursion.additive("93749278")); //False

Console.WriteLine(recursion.additive("12")); //False
Console.WriteLine(recursion.additive("")); //False
