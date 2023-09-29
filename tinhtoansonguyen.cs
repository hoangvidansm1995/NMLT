using System;
namespace NMLT;
    class Tinh_toan_so_nguyen
    {
        public static double Factorial(int x)
        {
            double giai_thua = 1;
            for(double i = 1; i <= x; i++)
            {
                giai_thua *= i;
            }
            return giai_thua;
        }
        public static int Power_of(int x, int n)
        {
            int so_mu = 1;
            for (int i =1; i<=n; i++)
            {
                so_mu *= x;
            }
            return so_mu;
        }
        public static double Sum_n(int n)
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
        public static double Square_root_of(int x, double n)
        {
            return Math.Pow(x,1/n);
        }
    }