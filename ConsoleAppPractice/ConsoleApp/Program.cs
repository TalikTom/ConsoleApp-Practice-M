using ConsoleApp;

MainMenu();

static void MainMenu()
{
    Console.Write("\nOptions" +
        ":\n");
    Console.Write("1: Parity\n2: Quadratic\n3: Average\n4: Numerals\n5: Loto\n6: Ticket\n7: OSOBA\n8: PDF\n9: EXIT");

    int result = Helper.GetIntFromConsole("\nChoose your option: ");

    switch (result)
    {
        case 1:
            Parity.CheckParity();
            Console.Clear();
            MainMenu();
            break;

        case 2:
            Quadratic.CalculateQuadratic();
            Console.Clear();
            MainMenu();
            break;

        case 3:
            Average.CalculateGradeAverage();
            Console.Clear();
            MainMenu();
            break;

        case 4:
            Numerals.SumLastDigits();
            Console.Clear();
            MainMenu();
            break;

        case 5:
            Loto.GenerateLoto(7,45);
            Console.Clear();
            MainMenu();
            break;

        case 6:
            Loto.GenerateLoto(6, 49);
            Console.Clear();
            MainMenu();
            break;

        case 8:

            break;

        case 9:
            Console.WriteLine("----------------------------------------------------------- \n");
            Console.Write("Goodbye\n");

            break;

        default:
            Console.Clear();
            Console.Write("Not, fair... Input correct option between 1 and 5\n");
            MainMenu();
            break;


    }
}