using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
namespace NMLT;
class Xu_ly_mang_so_nguyen
{
    public static int[] Create_Random_Array(int so_phan_tu, int low_lim, int up_lim)
    {
        int[] a = new int[so_phan_tu];
        Random random = new Random();
        for (int i =0; i < so_phan_tu; i++)
        {
            a[i] = random.Next(low_lim, up_lim);
        }
        foreach(int k in a)
        {
            Console.WriteLine(k);
        }
        return a;

    }
    public static int[] Create_Custom_Array()
    {
        int[] a;
        Console.WriteLine("Nhap so luong phan tu cua mang");
        int n = Convert.ToInt32(Console.ReadLine());
        a = new int[n];
        for (int i = 0; i< a.Length; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i}");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        return a;
    }
    public static void Export_Array(int[] a)
    {
        for(int i = 0; i < a.Length; i++)
        {
            Console.Write($"{a[i]}, ");
        }
    }
    public static int Sum_Of_Array(int[] a)
    {
        int sum = 0;
        for (int i = 0; i <a.Length; i++)
        {
            sum += a[i];
        }
        return sum;
    }
    public static int Max_Array(int[] a)
    {
        int max = 0;
        for (int i =0; i < a.Length; i++)
        {
            if (a[i] > max) max = a[i];
        }
        return max;
    }
    public static int Min_Position(int[] a)
    {
        int min = a[0];
        int position = 0;
        for (int i =0; i< a.Length; i++)
        {
            if (min < a[i]) min = a[i];
        }
        for (int i = 0; i<a.Length; i++)
        {
            if(min == a[i])
            position = i;
        }
        return position;
    }
    public static bool Even_And_Lessthan2004(int[]a)
    {
        for(int i = 0; i < a.Length; i++)
        {
            if(a[i]< 2004 & a[i]% 2 ==0) return true;
        }
        return false;
    }
    public static int Numbers_Of_Prime(int[] a)
    {
        int count = 0;
        for (int i = 0; i < a.Length ; i++)
        {
            if (Xu_ly_so_nguyen.Is_prime(a[i]) == true & a[i] < 100) count +=1;
        }
        return count;
    }
    public static void List_Even_Numbers(int[] a)
    {
        Console.WriteLine("Ket qua la:");
        for (int i = 0; i< a.Length; i++)
        {
            if (a[i] %2 == 0) Console.Write($" {a[i]}");
        }
    }
    public static int Last_Even_Number(int[] a)
    {
        for (int i = a.Length; i >= 0 ; i--)
        {
            if (a[i]% 2 ==0) return a[i];
        }
        return -1;
    }
    public static int Last_Perfect_Number(int[] a)
    {
        for(int i = a.Length - 1; i>= 0; i--)
        {
            if (Xu_ly_so_nguyen.Is_Perfect_Number(a[i]) == true ) return a[i];
        }
        return -1;
    }
    public static int First_Even_Num(int[]a)
    {
        for (int i = 0; i< a.Length; i++)
        {
            if (a[i] % 2 == 0) return a[i];
        }
        return -1;
    }
    public static int First_Prime_Num(int[]a)
    {
        for (int i = 0; i< a.Length; i++)
        {
            if (Xu_ly_so_nguyen.Is_prime(a[i])) return a[i];
        }
        return -1;
    }
    public static int First_Perfect_Num(int[]a)
    {
        for (int i = 0; i< a.Length; i++)
        {
            if (Xu_ly_so_nguyen.Is_Perfect_Number(a[i]) == true) return a[i];
        }
        return -1;
    }
    public static void least_Num(int [] a)
    {
        int [] b = new int[10];
        for( int  i = 0; i < 10; i ++)
        {
            int count = 0;
            for (int j = 0; j< a.Length; j ++)
            {
                int k =a[j];
                if(k< 0) k=-k;
                for (int l = 0; k>0; l++)
                {
                    if (k % 10 == i) count +=1;
                    k /=10;
                }
            }
            b[i] = count;
        }
        int max = 0;
        int position = 0;
        for(int i =0 ; i< a.Length; i ++)
        {
            if (b[i]> max) 
            {max = b[i];
            position = i;}
        }
        Console.WriteLine("So {0} xuat hien nhieu nhat: {1} lan", position, max);
    }
}