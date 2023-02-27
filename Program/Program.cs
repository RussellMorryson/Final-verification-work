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
    for (int i = 0; i < array.Length; i++)
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
    return arr;
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
    Console.WriteLine();
}


// Основной блок программы
//===============================================================================================//
Console.WriteLine("Программа для выборки из массива строк, строк длиной не более 3-х символов");
int n = 4; // Количество элементов по умолчанию

/*
//2 вариант для указания количества элементов массива
Console.Write("Введите количество строк основного массива: );
n = Convert.ToInt32(Comsole.ReadLine()); 
*/

string [] MainArray = CreateCompletionArray(n); // Формирвоание основного массива
Console.Write($"Основной массив: ");
    PrintArray(MainArray);

string [] SelectionArray = SamplingFromAnArray(MainArray); // Формирование массива с выборкой
Console.Write($"Массив со строками не более 3-х символов: ");
    PrintArray(SelectionArray);













