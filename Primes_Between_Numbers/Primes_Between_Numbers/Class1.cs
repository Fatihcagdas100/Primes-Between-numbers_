using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Primes_Between_Numbers
{
    internal class Class1
    {
        public void asalBul(int baslangicS, int sonS)
        {
            if (baslangicS <= 1)
                baslangicS = 2;
            for (int i = sonS; i >= baslangicS; i--)
            {
                double kok = Math.Sqrt(i);
                bool kontrol = true;
                for (int j = 2; kontrol != false && j <= kok; j++)
                {
                    if (i % j == 0)
                        kontrol = false;
                }
                if (kontrol == true)
                    Console.WriteLine(i);
            }
        }
    }
}
