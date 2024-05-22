using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Primes_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Stopwatch inputStopwatch = new Stopwatch();
            inputStopwatch.Start();

            int baslangicS = Convert.ToInt32(Console.ReadLine());
            int sonS = Convert.ToInt32(Console.ReadLine());
            inputStopwatch.Stop();

            TimeSpan inputTime = inputStopwatch.Elapsed;

            Class1 class1 = new Class1();
            Thread thread = new Thread(() => class1.asalBul(baslangicS, sonS));
            thread.Start();
            thread.Join();


            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;
            TimeSpan totalTime = ts - inputTime;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                totalTime.Hours, totalTime.Minutes, totalTime.Seconds,
                totalTime.Milliseconds / 10);
            Console.WriteLine("Programın çalışma süresi (veri girişi hariç): " + elapsedTime);

            Console.ReadLine();
        
        }
    }
}
