double number, degree;

double Exponentiation( double digit, double deg ){
    double result = 1;
    for (int count = 0; count < deg; count++)
    {
        result *= digit;
    }
    return result;
}

Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine("=======================================");
Console.WriteLine("        ВОЗВЕДЕНИЕ В СТЕПЕНЬ");//Название
Console.WriteLine("=======================================\n");
/*КОНЕЦ ЗАГОЛОВКА*/

Console.Write("Введите возводимое число: ");
while (!double.TryParse(Console.ReadLine(), out number))
{
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите возводимое число: ");
}

Console.Write("Введите число степени возведения: ");
while (!double.TryParse(Console.ReadLine(), out degree))
{
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите число степени возведения: ");
}


Console.WriteLine("\n=======================================");
Console.ForegroundColor = ConsoleColor.Yellow; 
Console.Write($"{number} ^ {degree} = ");
Console.WriteLine(Exponentiation(number,degree));
Console.ResetColor();
Console.WriteLine("=======================================");
