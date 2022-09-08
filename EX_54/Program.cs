using System;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Введите количество строк:"); // задаем количество строк
            int n = int.Parse(Console.ReadLine()); // считываем количество строк
            Console.WriteLine("Введите количество столбцов:"); // задаем количество столбцов
            int m = int.Parse(Console.ReadLine()); //считваем количество столбцов
            Random rnd = new Random(); // генератор случайных чисел
            int[,] matrix = new int[n, m]; // пустой двумерный массив размерностью n и m
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)  // В циклее создаем нашу матрицу случайными числами от -10 до 50
                {
                    matrix[i, j] = rnd.Next(0, 10);
                    Console.Write("{0}\t", matrix[i, j]); // и сразу ее выводим, так мы заполняем только строку
                }
                Console.WriteLine(); // новая строка матрицы
            }
 
            
 
    for (int i = 0; i < matrix.GetLength(0); i++)
        SortRow(matrix, i);
 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " ");
        Console.WriteLine();
    }
    Console.ReadLine();
}
static void SortRow(int[,] m, int r)
{
    for (int i = 0; i < m.GetLength(1); i++)
        for (int j = i + 1; j < m.GetLength(1); j++)
            if (m[r, i] < m[r, j])
            {
                int tmp = m[r, i];
                m[r, i] = m[r, j];
                m[r, j] = tmp;
            }
    }
    
}
