// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Считываем данные с консоли
string? imputNum1Line = Console.ReadLine();
string? imputNum2Line = Console.ReadLine();
// Проверим что данные не пустые
if(imputNum1Line!=null&&imputNum2Line!=null)
{
// Парсим числа
    int number1 = int.Parse(imputNum1Line);
    int number2 = int.Parse(imputNum2Line);
// Проверяем условие и выводим результат в консоль
    if(number1 > number2)
    {
        Console.WriteLine("Первое число больше второго");
    }
    else
    {
        Console.WriteLine("Первое число меньше второго");
    }
}
