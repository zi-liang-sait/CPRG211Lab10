// See https://aka.ms/new-console-template for more information

//CPRG 211 F Lab 10 - Using Recursion
//Michael (Zi) Liang 000921925
//Apr 2, 2024


using CPRG211Lab10;

RecursionMethods recursionMethods = new RecursionMethods();
//simple tests
Console.WriteLine($"Sum of integers between 2 and 9 inclusive: {recursionMethods.SumBetween(9, 2)}");
Console.WriteLine($"Sum of integers between -10 and 100 inclusive: {recursionMethods.SumBetween(-10, 100)}");
Console.WriteLine($"Number of times 1272 can be divided by 2: {recursionMethods.TimesDivisibleByTwo(1272)}");
Console.WriteLine($"Number of times 1024 can be divided by 2: {recursionMethods.TimesDivisibleByTwo(1024)}");