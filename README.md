## __Итоговая проверочная работа__ ##
---

### __Задача:__ ###
_Напишите программу , которая из имеющегося массива строк сформирует массив строк, длина которых меньше, либо равна трём символам._ 

    * Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
    * При решении необходимо использовать исключительно массивы.

Пример: 

* ["hello","2","world",":-)"] -> ["2",":-)"]
* ["1234","1567","-2","computer science"] -> ["-2"]
* ["Russia","Denmark","Kazan"] -> [ ]


---
### __Для выполнения проверочной работы необходимо:__ ###
1. Создать репозиторий на [GitHub](https://github.com).
2. Создать оформленнй текстровым описанием решения задачи файл REDME.md и выгрузить в созданный репозиторий.
3. Создать файл с нарисованной блок-схемой алгоритма решения задачи и выгрузить в созданный репозиторий.
4. Написать программу решающую поставленную задачу и выгрузить в созданный репозиторий.
5. Этапы 2, 3, 4 должны располагаться в разных коммитах!
---
### __Текстовое описание решения__ ###

| Шаг  | Описание |
|:---- |:--------:|
|1 | Запуск программы|
|2 | На экран выводится предложение пользователю выбора варианта (вручную / автоматически) заполнения изначального массива при помощи ввода необходимой цифры |
|3 | Если пользователь выбрал автоматически - ввёл "0" (переходим на шаг 6) |
|4 | Если пользователь выбрал вручную - ввёл "1" (переходим на шаг 5) |
|5 | Пользователь вводит длину изначального массива (однозначное число) и заполняет этот массив данными согласно появляющимся инструкциям на экране (переходим на шаг 7)|
|6 | Применяя рандом выбирается один изначальный массив из трёх заранее подготовленных |
|7 | Изначальный массив выводится на экран |
|8 | Изначальный массив проверяется поэлементно согласно условия (элемент массива должен содержать три или меньше символа). Если такой элемент находится то он записывается в единый дополнительный массив равный по длине изначальному массиву |
|9 | Когда единый дополнительный массив сформирован и в нём есть необходимые данные (элементы входящие в единый дополнительный массив содержащие три или меньше символа), его данные переписываются в итоговый единый массив длина которого равна количеству элементов подходящих под условие (это нужно для корректного вывода данных на экран) |
|10 | Вывод на экран итогового единого массива |
|11 | Конец программы |
 ___

 ### __Код программы__ ###

 ```C#
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

//Ввод цифры пользователем
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

//Ручной ввод элементов массива пользователем
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
        { Console.Write(", "); }
    }
    Console.Write("]");
    Console.WriteLine();
}

 ```





