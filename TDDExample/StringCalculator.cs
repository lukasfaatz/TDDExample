
using System;
namespace TDDExample
{
    public class StringCalculator
    {
        public StringCalculator()
        {

        }

        public int Calculate(String input)
        {
            char[]  delimiter = { ',', '\n', '%', '.' };

            if (input.Length == 0) 
            {
                return 0;
            } 
            else 
            {
                var elements = input.Split(delimiter);

                return CalculateValues(elements);
            }
        }


        public int CalculateValues(String[] values)
        {
            var sum = 0;

            foreach (var element in values)
            {
                if (Int32.TryParse(element, out Int32 number))
                {
                    FindDangerousInput(number);
                    sum += number;
                }
            }

            return sum;
        }

        public void FindDangerousInput(int number)
        {
            if (number < 0) throw new NegativeNumbersException("No negative Numbers");
            if (number > 1000) throw new NumberGreaterThanThousandException("String contains number greater than 1000");

        }
    }

 




    public class NegativeNumbersException : Exception
    {
        public NegativeNumbersException()
        {

        }

        public NegativeNumbersException(string message) : base(message)
        {

        }

        public NegativeNumbersException(string message, Exception inner) : base(message, inner)
        {

        
        }
    }

    public class NumberGreaterThanThousandException : Exception
    {
        public NumberGreaterThanThousandException()
        {

        }

        public NumberGreaterThanThousandException(string message) : base(message)
        {

        }

        public NumberGreaterThanThousandException(string message, Exception inner) : base(message, inner)
        {


        }
    }
}
