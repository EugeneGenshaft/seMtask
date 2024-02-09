// тут надо сделать так, чтобы программа в ответ на число N
// выдывало числf от -N до N (5-> -5.-4....5)

Console.WriteLine("Пиши число, сейчас покажу че");

int number = Convert.ToInt32(Console.ReadLine());

for (int i = -number; i <= number;i++) {
    Console.Write($"{i}, ");
}

int count = -number;