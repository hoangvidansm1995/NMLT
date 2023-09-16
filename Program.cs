using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using NMLT;
namespace NMLT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = Xu_ly_mang_so_thuc.Create_random_array(3,-100,100);
            Xu_ly_mang_so_thuc.Export_array(a);
            Console.WriteLine(Xu_ly_mang_so_thuc.Min_Pos_Num(a));
            
        }              
    }
}