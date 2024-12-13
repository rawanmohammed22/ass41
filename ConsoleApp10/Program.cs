using System.Threading.Channels;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //#region  explict 

            //long x = 10000000000000000000000;


            bool flag = int.TryParse(Console.ReadLine(), out int p);
            Console.WriteLine(flag);


            if (flag == true)
            {

                if (p % 3 == 0 && p % 4 == 0)
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");

            }


            ////int y = x.GetType() == typeof(int) ? (int)x : 0;
            ////Console.WriteLine(y);
            //int o;
            //string t ="9";
            //Boolean flag = int.TryParse(t, out o);
            //Console.WriteLine(flag);
            //Console.WriteLine(o);

            ////#endregion
            ////int f = 9;
            ////++f;

            ////Console.WriteLine(f);
            ////Console.WriteLine(f++);


            ////Console.WriteLine(f);

            ////int d;
            ////d = Convert.ToInt32(!(30 < 20));  


            ////Console.WriteLine(d);

















        }
    }
}
