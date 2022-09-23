using System;

namespace kalkulator
{
    public class CalCulator  
    {
        static void Main(string[] args)
        {
            a:
            double num1, num2;
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Substraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine(" ");
            double no = Convert.ToDouble(Console.ReadLine());

            
            switch(no){
                case 1 :
                Console.WriteLine("Enter 1st Input");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter 2nd Input");
                num2 = Convert.ToDouble(Console.ReadLine());
                Add(num1,num2);
                break;
                case 2 :
                Console.WriteLine("Enter 1st Input");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter 2nd Input");
                num2 = Convert.ToDouble(Console.ReadLine());
                Subtract(num1,num2);
                break;
                case 3 :
                Console.WriteLine("Enter 1st Input");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter 2nd Input");
                num2 = Convert.ToDouble(Console.ReadLine());
                Multiply(num1,num2);
                break;
                case 4 :
                Console.WriteLine("Enter 1st Input");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter 2nd Input");
                num2 = Convert.ToDouble(Console.ReadLine());
                Division(num1,num2);
                break;
                default:
                goto a;
            }  
        }
        // Add two doubleegers and returns the sum  
        static void Add(double num1, double num2)  
        {  
            Console.WriteLine("The result is {0}",num1 + num2);
        }  
    
        // Multiply two doubleegers and retuns the result  
        static void Multiply(double num1, double num2)  
        {  
            Console.WriteLine("The result is {0}",num1 + num2);  
        }  
        // Subtracts small number from big number  
        static void Subtract(double num1, double num2)  
        {  
            Console.WriteLine("The result is {0}",num1 - num2);   
        }
        static void Division(double num1, double num2)   
        {  
            Console.WriteLine("The result is {0}",num1 / num2);   
        }
    } 
}