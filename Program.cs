/* Задача: Напишите программу,которая из имеющегося массива строк сформирует 
массив строк, длина которых меньше, либо равна трём символам. 
* Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
* При решении необходимо использовать исключительно массивы. */

Console.Clear();
Console.WriteLine("Здравствуйте ! Это программа которая из имеющегося массива строк сформирует массив строк, длина которых меньше, либо равна трём символам (элементы массива разделены запятыми).");
Console.WriteLine();
Console.WriteLine("Если Вы хотите самостоятельно создать массив и заполнить его прошу ввести цифру 1 и нажать Enter, в противном случае введите 0 и программа сделает всё автоматически");
int numberB = InputNumber();
if (numberB == 0)
{
    string[] arrString = ArrayRandom();
    Console.Write($"Исходный массив :");
    ResultOutput(arrString);
    arrString = VerifiArray(arrString);
    Console.Write($"Итоговый массив :");
    ResultOutput(arrString);
}
else
{
    string[] arrString = InputStringArray();
    Console.Write($"Исходный массив :");
    ResultOutput(arrString);
    arrString = VerifiArray(arrString);
    Console.Write($"Итоговый массив :");
    ResultOutput(arrString);
}

//Ввод цифры
int InputNumber()
{
    Console.Write("Введите цифру : ");
    int numberA = int.Parse(Console.ReadLine());
    if (numberA < 0 || numberA > 1)
    {
        Console.WriteLine("Введите цифру согласно инструкции ");
        numberA = InputNumber();
    }
    return (numberA);
}

//Случайный выбор из заранее заданных массивов
string[] ArrayRandom()
{
    string[] arrayString = new string[0];
    int numberR = new Random().Next(1, 4);
    if (numberR == 1) { arrayString = new string[] { "hello", "2", "world", ":-)" }; }
    else if (numberR == 2) { arrayString = new string[] { "1234", "1567", "-2", "computer science" }; }
    else if (numberR == 3) { arrayString = new string[] { "Russia", "Denmark", "Kazan" }; }
    return (arrayString);
}

//Проверка элементов массива и создание массива необходимых данных
string[] VerifiArray(string[] stringArray)
{
    int j = 0;
    string[] resultArray = new string[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length > 3) { }
        else
        {
            resultArray[j] = stringArray[i];
            j++;
        }
    }
    string[] stringFirstResult = new string[j];  //Создаём массив нужного размера
    if (j < 1) { }
    else
    {
        for (int i = 0; i < stringFirstResult.Length; i++) //Заполняем массив необходимыми данными
        {
            stringFirstResult[i] = resultArray[i];
        }
    }
    return (stringFirstResult);
}

//Ручной ввод элементов массива
string[] InputStringArray()
{
    Console.Write("Введите длину массива (однозначное целое число) : ");
    int sizeArray = 0;
    sizeArray = int.Parse(Console.ReadLine());
    if (sizeArray < 0 || sizeArray > 9)
    { InputStringArray(); }
    string[] stringArray = new string[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        Console.WriteLine($"Введите значение {i + 1} элемента массива : ");
        stringArray[i] = Console.ReadLine();
    }
    return (stringArray);
}

//Вывод элементов массива
void ResultOutput(string[] stringArray)
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"{stringArray[i]}");
        if ((i + 1) < stringArray.Length)
        { Console.Write(","); }
    }
    Console.Write("]");
    Console.WriteLine();
}