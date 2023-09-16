using System;
using System.Diagnostics.CodeAnalysis;
namespace NMLT
{
    class Xu_ly_so_nguyen
    {
        public static int So_dao_nguoc(int n)
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
        public static string Number_to_string(int a)
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
        public static int BCNN(int a, int b)
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
        public static bool Is_prime(int a)
        {
            if (a<=1) return false;
            for (int i = 2; i<=a/2; i++)
            {
                if (a%i==0) return false;
            }
            return true;
        }
        public static void Permutation(ref double x,ref double y)
        {
            double t=x;
            x=y;
            y=t;
        }
        public static int UCLN(int a, int b)
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
        public static int Day_of_month(int thang, int nam)
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
                case 2: return (Is_leap_year(nam))? 29:28;
                default:
                return -1;
            }
        }
        public static bool Is_leap_year(int nam)
        {
            if (nam % 100 != 0 & nam % 4 ==0) return true;
            return false;
        }
        public static int Numbers_of_Number(int a)
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
        public static bool Is_Perfect_Number(int a)
        {
            int sum = 0;
            for ( int i =1; i< a; i ++)
            {  
                if( a%i ==0) sum += i;
            }
            if (sum == a) return true;
            return false;
        }
    }
}