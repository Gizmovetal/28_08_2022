//3 метода: ввод размера массива, ввод чисел для заполнения массива, подсчёт количества положительных чисел массива. 

int size = GetSizeFromUser("Введите число элементов массива: ","Ошибка ввода!");
int[] array = GetNumberFromUser("Введите число: ","Ошибка ввода!", size);

int[] GetNumberFromUser(string message, string errorMessage, int size)
{ 
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        while(true)
        {
            Console.Write(message);
            bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
            if(isCorrect)
            {
                array[i] = userNumber;    
                break;
            }
            else
            {
                Console.WriteLine(errorMessage);
            }    
            
        }
    }
    return array;    
}

int GetSizeFromUser(string message, string errorMessage)
{ 
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetCount (int[] array)
{   
    int count = 0;
    for (int i = 0; i<array.Length; i++)
    {   
        if (array[i] > 0) count++;
    }
    return count;
}


Console.WriteLine($"Массив: {String.Join(" ", array)}");
Console.WriteLine($"Чисел > 0: {GetCount (array)}");
