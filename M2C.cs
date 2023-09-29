using System;
namespace NMLT;
class Mang_2_Chieu
{
    public static int[,] Create_And_Export_Array(int rows, int collumns, int gioi_han_duoi, int gioi_han_tren)
    {
        Random r = new Random();
        int [,] a = new int[rows, collumns];
        for (int i = 0; i< a.GetLength(0); i++)
        {
            for( int j = 0; j < a.GetLength(1); j++)
            {
                a[i,j] = r.Next(gioi_han_duoi, gioi_han_tren);
            }
        }
        int count =0;
        foreach (int k in a)
        {
            Console.WriteLine($"{count} --> {k}");
            count ++;
        }
        return a;
    }
}