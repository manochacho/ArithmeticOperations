using System;

Console.WriteLine("Enter first int:");
int first_number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second int:");
int second_number = Convert.ToInt32(Console.ReadLine());

int sum = first_number + second_number;
int product = first_number * second_number;
int diff = first_number - second_number;
int quotient = first_number / second_number;
int remainder = first_number % second_number;

Console.WriteLine("the sum is: " + sum);
Console.WriteLine("the product is: " + product); 
Console.WriteLine("diff is: " + diff); 
Console.WriteLine("quotient is: " + quotient); 
Console.WriteLine("remainder is: " + remainder);