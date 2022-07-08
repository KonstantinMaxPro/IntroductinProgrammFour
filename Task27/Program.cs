int number = 0;

int SumOfNumber(int arg1)
{
    int result = 0;
    while (arg1 > 0)
    {
        result = result + arg1 % 10;
        arg1 = arg1 / 10;        
    }
    return result;
}

Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine("=======================================");
Console.WriteLine("         СУММА ЦИФЕР В ЧИСЛЕ");//Название
Console.WriteLine("=======================================\n");
/*КОНЕЦ ЗАГОЛОВКА*/

Console.Write("Введите число: ");
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите число: ");
}

Console.WriteLine("\n=======================================");
Console.ForegroundColor = ConsoleColor.Yellow; 
Console.WriteLine($"Сумма цифер в числе: {SumOfNumber(number)}");
Console.ResetColor();
Console.WriteLine("=======================================");
