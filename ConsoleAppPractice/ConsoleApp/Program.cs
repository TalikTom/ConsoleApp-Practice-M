using ConsoleApp;

MainMenu();

static void MainMenu()
{
    Console.Write("\nOptions" +
        ":\n");
    Console.Write("1: Parity\n2: Quadratic\n3: PROSJEK\n4: ZNAMENKE\n5: LOTO\n6: LISTIĆ\n7: OSOBA\n8: PDF\n9: EXIT");

    int input;

    Console.Write("\nInput your choice: ");
    while (!int.TryParse(Console.ReadLine(), out input))
    {
        Console.WriteLine("Invalid input! Please enter a valid number.\n");
    }

    switch (input)
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
           
            break;

        case 4:
            
            break;

        case 6:

            break;

        case 7:

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