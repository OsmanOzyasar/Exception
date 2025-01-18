using System;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");

            bool isTrue = false;
            int userInput = 0;
            while (!isTrue)
            {
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                    isTrue = true;

                }
                catch (System.Exception)
                {

                    Console.WriteLine("Geçerli bir sayı değeri giriniz.");
                }
            }

            int result = userInput * userInput;

            Console.WriteLine("Sayının karesi -> " + result);
			
        }
    }
}