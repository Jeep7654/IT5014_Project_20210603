using System;
using System.Collections.Generic;
using System.Text;

namespace IT5014_Project_20210603
{
    class Ticket
    {
        private static int TICKET_NUMBER = 2000;    // Automatically set to 2000
        private int tk_Num;                         // The assigned number to a ticket that is created
        private string tk_Creator;                  // Name of the creator of ticket
        private string tk_Email;                    // Contact email of the creator of ticket
        private string tk_Desc;                     // Description of issue
        private string tk_StaffID;                  // StaffID of the creator of ticket
        private string tk_Response;                 // Automatically set "Not Yet Opened" when ticket is first created
        private string tk_Status;                   // Automatically set to Open once ticket is created

        /// <summary>
        /// Test Ticket Constructor
        /// </summary>
        public Ticket()
        {
            tk_Num = ++TICKET_NUMBER;
            tk_Creator = "Example Name";
            tk_Email = "example@email.com";
            tk_Desc = "Description of issue.";
            tk_StaffID = "EXAMPLEN";
            tk_Response = "Not Yet Provided.";
            tk_Status = "Open";
        }

        /// <summary>
        /// Ticket Constructor if only description of issue and staffID given
        /// </summary>
        /// <param name="desc">A string that contains the description of issue.</param>
        /// <param name="staffID">A string that constains the ID of staff member that created the ticket.</param>
        public Ticket(string desc, string staffID)
        {
            this.tk_Num = ++TICKET_NUMBER;
            this.tk_Creator = "Not Specified";
            this.tk_Email = "Not Specified";
            this.tk_Desc = desc;
            this.tk_StaffID = staffID;
            this.tk_Response = "Not Yet Provided";
            this.tk_Status = "Open";
        }

        /// <summary>
        /// Ticket Constructor with all given information by staff member
        /// </summary>
        /// <param name="name">A string that contains name of ticket creator.</param>
        /// <param name="email">A string that contains contact email of ticket creator.</param>
        /// <param name="desc">A string that contains the description of issue.</param>
        /// <param name="staffID">A string that constains the ID of staff member that created the ticket.</param>
        public Ticket(string name, string email, string desc, string staffID)
        {
            this.tk_Num = ++TICKET_NUMBER;
            this.tk_Creator = name;
            this.tk_Email = email;
            this.tk_Desc = desc;
            this.tk_StaffID = staffID;
            this.tk_Response = "Not Yet Provided";
            this.tk_Status = "Open";
        }

        // Setters and Getters

        public void Set_tk_Num(int num)
        {
            this.tk_Num = num;
        }

        public int Get_tk_Num()
        {
            return this.tk_Num;
        }

        public void Set_tk_Creator(string name)
        {
            this.tk_Creator = name;
        }

        public string Get_tk_Creator()
        {
            return this.tk_Creator;
        }

        public void Set_tk_Email(string email)
        {
            this.tk_Creator = email;
        }

        public string Get_tk_Email()
        {
            return this.tk_Email;
        }

        public void Set_tk_Desc(string desc)
        {
            this.tk_Desc = desc;
        }

        public string Get_tk_Desc()
        {
            return this.tk_Desc;
        }

        public void Set_tk_StaffID(string id)
        {
            this.tk_StaffID = id;
        }

        public string Get_tk_StaffID()
        {
            return this.tk_StaffID;
        }

        public void Set_tk_Response(string response)
        {
            this.tk_Response = response;
        }

        public string Get_tk_Response()
        {
            return this.tk_Response;
        }

        public void Set_tk_Status(string status)
        {
            this.tk_Status = status;
        }

        public string Get_tk_Status()
        {
            return this.tk_Status;
        }
        /// <summary>
        /// This is only called when wanting to "Reopen" a "Closed" Ticket
        /// </summary>
        /// <param name="list">Is a List of Ticket Objects to use when searching the list.</param>
        public static void ReopenTicket(List<Ticket> list)
        {
            Console.WriteLine("\nWhich ticket would you like to reopen?\n" +
                    "Please input Ticket Number: ");
            string chosenTicket = Console.ReadLine(); // Gets users input
            int chosenNumber;       // Establising local variable int for later use
            bool isParsable = Int32.TryParse(chosenTicket, out chosenNumber);
            // isParable is a boolean which uses checks if chosenTicket is an integer
            // if chosenTicket is an integer, it outputs the int into chosenNumber
            if (isParsable)
            // If isParsable is true
            {
                foreach (Ticket tk in list) // Goes through each ticket in the list
                {
                    if (tk.Get_tk_Num().ToString() == chosenTicket)
                    // If chosenNumber == the ticketNumber we are looking 
                    {
                        if ((tk.Get_tk_Status() == "Closed"))
                        // Checks if the the chosenTicket is "Closed" 
                        {
                            tk.Set_tk_Status("Reopened"); // Sets the TicketStatus to Reopened
                            Console.WriteLine("\nTicket Number: {0} has been Reopened.", tk.Get_tk_Num());
                            Console.WriteLine("Ticket Status has been set to \"Reopened\".", tk.Get_tk_Status());
                        }
                        else 
                            // Else gives syntax that the chosenTicket Status either "Open" or "Reopened" 
                            Console.WriteLine("\nThat Ticket Number is \"Open\" or \"Reopened\".\n" +
                                "Input a Closed Ticket please.");
                    }
                }
            }
            else // Else the given user input is not an integer or a TicketNumber
                Console.WriteLine("\nThat is not a Ticket Number. Please try again.");
        }

        /// <summary>
        /// This is called when wanting to resolve a "Closed" Ticket
        /// </summary>
        /// <param name="list">Is a List of Ticket Objects to use when searching the list.</param>
        public static void ResolveTicket(List<Ticket> list)
        {
            Console.WriteLine("\nWhich ticket would you like to resolve?\n" +
                                "Please input Ticket Number: ");
            string chosenTicket = Console.ReadLine(); // Gets users input
            int chosenNumber;       // Establising local variable int for later use
            bool isParsable = Int32.TryParse(chosenTicket, out chosenNumber);
                // isParable is a boolean which uses checks if chosenTicket is an integer
                // if chosenTicket is an integer, it outputs the int into chosenNumber
            if (isParsable)
                // If isParsable is true
            {
                foreach (Ticket tk in list) // Goes through each ticket in the list
                {
                    if (tk.Get_tk_Num() == chosenNumber) 
                        // If chosenNumber == the ticketNumber we are looking 
                    {
                        if ((tk.Get_tk_Status() == "Open") || tk.Get_tk_Status() == "Reopened")
                            // Checks if the the chosenTicket is ether "Open" or "Reopened" 
                        {
                            tk.Set_tk_Status("Closed"); // Sets the TicketStatus to Closed
                            Console.WriteLine("\nTicket Number: {0} has been Resolved.", tk.Get_tk_Num());
                            Console.WriteLine("Ticket Status has been set to \"Closed\".", tk.Get_tk_Status());
                            if (tk.Get_tk_Desc().Contains("Password change"))
                                // If the Ticket issue description is a password change 
                                // Calls for a new password using the currect tk (TICKET) we are on 
                                tk.NewPassword();
                            else
                                // Else calls give response function in the tk (TICKET)
                                GiveResponse(tk);
                        }
                        else // Else gives syntax that the chosenTicket Status is "Closed"
                            Console.WriteLine("\nThat Ticket Number is \"Closed\".\n" +
                                "Input either an Open or Reopened Ticket please.");
                    }
                }
            }
            else // Else the given user input is not an integer or a TicketNumber
                Console.WriteLine("\nThat is not a Ticket Number. Please try again.");
        }

        /// <summary>
        /// Gives an appropriate response to the given description of issue to chosen ticket that is to be resolved.
        /// </summary>
        /// <param name="chosenTicket">Is the chosen ticket to receive a response from IT Staff.</param>
        public static void GiveResponse(Ticket chosenTicket)
        {
            Console.WriteLine("\nWhat would you like to set the response as?");
            string response = Console.ReadLine(); // Gets users response as a string
            chosenTicket.Set_tk_Response(response); 
            // Changes the chosenTickets response to the one set by the user
        }

        /// <summary>
        /// Gets a new password from the PasswordGenerator class and assigns it as the response for Ticket.
        /// </summary>
        public void NewPassword()
        {
            string newPass = PasswordGenerator.GeneratePassword(this.tk_Num, this.tk_StaffID);
            // Calls PasswordGenerator Class static method to generate new password
            Set_tk_Response(newPass);
            // This sets the response automatically as the new password
        }

        /// <summary>
        /// Prints all the information of a Ticket.
        /// </summary>
        public void PrintTicketInfo()
        {
            Console.WriteLine( 
                "\nTicket Number: " + tk_Num +
                "\nTicket Creator: " + tk_Creator +
                "\nStaff ID: " + tk_StaffID +
                "\nEmail Address: " + tk_Email + 
                "\nDescription: " + tk_Desc + 
                "\nResponse: " + tk_Response + 
                "\nTicket Status: " + tk_Status);
        }

    }
}
