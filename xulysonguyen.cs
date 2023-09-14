using System;
namespace Bai_tap17
{
    class Xu_ly_so_nguyen
    {
        public static double tinh_giai_thua(int x)
        {
            double giai_thua = 1;
            for(double i = 1; i <= x; i++)
            {
                giai_thua *= i;
            }
            return giai_thua;
        }
    }
}