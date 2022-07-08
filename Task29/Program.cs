Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine("=======================================");
Console.WriteLine("       ВЫВОД ЭЛЕМЕНТОВ МАССИВА");//Название
Console.WriteLine("=======================================\n");
/*КОНЕЦ ЗАГОЛОВКА*/

Console.WriteLine("Введите несколько цифр через пробел");
string[] arr = Console.ReadLine().Split();


Console.WriteLine("\n=======================================");
Console.ForegroundColor = ConsoleColor.Yellow; 
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    if(i == arr.Length - 1)
    {
        Console.Write(arr[i]);
    }
    else{
        Console.Write(arr[i]);
        Console.Write(", ");
    }

}
Console.WriteLine("]");
Console.ResetColor();
Console.WriteLine("=======================================");
