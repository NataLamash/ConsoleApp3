using ConsoleApp3;
public class Program
{
    static void Main()
    {
        decimal usdRate = 41;
        decimal eurRate = 44;
        Converter converter = new Converter(usdRate, eurRate);

        while (true)
        {
            Console.WriteLine("Select conversion type:");
            Console.WriteLine("1. Hryvnia -> Dollar");
            Console.WriteLine("2. Hryvnia -> Euro");
            Console.WriteLine("3. Dollar -> Hryvnia");
            Console.WriteLine("4. Euro -> Hryvnia");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter amount in Hryvnia: ");
                    decimal uahToUsd = decimal.Parse(Console.ReadLine());
                    Console.WriteLine($"Amount in USD: {converter.ConvertToUSD(uahToUsd)}");
                    break;

                case 2:
                    Console.Write("Enter amount in Hryvnia: ");
                    decimal uahToEur = decimal.Parse(Console.ReadLine());
                    Console.WriteLine($"Amount in EUR: {converter.ConvertToEUR(uahToEur)}");
                    break;

                case 3:
                    Console.Write("Enter amount in USD: ");
                    decimal usdToUah = decimal.Parse(Console.ReadLine());
                    Console.WriteLine($"Amount in Hryvnia: {converter.ConvertFromUSD(usdToUah)}");
                    break;

                case 4:
                    Console.Write("Enter amount in EUR: ");
                    decimal eurToUah = decimal.Parse(Console.ReadLine());
                    Console.WriteLine($"Amount in Hryvnia: {converter.ConvertFromEUR(eurToUah)}");
                    break;

                 case 5:
                    return;


                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}

