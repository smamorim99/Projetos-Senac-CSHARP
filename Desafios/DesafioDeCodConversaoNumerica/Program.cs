﻿using System.IO.Pipelines;

int value = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 =  Convert.ToInt32(value/value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3; 
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 /(float)value;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");