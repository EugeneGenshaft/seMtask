// See https://aka.ms/new-console-template for more information
﻿int a = new Random() .Next(1, 10);
Console.WriteLine (a);
int b = new Random() .Next(1, 10);
Console.WriteLine (b);
int c = new Random() .Next(1, 10);
Console.WriteLine (c);
int d = new Random() .Next(1, 10);
Console.WriteLine (d);
int e = new Random() .Next(1, 10);
Console.WriteLine (e);
int f = new Random() .Next(1, 10);
Console.WriteLine (f);

int max = a; 
if (a > max ) max = a; 
if (b > max ) max = b;
if (c > max ) max = c;
if (d > max ) max = d;
if (e > max ) max = e;
if (f > max ) max = f;

Console.Write ("max = ");
Console.WriteLine (max);