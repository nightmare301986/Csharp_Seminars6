/* Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

int Prompt(string message)
{
    System.Console.Write($"{message}  >  ");
    return Convert.ToInt32(Console.ReadLine());
}


double b1 = Prompt("Введите b1 для уравнения: y = k1 * x + b1, b1 =");
double k1 = Prompt("Введите k1 для уравнения: y = k1 * x + b1, k1 =");
double b2 = Prompt("Введите b2 для уравнения: y = k2 * x + b2, b2 =");
double k2 = Prompt("Введите k2 для уравнения: y = k2 * x + b2, k2 =");

double i = -1000;
double x = 0;
double[] array = new double[2];
int length = 2;

double[] InputArray(int length) //Заполнение массива
{
    double[] array = new double[2];

    while (i <= 1000)
    {
        x = Math.Round(k1 * i - k2 * i + b1 - b2, 2);
        if (x == 0)
        {
            array[0] = i;
            array[1] = k1 * i + b1;
        }
        i = Math.Round(i + 0.01, 2);

    };

    return array;
}
void CoordCollizion(double[] array)//Нахождение точки пересечения прямых и вывод значений на экран
{
    for (int i = 0; i < 2; i++)
    {
        if (k1 == k2) { System.Console.WriteLine($"Прямые с такими значениями коэффициентов х (k1={k1} и k2={k2}) параллельны (т.е. никогда не пересекутся)"); break;}
        if (i == 0)
        {
            System.Console.WriteLine($"Значение координаты пересечения прямых по оси x {array[0]}");
        }
        if (i == 1)
        {
            System.Console.WriteLine($"Значение координаты пересечения прямых по оси y {array[1]}");
        }

    }
    Console.WriteLine();
}

double[] arr1 = InputArray(length);
CoordCollizion(arr1);