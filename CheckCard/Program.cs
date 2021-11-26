using System;
using System.IO;

namespace CheckCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using StreamReader sr = new StreamReader(@"E:\.net\CheckCard\CheckCard\Input.txt");
            using StreamWriter sw = new StreamWriter(@"E:\.net\CheckCard\CheckCard\Output.txt");

            string value = sr.ReadToEnd();
           // string value = "2 3";
            sw.WriteLine(value);


            string[] vs = value.Split(' ');
            int p = int.Parse(vs[0]);

            int k = int.Parse(vs[1]);


            int count = 0;


            for (int i = 0; p+i <= k; i++)
            {
                int cards = p + i;

                while (cards != 2)
                {
                    if (cards % 2 == 0)
                    {
                        cards /= 2;

                    }
                    else
                    {
                        cards = (cards * 3) + 1;


                    }
                    count++;
                   //
                    
                   // sw.WriteLine(count);
                  //  sw.WriteLine(value);


                }





            }
            sw.WriteLine(count);
           // Console.WriteLine(count);




        }


    }
}
