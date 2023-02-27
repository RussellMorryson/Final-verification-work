


// Метод для заполнения первичного массива строками
string[] CreateCompletionArray(int n)
{
    string[] array = new string[n]; // Инициализация основного массива
    Console.WriteLine($"Введите {n} слова");
    // Заполнение основного массива
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i + 1} слово: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

// Метод для выборки строк из основного массива
string[] SamplingFromAnArray(string[] array)
{
    int count = 0; // Инициализация счетчика используемого как индекс для массива с результатами выборки
    string[] arr = new string[1]; // Инициализация массива для хранения строк длиной не более 3 символов

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

    // Удаление последнего элемента массива поскольку он пуст
    if (arr[count] == "-")
    {
        Array.Resize(ref arr, arr.Length - 1);
    }
}

// Метод для вывода элементов массива
void PrintArray(string[] a)
{
    Console.Write("[");
    for (int i = 0; i < a.Length; i++)
    {
        if (i == a.Length - 1)
        {
            Console.Write(a[i]);
        }
        else
        {
            Console.Write(a[i] + ", ");
        }
    }
    Console.Write("]");
}



// Основной блок программы

Console.WriteLine("Программа для выборки из массива строк, строк длиной не более 3 символов");
int n = 4; // Количество элементов по умолчанию
//int n = Convert.ToInt32(Comsole.ReadLine()); // 2 вариант для указания количества элементов массива













