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

            Ticket problem1 = new Ticket("John", "john@whitecliffe.co.nz", "Password change", "JOHNS");
            Ticket problem2 = new Ticket("Inna", "inna@whitecliffe.co.nz", "My monitor stopped working", "INNAM");
            Ticket problem3 = new Ticket("Maria", "maria@whitecliffe.co.nz", "Request for a video camera to conduct webinars", "MARIAH");

            problem1.GenerateTicket();

        }
    }
}
