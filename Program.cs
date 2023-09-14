using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
namespace Bai_tap17
{
    class Program
    {
        static double Tinh_giai_thua(int x)
        {
            double giai_thua = 1;
            for(double i = 1; i <= x; i++)
            {
                giai_thua *= i;
            }
            return giai_thua;
        }
        static int Tinh_so_mu(int x, int n)
        {
            int so_mu = 1;
            for (int i =1; i<=n; i++)
            {
                so_mu *= x;
            }
            return so_mu;
        }
        static double Tinh_tongn(int n)
        {
            int i = 1;
            double tong = 0;
            while (i<=n)
            {
                tong += i;
                i++;
            }
            return tong;
        }
        static void Hoan_vi(ref int x,ref int y)
        {
            int t=x;
            x=y;
            y=t;
        }
        static int UCLN(int a, int b)
        {
            int max = 0;
            int i= a/2;
            while (i>0)
            {
                if (a%i ==0 & b%i ==0) 
                {
                    max = i;
                    break;
                }
                i-=1;
            }
            return max;
        }
        static int BCNN(int a, int b)
        {
            int min =0;
            for (int i = a; i<a*b; i++)
            if (i%a==0 & i %b ==0)
            {
                min =i;
                return min;
            }
            return a*b;
        }
        static bool KTNT(int a)
        {
            if (a<=1) return false;
            for (int i = 2; i<=a/2; i++)
            {
                if (a%i==0) return false;
            }
            return true;
        }
        static int Day_of_month(int thang, int nam)
        {
            int day = 31;
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                return day;
                case 4:
                case 6:
                case 9:
                case 11:
                return day = 30;
                case 2: return (La_nam_nhuan(nam))? 29:28;
                default:
                return -1;
            }
        }
        static bool La_nam_nhuan(int nam)
        {
            if (nam % 100 != 0 & nam % 4 ==0) return true;
            return false;
        }
        static int Bao_nhieu_so(int a)
        {
            int count = 0;
            while (a>0)
            {
                if (a/10 != 0 || a%10 != 0)
                a/=10;
                count +=1;
            }
            return count;
        }
        static int So_dao_nguoc(int n)
        {
            string so_dao_nguoc = "";
            if (n == 0) so_dao_nguoc = "0";
            if (n<0) n =- n;
            while (n > 0)
            {
                so_dao_nguoc += n%10;
                
                n/=10;
            }
            return Convert.ToInt32(so_dao_nguoc);
        }
        static string So_thanh_chu(int a)
        {
            string chu = "";
            switch (a)
            {
                case 0: return chu = "khong";
                case 1: return chu = "mot";
                case 2: return chu = "hai";
                case 3: return chu = "ba";
                case 4: return chu = "bon";
                case 5: return chu = "nam";
                case 6: return chu = "sau";
                case 7: return chu = "bay";
                case 8: return chu = " tam";
                case 9: return chu = "chin";
                case 10: return chu = "muoi";
                default: return "so khong hop le";
            }
        }
        static double Can_bac_n(int x, double n)
        {
            return Math.Pow(x,1/n);
        }
        static void Main(string[] args)
            {
                
            }
                
    }
}