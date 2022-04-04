// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, 
// длина которых меньше или равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры 
// либо задать на старте выполнения алгоритма

string[] array1 = new string[10];
for (int i = 0; i < array1.Length; i++)
    array1[i] = String.Empty; // наполняем массив пустыми строками

Console.Clear();

// Наполняем массив строками с клавиатуры
Console.WriteLine("Введите до 10 строк - элементов изначального массива:");
for (int i = 0; i < array1.Length; i++)
{
    string str = Console.ReadLine();
    if (str == String.Empty)
        break;
    else
        array1[i] = str;
}

// определяем размер будущего массива
int new_arr_len = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length > 0 && array1[i].Length <= 3)
        new_arr_len++;
}

Console.Clear();

string[] array2 = new string[new_arr_len]; // инициализируем новый массив с нужным количеством элементов
int arr2_count = 0;

for (int i = 0; i < array1.Length; i++) // наполняем новый массив строками, соответствующими условию
{
    if (array1[i].Length > 0 && array1[i].Length <= 3)
    {
        array2[arr2_count] = array1[i];
        arr2_count++;
    }
}

Console.WriteLine("Изначальный массив:");
PrintArray(array1);

Console.WriteLine("Новый массив:");
PrintArray(array2);

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{i}: ");
        Console.WriteLine(arr[i]);
    }
}