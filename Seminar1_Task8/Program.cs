// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Считываем данные с консоли
string? imputNumLine = Console.ReadLine();
// Проверим что данные не пустые
if(imputNumLine!=null)
{
// Парсим число, используем оператор %
    int imputNumber = int.Parse(imputNumLine);
// Вводим новую переменную
    int imputNumberC = 2;
    string result = string.Empty;
// Проверяем условие, накапливаем результат четных чисел
    while(imputNumberC < imputNumber)
    {
        result = result + imputNumberC + ",";
        imputNumberC = imputNumberC + 2;
    }
// Проверяем четность вводимого числа и необходимость вывода в консоль
    int resultEven = imputNumber % 2;
    if(resultEven == 0)
    {
        result = result + imputNumber;
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine(result);
    }
}
