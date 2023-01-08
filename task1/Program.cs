// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна трём символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


string[] array1 = new string[7] {"1234", "23889900033", "000", "hello", "world", "Kazan", "777"};
string[] array2 = new string[array1.Length];

// Создаём метод SecondArrayWithIF, в котором цикл равен длине массивов.
void SecondArrayWithIF(string[] array1, string[] array2)

// внутри цикла проверка условия ( <=3 ), 
// если да -> элемент первого массива заносится в count элемент второго массива.
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{ array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray( array2 );