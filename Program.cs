using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
namespace Сonsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            bool condition = true;
        start:
            while (condition) 
            {
                string choice;
                Console.WriteLine("\nVitalii Bobyr - 05/13/24");
                Console.WriteLine("Programming 120 - F22 - Midterm Menu");
                Console.WriteLine($"1 - Personal Calculator\n2 - Finance Calculator\n3 - Geometry Calculator\n4 - Cartesian Plane\ne - Exit Calculator\nChoose your selection");
                choice = Console.ReadLine().ToLower();
                
                

                try
                {
                    switch (choice)
                    {
                        case "1": 
                            Console.WriteLine("Personal Calculator");
                            string case_1;
                        personal_calculator:
                            int number_1 = 0, number_2 = 0, result=0;
                            Console.WriteLine("\nEnter you first number: ");
                            number_1=int.Parse(Console.ReadLine());
                            Console.WriteLine("+ - Add\n- - Subtract\n* - Multiply\n/ - Divide\ne - Exit Personal Calculator\nChoose your selection");
                            case_1 = Console.ReadLine().ToLower();
                            try 
                            {  switch (case_1)
                                {
                                    case "+":
                                        number_2 = int.Parse(Console.ReadLine());
                                        result = number_1 + number_2;
                                        Console.WriteLine($"{result}");
                                        goto personal_calculator;
                                    case "-":
                                        number_2 = int.Parse(Console.ReadLine());
                                        result = number_1 - number_2;
                                        Console.WriteLine($"{result}");
                                        goto personal_calculator;
                                    case "*":
                                        number_2 = int.Parse(Console.ReadLine());
                                        result = number_1 * number_2;
                                        Console.WriteLine($"{result}");
                                        goto personal_calculator;
                                    case "/":
                                        number_2 = int.Parse(Console.ReadLine());
                                        result = number_1 / number_2;
                                        Console.WriteLine($"{result}");
                                        goto personal_calculator;
                                    case "e":Console.WriteLine("Exiting Calculator");
                                        goto start;
                                    default:
                                        Console.WriteLine("You entered something another than +, -, * or /.");
                                        goto personal_calculator;
                                }

                            }
                            catch
                            {
                                Console.WriteLine("Something going wrong! Please try again!");
                                goto personal_calculator;
                            }
                        
                            break;

                        case "2": finance: 
                            Console.WriteLine("\nFinance Calculator");
                            string letter;  
                            Console.WriteLine("1 - Net Income\n2 - Rule of 72\n3 - Net Worth\ne - Exit Finance Calculator\nChoose your selection");
                            letter = Console.ReadLine().ToLower();
                            
                            try 
                            { 
                               switch (letter)
                               {
                                case "1": Console.WriteLine("Net Income");
                                        double income = 0, costs = 0;
                                        Console.WriteLine("Enter your income");
                                        income = double.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter your costs");
                                        costs = double.Parse(Console.ReadLine());
                                        Console.WriteLine($"You Net Income will be: {Math.Round(income - costs, 3)}$");
                                    goto finance;
                                case "2": Console.WriteLine("Rule of 72");
                                        Console.WriteLine("Enter the expected interest rate: ");
                                        double interest = 0;
                                        interest=double.Parse(Console.ReadLine());
                                        Console.WriteLine($"At an interest rate of {interest}% it will take {Math.Round(72/interest,1)} years to double your $");
                                    goto finance;
                                case "3": Console.WriteLine("Net Worth");
                                        double assets = 0, liabilities = 0;
                                        Console.WriteLine("Enter your income");
                                        assets = double.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter your costs");
                                        liabilities = double.Parse(Console.ReadLine());
                                        Console.WriteLine($"You Net Worth will be: {Math.Round(assets - liabilities, 3)}$");
                                        goto finance;
                                case "e": Console.WriteLine("Exiting Calculator");
                                    goto start;
                                    default:
                                    Console.WriteLine("You entered a number other than 1, 2, 3 or e.");
                                    goto finance;
                               }
                            }
                            catch 
                            {  
                                Console.WriteLine("Something going wrong! Please try again!");
                                goto finance;
                            }
                                                        
                        case "3": geometry:
                            Console.WriteLine("\nGeometry Calculator");
                            string geometry;
                            Console.WriteLine("1 - Square\n2 - Rectangle\n3 - Circle\n4 - Right Circular Cone \ne - Exit Finance Calculator\nChoose your selection");
                            geometry = Console.ReadLine().ToLower();
                            try
                            {
                                switch (geometry)
                                {
                                    case "1": Console.WriteLine("Square");
                                        double side;
                                        Console.WriteLine("Enter the length of one side of the square");
                                        side = double.Parse(Console.ReadLine());
                                        Console.WriteLine($"Area of a square will be: {side*side} sq.feets and perimeter of a square will be {side*4} feets");
                                        goto geometry;

                                    case "2": Console.WriteLine("Rectangle");
                                        double length = 0, width = 0; ;
                                        Console.WriteLine("Enter the length of the rectangle");
                                        length = double.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter the width of the rectangle");
                                        width = double.Parse(Console.ReadLine());
                                        Console.WriteLine($"Area of a rectangle will be: {length * width} sq.feets and perimeter of a square will be {(length + width)*2} feets");
                                        goto geometry;

                                    case "3": Console.WriteLine("Circle");
                                        double radius = 0;
                                        Console.WriteLine("Enter the radius of the circle");
                                        radius = double.Parse(Console.ReadLine());
                                        Console.WriteLine($"Area of this cicle will be:{Math.Round(Math.PI*(radius*radius),3)} sq.feets and circumference will be: {Math.Round(2* Math.PI * radius, 3)} feets");
                                        goto geometry;
                                    case "4": Console.WriteLine("Right Circular Cone");
                                        double radius_cone = 0,height = 0;
                                        Console.WriteLine("Enter the radius of the cone");
                                        radius_cone = double.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter the height of the cone");
                                        height=double.Parse(Console.ReadLine());
                                        Console.WriteLine($"Volume of the cone will be: {Math.Round(0.333 * Math.PI* radius_cone * radius_cone *height,2)} cubic feets");
                                        goto geometry;
                                    case "e": Console.WriteLine("Exiting Calculator"); goto start;
                                    default:
                                        Console.WriteLine("You entered a number other than 1, 2, 3, 4 or e.");
                                        goto geometry;
                                        
                                }

                            }

                            catch
                            {
                                Console.WriteLine("Something going wrong! Please try again!");
                                goto geometry;
                            }
                            

                        case "4": 
                            Console.WriteLine("\nCartesian Plane");
                            try 
                            {
                                Console.Write("Enter the x-coordinate: ");
                                int x = int.Parse(Console.ReadLine());

                                Console.Write("Enter the y-coordinate: ");
                                int y = int.Parse(Console.ReadLine());

                                string quadrant = DetermineQuadrant(x, y);
                                Console.WriteLine($"The point ({x}, {y}) is in {quadrant}.");
                            }

                            catch 
                            {
                                Console.WriteLine("Invalid input. Please enter numerical values for coordinates.");
                            }

                            static string DetermineQuadrant(double x, double y)
                            {
                                if (x == 0 && y == 0)
                                {
                                    return "point located on Origin";
                                }
                                else if (x == 0 || y == 0)
                                {
                                    return "point located on AXIS";
                                }
                                else if (x > 0)
                                {
                                    return y > 0 ? "Quadrant I" : "Quadrant IV";
                                }
                                else
                                {
                                    return y > 0 ? "Quadrant II" : "Quadrant III";
                                }
                            }
                            break;
                        case "e":Console.WriteLine("Exit from Calculator");
                            condition = false;
                            break;

                        default:
                            Console.WriteLine("You entered a number other than 1, 2, 3 or 4.");
                        goto start;
                            
                    }
                }
                catch 
                {
                    Console.WriteLine("Something going wrong! Please try again!");
                    goto start;
                }
           }

        }
    }
}