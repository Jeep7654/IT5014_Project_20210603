using System;
using System.Collections.Generic;
using System.Text;

namespace IT5014_Project_20210603
{
    class PasswordGenerator
    {
        /// <summary>
        /// A static method that generates a new password using:
        /// 1. First 2 chars of the staff ID
        /// 2. Hex number of the TICKET NUMBER
        /// 3. The hex number of the first 3 chars of the current timeStamp i.e DateTime.Now()
        /// </summary>
        /// <param name="tk_Num">A given TICKET NUMBER.</param>
        /// <param name="staffID">A given Staff ID.</param>
        /// <returns>Returns a string combination of all three excluding the dashes(-).</returns>
        public static string GeneratePassword(int tk_Num, string staffID)
        {
            string hex_TkNum = tk_Num.ToString("X");
            // Turns the ticket number into a hex #
            string timeStamp = DateTime.Now.ToString("dd/MM/yyy");
            // Gets todays date into a string
            byte[] bitStamp = Encoding.Default.GetBytes(timeStamp.Substring(0, 3)); 
            // Turns the first 3 chars of timestamp into bytes
            string hexStamp = BitConverter.ToString(bitStamp);
            // Turns the bitStamp into hexadecimal numbers with "-"
            string generatedPassword = staffID.Substring(0, 2) + hex_TkNum + hexStamp;
            // Adds all of the components together
            return generatedPassword.Replace("-", string.Empty);
            // Returns the generated password without the dashes
        }
    }
}
