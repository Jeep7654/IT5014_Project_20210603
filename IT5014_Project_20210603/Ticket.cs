using System;
using System.Collections.Generic;
using System.Text;

namespace IT5014_Project_20210603
{
    class Ticket
    {
        static int tk_Num = 2000;   // Automatically set to 2000
        string tk_Creator;          // Name of the creator of ticket
        string tk_Email;            // Contact email of the creator of ticket
        string tk_Desc;             // Description of issue
        string tk_StaffID;          // StaffID of the creator of ticket
        string tk_Response;         // Automatically set "Not Yet Opened" when ticket is first created
        string tk_Status;           // Automatically set to Open once ticket is created

        public Ticket(string desc, string staffID)
        {
            tk_Num++;
            this.tk_Creator = "Not Specified";
            this.tk_Email = "Not Specified";
            this.tk_Desc = desc;
            this.tk_StaffID = staffID;
            this.tk_Response = "Not Yet Provided";
            this.tk_Status = "Open";
        }

        public Ticket(string name, string email, string desc, string staffID)
        {
            tk_Num++;
            this.tk_Creator = name;
            this.tk_Email = email;
            this.tk_Desc = desc;
            this.tk_StaffID = staffID;
            this.tk_Response = "Not Yet Provided";
            this.tk_Status = "Open";

        }

        public string GenerateTicket()
        {
            return "Ticket Creator: " + tk_Creator;
        }

    }
}
