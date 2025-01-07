using System.Reflection.Emit;

class Input
{
    public static double integerValidity()
    {
        while (true)
        {
            string input = Console.ReadLine();
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
            string input = Console.ReadLine();
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
        do
        {
            Console.WriteLine("Choose the operand: /, *, -, +");
            operand = Input.charValidity();
        }while(operand != '/' || operand != '*' || operand != '+' || operand != '-');
        {
            Console.WriteLine("Please input valid option!!!");
        }

        Console.WriteLine("Enter the second number:");
        double operator2 = Input.integerValidity();

        return (operator1,operand,operator2);
    }
    
}