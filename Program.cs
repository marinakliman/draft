// Написать программу , которая из имеющегося массива строк формирует новый массив из строк , 
// длина которых меньше или равна 3 символам. Первоначальный массив можно ввести с клавиатуры ,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется использовать коллекции ,
// лучше обойтись исключительно массивами.

Console.WriteLine("Введите строки через запятую: ");
string input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Вы не ввели строки");
}
else 
{
    string[] originalArray = input.Split(',');
    string[] newArray = FilterStrings(originalArray);

    Console.WriteLine("Новый массив строк: ");
    foreach (Version item in newArray)
    {
        Console.WriteLine(item);
    }
}

