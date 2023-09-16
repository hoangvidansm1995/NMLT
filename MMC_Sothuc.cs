using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
namespace NMLT;
class Xu_ly_mang_so_thuc
{
    public static double[] Create_random_array(int so_phan_tu, int gioi_han_duoi, int gioi_han_tren)
    {
        double[] a = new double[so_phan_tu];
        //tao phan tu random
        Random r = new Random();
        for (int i = 0; i< a.Length; i++)
        {
            // gan phan tu a[i] cho (so nguyen trong gioi han + so thuc trong gioi han 0- 1.0)
            a[i] = r.NextDouble() + r.Next(gioi_han_duoi, gioi_han_tren);
        }
        return a;
    }
    public static double[] Create_custom_array(int so_phan_tu)
    {
        double[] a = new double[so_phan_tu];
        for (int i = 0; i< a.Length; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i}");
            a[i] = Convert.ToDouble(Console.ReadLine());
        }
        return a;
    }
    public static void Export_array(double[] a)
    {
        for(int i = 0; i < a.Length; i++)
        {
            Console.Write($"{a[i]}, ");
        }
    }
    public static double Sum_of_negatives(double[] a)
    {
        double sum = 0;
        for (int i = 0; i< a.Length; i++)
        {
            if(a[i]< 0) sum+= a[i];
        }
        return sum;
    }
    public static double[] Arrange_array(double[]a)
    {
        for (int i = 0; i< a.Length -1; i++)
        {
            if (a[i]> a[i+1]) Xu_ly_so_nguyen.Permutation(ref a[i], ref a[i+1]);
        }
        return a;
    }
    public static void List_negative_number(double[] a)
    {
        for (int i = 0; i< a.Length; i++)
        {
            if (a[i] < 0) Console.WriteLine(a[i]);
        }
    }
    public static double Max_Array(double[]a)
    {
        double max =a[1];
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > max) max = a[i];
        }
        return max;
    }
    public static double Min_Pos_Num(double[]a)
    {
        double min = Max_Array(a);
        if (min < 0)
        {
            return -1;
        }
        else
        {
            for (int i = 0; i< a.Length; i ++)
            {
                if(a[i] < min & a[i] > 0) min = a[i];
            }
            return min;
        }
    }
}   
