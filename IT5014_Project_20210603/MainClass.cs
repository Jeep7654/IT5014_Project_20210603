using System;
using System.Collections.Generic;
using System.Text;

namespace IT5014_Project_20210603
{
    class MainClass
    {
        static void Main(string[] args)
        {
            List<Ticket> ticketList = new List<Ticket>();

            Ticket Ticket1 = new Ticket("John", "john@whitecliffe.co.nz", "Password change", "JOHNS");
            Ticket Ticket2 = new Ticket("Inna", "inna@whitecliffe.co.nz", "My monitor stopped working", "INNAM");
            Ticket Ticket3 = new Ticket("Maria", "maria@whitecliffe.co.nz", "Request for a video camera to conduct webinars", "MARIAH");

            ticketList.Add(Ticket1);
            ticketList.Add(Ticket2);
            ticketList.Add(Ticket3);
            /*
            Ticket Tick1 = new Ticket("Password change", "JAMESN");
            Ticket Tick2 = new Ticket("Need new mouse and keyboard", "RICHARDD");

            ticketList.Add(Tick1);
            ticketList.Add(Tick2);

            Ticket test1 = new Ticket();
            test1.Set_tk_Status("Closed");
            test1.Set_tk_Creator("Emma Horton");
            test1.Set_tk_StaffID("EMMAH");
            Ticket test2 = new Ticket();
            test2.Set_tk_Status("Reopened");
            test2.Set_tk_Creator("WiLliam Welsh");
            test2.Set_tk_StaffID("WILLIAMW");

            ticketList.Add(test1);
            ticketList.Add(test2);
            */

            foreach (Ticket i in ticketList)
            {
                i.PrintTicketInfo();
            }

            bool stop = false; // boolean set to false
            do
                // Will do this line of code first
            {
                Console.WriteLine("\nDo you want to resolve tickets? Y or N");
                string userInput = Console.ReadLine(); // Grabs user input whether it be Y or N

                if (userInput.ToUpper() == "Y")
                    // If user input is Y
                {
                    Ticket.ResolveTicket(ticketList); 
                        // Calls a static method to resolve the tickets that includes the list of tickets
                }
                else if (userInput.ToUpper() == "N")
                    // If user input is N
                    stop = true; // Stops the while loop
                else
                    // If not Y or N will give a syntax and loops back to the beginning 
                    Console.WriteLine("\nThat is not an option.\nTry again please.\n");
            }
            while (!stop); // Will keep do-ing the code above while stop is set to false



            /*

            TicketStats Stats = new TicketStats();
            Stats.Set_total_Tk(ticketList.Count);
            foreach (Ticket i in ticketList)
            {
                if ((i.Get_tk_Status() == "Open") || (i.Get_tk_Status() == "Reopened"))
                {
                    Stats.Set_open_Tk(1);
                }
                else if (i.Get_tk_Status() == "Closed")
                {
                    Stats.Set_closed_Tk(1);
                }
            }
            Console.WriteLine(Stats.PrintTicketStats());

            foreach (Ticket i in ticketList) 
                // Goes through each ticket in the TicketList
            {
                if (i.Get_tk_Desc().Contains("Password change")) 
                    // Checks description if it contains "Password change"
                {
                    Console.WriteLine("\n~ Ticket with No Password ~");
                    // Just a header to show there is no response under it
                    i.PrintTicketInfo(); // Prints ticket info
                    i.NewPassword();     // Generates new password for this specific ticket
                    Console.WriteLine("\n~ Ticket with New Password ~");
                    // Just a header to show there is a response under it
                    i.PrintTicketInfo(); // Prints new ticket info
                }
            }


            Console.ReadLine();
                       
            Console.WriteLine("Welcome IT Staff.\n" +
                "What would you like to do?\n" +
                "1. Print Ticket Statistics and All tickets.\n" +
                "2. Reopen Tickets.\n" +
                "3. Resolve Tickets.\n" +
                "Please choose a number to do an action.");

            string userInput = Console.ReadLine();

            if (userInput == "2")
            {
                foreach (Ticket i in ticketList)
                {
                    Console.WriteLine(i.PrintTicketInfo());
                }
            }
            else if (userInput == "1")
            {
                TicketStats TicketStatistics = new TicketStats();
                TicketStatistics.Set_total_Tk(ticketList.Count);
                foreach (Ticket i in ticketList)
                {
                    if ((i.Get_tk_Status() == "Open") || (i.Get_tk_Status() == "Reopened"))
                    {
                        TicketStatistics.Set_open_Tk(1);
                    }
                    else if (i.Get_tk_Status() == "Closed")
                    {
                        TicketStatistics.Set_closed_Tk(1);
                    }
                }
                Console.WriteLine(TicketStatistics.PrintTicketStats());
            }
            else
            {
                Console.WriteLine("\nNot yet implemented");
            }

            */

            Console.ReadLine();

        }
    }
}
