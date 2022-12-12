/* Задача 5: * Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)*/

int Promt(String message) //Приглашение ко вводу
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Promt("Введите число строк в матрице  ");
int n = Promt("Введите число столбцов в матрице  ");

int[,] InputMatrix(int m, int n) //Заполнение матрицы с учетом размера (количества строк, столбцов)
{
    int[,] matr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = new Random().Next(0, 100);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)//Вывод матрицы на экран
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matr[i, j] + "   ");
        }
        Console.WriteLine();
    }
}
int sum = 0;
int sum2 = 0;
int razn = 0;
int[,] matr = InputMatrix(m, n);

int MinMax(int[,] matr) //Нахождение минимального(по столбцам) и максимального(по строкам) значения в матрице и разницы между ними
{
    int max = -1000;
    int min = 101;
    int razn = 0;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matr[i, j] > max)
            {
                max = matr[i, j];
            }
        }
        sum = sum + max;
        max = -1000;

    }


    for (int j = 0; j < n; j++)
    {

        for (int i = 0; i < m; i++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
            }
        }
        sum2 = sum2 + min;
        min = 101;
        razn = sum - sum2;
    }

    return razn; 
}
PrintMatrix(matr);
razn = MinMax(matr);

System.Console.WriteLine($"Сумма максимумов по строкам равна {sum} ");
System.Console.WriteLine($"Сумма минимумов по столбцам равна {sum2} ");
System.Console.WriteLine($"Разность между суммой максимумов по строкам и суммой минимумов по столбцам равна: {razn}");
