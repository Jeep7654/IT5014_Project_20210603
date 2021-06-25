using System;
using System.Collections.Generic;
using System.Text;

namespace IT5014_Project_20210603
{
    class TicketStats
    {
        private int total_Tk;   // Total number of Tickets
        private int closed_Tk;  // Total number of Tickets Resolved
        private int open_Tk;    // Total number of Tickets To Solve

        /// <summary>
        /// Constructor for Ticket Statistics
        /// </summary>
        public TicketStats()
        {
            total_Tk = 0;
            closed_Tk = 0;
            open_Tk = 0;
        }

        // Setters and Getters

        public void Set_total_Tk(int total)
        {
            total_Tk = total;
        }

        public int Get_total_Tk()
        {
            return total_Tk;
        }

        public void Set_closed_Tk(List<Ticket> tk_List)
        {
            int count = 0;
            foreach (Ticket tk in tk_List)
            {
                if (tk.Get_tk_Status() == "Closed")
                    count++;
            }
            closed_Tk = count;
        }

        public int Get_closed_Tk()
        {
            return closed_Tk;
        }

        public void Set_open_Tk(List<Ticket> tk_List)
        {
            int count = 0;
            foreach (Ticket tk in tk_List)
            {
                if ((tk.Get_tk_Status() == "Open") || (tk.Get_tk_Status() == "Reopened"))
                    count++;
            }
            open_Tk = count;
        }

        public int Get_open_Tk()
        {
            return open_Tk;
        }

        /// <summary>
        /// Prints the Ticket Statistics on the Console.
        /// </summary>
        public void PrintTicketStats()
        {
            Console.WriteLine(
                "\nTickets Created: " + total_Tk +
                "\nTickets Resolved: " + closed_Tk +
                "\nTickets To Solve: " + open_Tk);
        }


    }
}
