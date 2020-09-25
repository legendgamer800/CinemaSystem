using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //NOTE - PLEASE USE UK DATE FORMAT(DD/MM/YYYY) IN VISUAL BASIC AND US DATE FORMAT (MM/DD/YYYY) ON REPL.IT

        // Phase 0 - Assign variables
        
        System.Random random = new System.Random();
        int TicketNumber = random.Next(00000000, 99999999); //randomly generating ticket number
        int Age = 0;
        int FilmChoice = 0;
        int AutoRun = 0;
        int AgeID = 0;
        double TicketPrice = 1.23;
        string FilmChoiceWrite = ("Filler");
        string DateInput = ("01/01/2020");
        DateTime ChosenDate;
        DateTime today = DateTime.Now;
        DateTime DeadlineDate = today.AddDays(7);

        //Automatic running of the code
        while (AutoRun < 1)
        {
            do
            {
                //Phase 1 - Get user info
                Console.WriteLine("Welcome to your local cinema, please choose from one of our movies: \n----------------------------\n 1.) Kids movie (U) \n 2.) Family movie (PG) \n 3.) Action movie (12A) \n 4.) Documentary (15) \n 5.) Thriller movie (18) \n");
                Console.WriteLine(" ----------------------------\n Today's Ticket prices are as followed:\n Adult (18+) - £4.00\n Teen (13-17) - £3.25\n Child (3-12) - £2.50\n Baby (0-2) = Free \n----------------------------");
                FilmChoice = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter your age.");
                Age = int.Parse(Console.ReadLine());
                //Phase 2 - assign ticket price based on age 
                if (Age <= 18)
                    TicketPrice = 4.00;
                else if (Age <= 13)
                    TicketPrice = 3.25;
                else if (Age <= 3)
                    TicketPrice = 2.50;
                else
                    TicketPrice = 0.00;
                // Phase 3 - Movie and age check
                switch (FilmChoice)
                {
                    case 1:
                        Console.WriteLine("You may watch this film.");
                        FilmChoiceWrite = ("Kids movie");
                        AgeID = 1;
                        break;
                    case 2:
                        if (Age < 8)
                        {
                            Console.WriteLine("You may watch this film, though you may find parts unsettling.");
                            FilmChoiceWrite = ("Family Movie");
                            AgeID = 1;
                        }
                        else
                        {
                            Console.WriteLine("You may watch this film.");
                            FilmChoiceWrite = ("Family Movie");
                            AgeID = 1;
                        }
    
                        break;
                    case 3:
                        if (Age < 12)
                        {
                            Console.WriteLine("You may only watch this film if accompanied by an adult.");
                            FilmChoiceWrite = ("Action movie");
                            AgeID = 1;
                        }
                         else
                        {
                            Console.WriteLine("You may watch this film.");
                            FilmChoiceWrite = ("Action movie");
                            AgeID = 1;
                        }
                        break;
                    case 4:
                        if (Age < 15)
                        {
                            Console.WriteLine("You are {0} years too young to watch this film.\n\n", 15 - Age);
                        }

                        else
                        {
                            Console.WriteLine("You may watch this film.");
                            FilmChoiceWrite = ("Documentary");
                            AgeID = 1;
                        }

                        break;
                    case 5:
                        if (Age < 18)
                        {
                            Console.WriteLine("You are {0} years too young to watch this film.\n\n", 18 - Age);
                        }
                        else
                        {
                            Console.WriteLine("You may watch this film.");
                            FilmChoiceWrite = ("Thriller movie");
                            AgeID = 1;
                        }
                        break;
                        
                        
                    default:
                        Console.WriteLine("No such film. Please try again.");
                        break;
                }




            } while (AgeID < 1);

            //Phase 4 - Date Check

            Console.WriteLine("Please enter the date you would like to see the movie. it must be within 7 days of the current date (but can't be today).");
            DateInput = Console.ReadLine();
            ChosenDate = DateTime.Parse(DateInput);


            if (ChosenDate > DeadlineDate)
            {
                Console.WriteLine("Invalid date, please try again");
            }
            else if (ChosenDate == today)
            {
                Console.WriteLine("You need to pick a date in the future");
            }
            else
            {
                Console.WriteLine("date accepted");
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("TICKET INFO");
            Console.WriteLine("you are watching {0}", FilmChoiceWrite);
            Console.WriteLine("Ticket is Valid on {0}", ChosenDate);
            Console.WriteLine("Price of Ticket £{0}", TicketPrice);
            Console.WriteLine("\n\n Ticket number: {0}", TicketNumber);
            Console.WriteLine("----------------------\n\n\n");
        }
    }
}