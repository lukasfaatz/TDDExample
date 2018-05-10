using System;

namespace TDDExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                StringCalculator sC = new StringCalculator();
                sC.Calculate("-12");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
    }
}
