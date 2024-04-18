using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class CustomException: Exception
    {
        public CustomException(string message):base(message) { }
    }

    internal class Program
    {
        static void Main()
        {
            Exception[] exceptions = 
            {
                new DivideByZeroException(),
                new FormatException(),
                new IndexOutOfRangeException(),
                new InvalidOperationException(),
                new CustomException("My exception")
            };

            foreach (Exception ex in exceptions)
            {
                try
                {
                    throw ex;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("DivideByZeroException caught" +
                        $"\n{ex.Message}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("FormatException caught" +
                        $"\n{ex.Message}");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("IndexOutOfRangeException caught" +
                        $"\n{ex.Message}");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("InvalidOperationException caught" +
                        $"\n{ex.Message}");
                }
                catch (CustomException)
                {
                    Console.WriteLine("CustomException caught:" + $"\n{ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Finally block");
                }
            }
        }
    }
}
