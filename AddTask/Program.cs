using System;

namespace AddTask
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Створіть клас Calculator, методи якого приймають аргументи і повертають значення типу dynamic.
     */
    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            int operand1 = 20, operand2 = 8;

            Console.WriteLine("{0} + {1} = {2}", operand1, operand2, calculator.Add(operand1, operand2));
            Console.WriteLine("{0} - {1} = {2}", operand1, operand2, calculator.Sub(operand1, operand2));
            Console.WriteLine("{0} * {1} = {2}", operand1, operand2, calculator.Mul(operand1, operand2));
            Console.WriteLine("{0} / {1} = {2}", operand1, operand2, calculator.Div(operand1, operand2));

            // Delay.
            Console.ReadKey();
        }
    }
}
