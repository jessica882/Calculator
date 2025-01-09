using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Security.AccessControl;

class Input
{
    public static double integerValidity()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if(double.TryParse(input, out double checkedInteger))
            {
                return checkedInteger;
            }
            else
            {
                Console.WriteLine("Please enter an integer!!!");
            }
        }
    }


    public static char charValidity()
    {

        while(true)
        {
            string? input = Console.ReadLine();
            if(char.TryParse(input, out char checkedchar))
            {
                return checkedchar;
            }
            else
            {
                Console.WriteLine("Please enter listed option!!!");
            }

        }
    }

    public static (double,char,double) basicInput()
    {
        Console.WriteLine("Enter the first number:");
        double operator1 = Input.integerValidity();
        
        char operand;
        while(true)
        {
            Console.WriteLine("Choose an operand: +, -, *, /");
            operand = charValidity();
            if (operand == '/' || operand == '*' || operand == '+' || operand == '-')
            {
                break; 
            }
            else
            {
                Console.WriteLine("Please input a valid option!!!");
            }
        }

        Console.WriteLine("Enter the second number:");
        double operator2 = Input.integerValidity();

        return (operator1,operand,operator2);
    }

    public static string arithmeticExpressionInput()
    {
        while(true)
        {
            Console.WriteLine("Enter the expression:");
            string? expression = Console.ReadLine();
            if(expression == null)
            {
                Console.WriteLine("Please enter an expression!!!");
            }
            else
            {
                return expression;
            }

        }
    }

    public static double trigonometricInput()
    {
        while(true)
        {
            Console.WriteLine("Enter angle:");
            string? input = Console.ReadLine();

            if(double.TryParse(input, out double angle))
            {
                double radiant = angle*(Math.PI/180);
                return(radiant);
            }
            else
            {
                Console.WriteLine("Enter a valid angle!!!");
            }

        }
    }
    
}