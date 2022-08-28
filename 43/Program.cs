//Воод данных с клавиатуры, координаты точек вычисляются по формуле

int b1 = GetPointFromUser("введите значение b1: ","Ошибка ввода!");
int k1 = GetPointFromUser("введите значение k1: ","Ошибка ввода!");
int b2 = GetPointFromUser("введите значение b2: ","Ошибка ввода!");
int k2 = GetPointFromUser("введите значение k2: ","Ошибка ввода!");

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Прямые пересекаются в точке - X: {x}, Y: {y}");

int GetPointFromUser(string message, string errorMessage)
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