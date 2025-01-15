class NumberSystem
{
    public static void binaryToDecimal()
    {
        int binary = Input.binaryInput();
        int sum = 0;
        int power = 1;
        int remainder;

        while (binary != 0)
        {
            remainder = binary % 10;
            sum += remainder * power;
            binary /= 10;
            power *= 2;
        }

        Console.WriteLine($"{binary} to decimal is {sum}");
        
    }


     public static void decimalToBinary()
    {
        int decimalNumber = Input.decimalInput();
        int binaryValue = 0;
        int remainder;
        int placeValue = 1;

        while (decimalNumber != 0)
        {
            remainder = decimalNumber % 2;
            binaryValue += remainder * placeValue;
            placeValue *= 10;
            decimalNumber /= 2;
        }

        Console.WriteLine($"{decimalNumber} to binary is {binaryValue}");
    }

    public static void choice()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
            binaryToDecimal();
            break;

            case 2:
            decimalToBinary();
            break;

            default:
            Console.WriteLine("Enter the valid choice");
            return;
        }

    }

}