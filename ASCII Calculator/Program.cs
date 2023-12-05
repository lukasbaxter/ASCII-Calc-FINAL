using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            printInitializing();

            string input;
            double firstOperand;
            double secondOperand;
            double answer;

            printCalculator("");

            // Get first operand
            Console.WriteLine("First Operand:");
            input = Console.ReadLine();
            firstOperand = Convert.ToDouble(input);

            // Show current expression
            string expression = Convert.ToString(firstOperand);
            printCalculator(expression);

            string theOperator = getOperator();

            if (theOperator == "sqrt")
            {
                expression = Convert.ToString("√" + firstOperand);
                printCalculator(expression);

                // Prompt for calculation
                Console.ReadLine();

                answer = Math.Pow(firstOperand, .5);

            } else {
                // Show current expression
                expression = Convert.ToString(firstOperand + " " + theOperator);
                printCalculator(expression);

                // Get second operand
                input = Console.ReadLine();
                secondOperand = Convert.ToDouble(input);

                // Show current expression
                expression = Convert.ToString(firstOperand + " " + theOperator + " " + secondOperand);
                printCalculator(expression);

                // Prompt for calculation
                Console.ReadLine();

                answer = calculate(firstOperand, secondOperand, theOperator);
            }

        
            expression = Convert.ToString(Math.Round(answer, 5));
            printCalculator(expression);

        }

        static void printInitializing() {
            string initASCII_1 = "*     ______            __    __      __            __  __            __                         ";
            string initASCII_2 = "*    /      |          /  |  /  |    /  |          /  |/  |          /  |                        ";
            string initASCII_3 = "*    $$$$$$/  _______  $$/  _$$ |_   $$/   ______  $$ |$$/  ________ $$/  _______    ______      ";
            string initASCII_4 = "*      $$ |  /      \\ /  |/ $$   |  /  | /     \\ $$ |/  |/        |/  |/      \\  /     \\     ";
            string initASCII_5 = "*      $$ |  $$$$$$$  |$$ |$$$$$$/   $$ | $$$$$$  |$$ |$$ |$$$$$$$$/ $$ |$$$$$$$  |/$$$$$$  |    ";
            string initASCII_6 = "*      $$ |  $$ |  $$ |$$ |  $$ | __ $$ | /    $$ |$$ |$$ |  /  $$/  $$ |$$ |  $$ |$$ |  $$ |    ";
            string initASCII_7 = "*     _$$ |_ $$ |  $$ |$$ |  $$ |/  |$$ |/$$$$$$$ |$$ |$$ | /$$$$/__ $$ |$$ |  $$ |$$\\__$$ |    ";
            string initASCII_8 = "*    / $$   |$$ |  $$ |$$ |  $$  $$/ $$ |$$    $$ |$$ |$$ |/$$      |$$ |$$ |  $$ |$$    $$ |    ";
            string initASCII_9 = "*    $$$$$$/ $$/   $$/ $$/    $$$$/  $$/  $$$$$$$/ $$/ $$/ $$$$$$$$/ $$/ $$/   $$/  $$$$$$$ |    ";
            string initASCII_10 = "*                                                                                  / \\__$$ |    ";
            string initASCII_11 = "*                                                                                  $$    $$/     ";
            string initASCII_12 = "*                                                                                   $$$$$$/      ";
            for (int i = 0; i < 2; i++) // Loop starts
            {
                Console.WriteLine(initASCII_1);
                Console.WriteLine(initASCII_2);
                Console.WriteLine(initASCII_3);
                Console.WriteLine(initASCII_4);
                Console.WriteLine(initASCII_5);
                Console.WriteLine(initASCII_6);
                Console.WriteLine(initASCII_7);
                Console.WriteLine(initASCII_8);
                Console.WriteLine(initASCII_9);
                Console.WriteLine(initASCII_10);
                Console.WriteLine(initASCII_11);
                Console.WriteLine(initASCII_12);
                Thread.Sleep(1500);
                Console.Clear();
                Thread.Sleep(500);
            } // Loop ends
        }

        static string getOperator()
        {
            string[] sqrt = ["sqrt"];
            string[] pow = ["pow", "^", "power"];
            string[] mult = ["x", "multiply", "*", "mult", "multply"];
            string[] div = ["/", "divide", "division", "div"];
            string[] add = ["add", "addition", "+"];
            string[] sub = ["subtract", "sub", "minus", "-"];
            while (true)
            {
                Console.WriteLine("Operator:");
                string theOperator = Console.ReadLine().Trim().ToLower();
                if (mult.Contains(theOperator))
                {
                    return "*";
                }
                else if (div.Contains(theOperator))
                {
                    return "/";
                }
                else if (add.Contains(theOperator))
                {
                    return "+";
                }
                else if (sub.Contains(theOperator))
                {
                    return "-";
                }
                else if (pow.Contains(theOperator))
                {
                    return "^";
                }
                else if (sqrt.Contains(theOperator))
                {
                    return "sqrt";
                }
                Console.WriteLine("Invalid operator");
            }
        }

        static double calculate(double firstOperand, double secondOperand, string theOperator)
        {

            if (theOperator == "*")
            {
                return firstOperand * secondOperand;
            }
            else if (theOperator == "/")
            {
                return firstOperand / secondOperand; ;
            }
            else if (theOperator == "+")
            {
                return firstOperand + secondOperand;
            }
            else if (theOperator == "-")
            {
                return firstOperand - secondOperand;
            }
            else if (theOperator == "^")
            {
                return Math.Pow(firstOperand, secondOperand);
            }
            throw new Exception("Invalid operator");
        }
        static void printCalculator(string expression)
        {
            Console.Clear();
            string initASCII_B1 = " _____________________";
            string initASCII_B2 = "|  _________________  |";
            string initASCII_B3_START = "| |";
            string initASCII_B3_END = "| |";
            string initASCII_B4 = "| |_________________| |";
            string initASCII_B5 = "|  ___ ___ ___   ___  |";
            string initASCII_B6 = "| | 7 | 8 | 9 | | + | |";
            string initASCII_B7 = "| |___|___|___| |___| |";
            string initASCII_B8 = "| | 4 | 5 | 6 | | - | |";
            string initASCII_B9 = "| |___|___|___| |___| |";
            string initASCII_B10 = "| | 1 | 2 | 3 | | x | |";
            string initASCII_B11 = "| |___|___|___| |___| |";
            string initASCII_B12 = "| | . | 0 | = | | / | |";
            string initASCII_B13 = "| |___|___|___| |___| |";
            string initASCII_B14 = "|_____________________|";
            Console.WriteLine(initASCII_B1);
            Console.WriteLine(initASCII_B2);
            string line = initASCII_B3_START;
            line = line.PadRight(20 - expression.Length);
            line += expression;
            line += initASCII_B3_END;
            Console.WriteLine(line);
            Console.WriteLine(initASCII_B4);
            Console.WriteLine(initASCII_B5);
            Console.WriteLine(initASCII_B6);
            Console.WriteLine(initASCII_B7);
            Console.WriteLine(initASCII_B8);
            Console.WriteLine(initASCII_B9);
            Console.WriteLine(initASCII_B10);
            Console.WriteLine(initASCII_B11);
            Console.WriteLine(initASCII_B12);
            Console.WriteLine(initASCII_B13);
            Console.WriteLine(initASCII_B14);
            Console.WriteLine("");
        }
    }
}