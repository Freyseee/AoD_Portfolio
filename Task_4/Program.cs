
using Task_4;

Calculator calc = new Calculator();

int[] arr = [23, 56, 22, 11, 65, 89, 3, 44, 87, 910, 45, 35, 98];

int[] result = calc.CloseToSquare(arr);
Console.WriteLine(string.Join(", ", result)); //89, 3, 35, 128