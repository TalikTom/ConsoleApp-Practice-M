using ConsoleApp;

MainMenu();

static void MainMenu()
{
    Console.Write("\nOptions" +
        ":\n");
    Console.Write("1: Parity\n2: Quadratic\n3: Average\n4: Numerals\n5: Loto\n6: Ticket\n7: Person Menu\n8: PDF\n9: Exit");

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
            Ticket.LotoGrid(1, 49, 7);
            Console.Clear();
            MainMenu();
            break;

        case 7:
            Console.Clear();
            PersonMenu();

            break;

        case 8:
            Loto.simpleCreatePDF(Loto.LotoString);

            break;


        case 9:
            Console.WriteLine("----------------------------------------------------------- \n");
            Console.Write("Goodbye\n");

            break;

        default:
            Console.Clear();
            Console.Write("Not, fair... Input correct option between 1 and 9\n");
            MainMenu();
            break;


    }

    static void PersonMenu()
    {
        Console.Write("\nOptions" +
            ":\n");
        Console.Write("1: Add people\n2: View People\n3: Get oldest person\n4: Get youngest person\n5: Number of females\n6: Number of males\n7: Get number of people born before year 2000\n9: Back to main menu");

        int result = Helper.GetIntFromConsole("\nChoose your option: ");

        switch (result)
        {
            case 1:
                Person.AddPeople();
                Console.Clear();
                PersonMenu();
                break;

            case 2:
                Person.ViewPeople();
                Console.Clear();
                PersonMenu();
                break;

            case 3:
               
                break;

            case 4:
               
                break;

            case 5:
                
                break;

            case 6:
                
                break;

            case 7:

                break;

            case 8:
               
                break;


            case 9:
                Console.Clear();
                MainMenu();                

                break;

            default:
                Console.Clear();
                Console.Write("Not, fair... Input correct option between 1 and 9\n");
                MainMenu();
                break;


        }
    }
}