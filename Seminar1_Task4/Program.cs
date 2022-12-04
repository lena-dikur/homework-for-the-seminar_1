// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Считываем данные с консоли
string? imputNum1Line = Console.ReadLine();
string? imputNum2Line = Console.ReadLine();
string? imputNum3Line = Console.ReadLine();
// Проверим что данные не пустые
if(imputNum1Line!=null&&imputNum2Line!=null&&imputNum3Line!=null)
{
// Парсим числа
    int number1 = int.Parse(imputNum1Line);
    int number2 = int.Parse(imputNum2Line);
    int number3 = int.Parse(imputNum3Line);
    if(number1 > number2)
    {
        if(number1 > number3)
        {
            Console.WriteLine("max="+number1);
        }
        else
        {
            Console.WriteLine("max="+number3);
        }

    }
    else
    {
        if(number2 > number3)
        {
            Console.WriteLine("max="+number2);
        }
        else
        {
            Console.WriteLine("max="+number3);
        }
    }
}
