Console.WriteLine("Программа для выборки из массива строк, строк длиной не более 3 символов");
int n = 4; // Количество элементов по умолчанию
//int n = Convert.ToInt32(Comsole.ReadLine()); // 2 вариант для указания количества элементов массива


string[] array = new string[n]; // Инициализация основного массива


int count = 0; // Инициализация счетчика используемого как индекс для массива с результатами выборки
string[] arr = new string[1]; // Инициализация массива для хранения строк длиной не более 3 символов

Console.WriteLine($"Введите {n} слова");
// Заполнение основного массива
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите {i + 1} слово: ");
    array[i] = Console.ReadLine();
}

// Выборка элементов из основного массива
for (int i = 0; i < n; i++)
{
    if (array[i].Length <= 3)
    {
        arr[count] = array[i];
        Array.Resize(ref arr, arr.Length + 1); // Изменение размера массива с результатами выборки
        count++; // Увеличение счетчика
        arr[count] = "-";
    }
}

if (arr[count] == "-")
{
    Array.Resize(ref arr, arr.Length - 1);
}


Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    if (i == arr.Length - 1)
    {
        Console.Write(arr[i]);
    }
    else
    {
        Console.Write(arr[i] + ", ");
    }
}
Console.Write("]");