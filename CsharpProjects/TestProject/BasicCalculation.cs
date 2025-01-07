using System.Reflection.Emit;

class BasicCalculation
{

    static (double operator1, char operand, double operator2)t = Input.basicInput();


    public static void addition()
    {
        Console.WriteLine($"Sum: {t.operator1 + t.operator2}");
    }

    public static void subtraction()
    {
        Console.WriteLine($"Sub: {t.operator1 - t.operator2}");
    }


    public static void multiplication()
    {
        Console.WriteLine($"Multiplication: {t.operator1 * t.operator2}");
    }


    public static void division()
    {
        while (true)
        {
            if (t.operator2 == 0)
            {
                Console.WriteLine("Divident cannot be zero!!!");
                (double operator1, char operand, double operator2)t = Input.basicInput();
            }
            else
            {
                 Console.WriteLine($"Division: {t.operator1 / t.operator2}");
                 break;
            }
        }
    }

    public static void calculation()
    {
        switch(t.operand)
        {
            case '-':
            subtraction();
            break;


            case '+':
            addition();
            break;


            case '*':
            multiplication();
            break;



            case '/':
            division();
            break;


            
            default:
            Console.WriteLine("Please Choose from option.");
            return;
        }

    }



}