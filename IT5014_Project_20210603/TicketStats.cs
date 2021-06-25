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

        public TicketStats()
        {
            total_Tk = 0;
            closed_Tk = 0;
            open_Tk = 0;
        }

        public void Set_total_Tk(int total)
        {
            total_Tk = total;
        }

        public int Get_total_Tk()
        {
            return total_Tk;
        }

        public void Set_closed_Tk(int total)
        {
            closed_Tk += total;
        }

        public int Get_closed_Tk()
        {
            return closed_Tk;
        }

        public void Set_open_Tk(int total)
        {
            open_Tk += total;
        }

        public int Get_open_Tk()
        {
            return open_Tk;
        }

        public string PrintTicketStats()
        {
            return 
                "\nTickets Created: " + total_Tk +
                "\nTickets Resolved: " + closed_Tk +
                "\nTickets To Solve: " + open_Tk;
        }


    }
}
