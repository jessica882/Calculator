class ScientificCalculation
{

    public static void calculation()
    {
        int choice = int.Parse(Console.ReadLine());
        double radiant = Input.trigonometricInput();
        double result1 = 0;
        string result2 = "infinite";

        switch(choice)
        {
            case 1:
            result1 = Math.Sin(radiant);
            break;

            case 2:
            result1 = Math.Cos(radiant);
            break;

            case 3:
            result1 = Math.Tan(radiant);
            break;

            case 4:
            if((Math.Sin(radiant)) == 0)
            {
                Console.WriteLine(result2);
            }
            else
            {
                result1 = 1/ Math.Sin(radiant);
            }
            break;

            case 5:
            if((Math.Cos(radiant)) == 0)
            {
                Console.WriteLine(result2);
            }
            else
            {
                result1 = 1/ Math.Sin(radiant);
            }
            break;

            case 6:
            if((Math.Tan(radiant)) == 0)
            {
                Console.WriteLine(result2);
            }
            else
            {
                result1 = 1/ Math.Sin(radiant);
            }
            break;

            default:
            Console.WriteLine("Enter valid funtion!!!");
            return;

        }

        Console.WriteLine(result1);
    }
}