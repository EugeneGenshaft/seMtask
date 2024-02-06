// тут надо сделать так, чтобы программа выдавала название дня недели в 
//на число. Например 3 -> среда

Console.WriteLine("пиши номер дня, я скажу, как он называется");
int day = Convert.ToInt32(Console.ReadLine());

string message = "ты же знаешь, сколько дней недели, верно?";
if (day==1) {message = "monday";
}
if (day==2) {message = "tuesday";
}
if (day==3) {message = "wednesday";
}
if (day==4) {message = "thursday";
}
if (day==5) {message = "friday";
}
if (day==6) {message = "saturday";
}
if (day==7) {message = "sunday";
}
else {message = message;};

Console.WriteLine (message);