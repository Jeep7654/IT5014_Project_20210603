using System;
using System.Collections.Generic;
using System.Text;

namespace IT5014_Project_20210603
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WOW");

            List<Ticket> ticketList = new List<Ticket>();

            Ticket problem1 = new Ticket("John", "john@whitecliffe.co.nz", "Password change", "JOHNS");
            Ticket problem2 = new Ticket("Inna", "inna@whitecliffe.co.nz", "My monitor stopped working", "INNAM");
            Ticket problem3 = new Ticket("Maria", "maria@whitecliffe.co.nz", "Request for a video camera to conduct webinars", "MARIAH");

            Console.WriteLine(problem1.GenerateTicket());

            ticketList.Add(problem1);
            ticketList.Add(problem2);
            ticketList.Add(problem3);

            foreach(Ticket i in ticketList)
            {
                Console.WriteLine(i.GenerateTicket());
            }

            Console.ReadLine();


        }
    }
}
