//тут надо найти последнюю цифру трехзначного числа

Console.WriteLine("пиши трехзначное число, гений");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number *= -1;
}

if (number >= 100 && number <=999)
{
    int result = number % 10;
    Console.WriteLine ($"последняя цифра: {result}");
}
else 
{
    Console.WriteLine("are u serious?");
}