using System.Reflection.Emit;

class BasicCalculation
{

    public static void addition(double operator1, double operator2)
    {
        Console.WriteLine($"Sum: {operator1 + operator2}");
    }

    public static void subtraction(double operator1, double operator2)
    {
        Console.WriteLine($"Sub: {operator1 - operator2}");
    }


    public static void multiplication(double operator1, double operator2)
    {
        Console.WriteLine($"Multiplication: {operator1 * operator2}");
    }


    public static void division(double operator1, double operator2)
    {
        while (true)
        {
            if (operator2 == 0)
            {
                Console.WriteLine("Divident cannot be zero!!!");
                Input.basicInput();
            }
            
            else
            {
                 Console.WriteLine($"Division: {operator1 / operator2}");
                 break;
            }
        }
    }

    public static void calculation()
    {
        var input = Input.basicInput();
        char operand = input.operandValue;
        double operand1 = input.operatorValue1;
        double operand2 = input.operatorValue2;
        
        switch(operand)
        {
            case '-':
            subtraction(operand1, operand2);
            break;


            case '+':
            addition(operand1, operand2);
            break;


            case '*':
            multiplication(operand1, operand2);
            break;



            case '/':
            division(operand1, operand2);
            break;


            
            default:
            Console.WriteLine("Please Choose from option.");
            return;
        }

    }



}