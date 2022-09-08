using System;

class Program
{
    static void Main(string[] args)

    {
        int[,] matrix = {{1,4,7,2},
                         {5,9,2,3},
                         {8,4,2,4},
                         {5,2,6,7}};

        int sum = int.MaxValue;
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                int temp = 0;
                for (int j = 0; j < 3; j++)
                {
                    temp += matrix[i, j];
                }
                if (temp < sum)
                {
                    sum = temp;
                    index = i+1;
                }
            }
            Console.WriteLine("Строка: "+index+" Сумма - "+sum);
            Console.WriteLine();
    }
}