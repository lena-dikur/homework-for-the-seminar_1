// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Считываем данные с консоли
string? imputNumLine = Console.ReadLine();
// Проверим что данные не пустые
if(imputNumLine!=null)
{
// Парсим число, используем оператор %
    int imputNumber = int.Parse(imputNumLine);
    int imputNumberB = imputNumber % 2;
// Проверяем условие, выводим в консоль
    if(imputNumberB == 0)
    {
        Console.WriteLine("четное число");
    }
    else
    {
        Console.WriteLine("нечетное число");
    }
}