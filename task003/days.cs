// тут надо сделать так, чтобы программа выдавала название дня недели в 
//на число. Например 3 -> среда

Console.WriteLine("пиши номер дня, я скажу, как он называется");
int day = Convert.ToInt32(Console.ReadLine());


if (day==1) {Console.WriteLine("monday");
}
else if (day==2) 
{
    Console.WriteLine("tuesday");
    }
else if (day==3) 
{
    Console.WriteLine("wednesday");
    }
    else if (day==4) 
{
    Console.WriteLine("thursday");
    }
    else if (day==5) 
{
    Console.WriteLine("friday");
    }
    else if (day==6) 
{
    Console.WriteLine("saturday");
    
    }
    else if (day==7) 
{
    Console.WriteLine("sunday");
    }
 else
 {Console.WriteLine ("ты же знаешь, сколько дней недели, верно?");};

