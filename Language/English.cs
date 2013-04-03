using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Language
{
    public class English
    {
        private Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public English()
        {
            /* Caption */
            dictionary.Add("CaptionDelete", "Delete");
            dictionary.Add("CaptionUnderConstruction", "Under Construction");
            dictionary.Add("CaptionError", "Error");

            /* Message */
            dictionary.Add("MessageDelete", "Are you sure to delete?");
            dictionary.Add("MessageDeleteError", "Deleted fail ! Please check and try again");
            dictionary.Add("MessageError", "Have an error exception");
            dictionary.Add("MessageUnderConstruction", "Under construction !!!");
            dictionary.Add("MessageDeleteUnable", "Unable to delete");

            /* Application */
            dictionary.Add("Deposit", "Deposit");
            dictionary.Add("Withdraw", "Withdraw");
            dictionary.Add("Lend", "Lend");
            dictionary.Add("Borrow", "Borrow");
            dictionary.Add("Day", "Day");
            dictionary.Add("Month", "Month");
            dictionary.Add("Year", "Year");
            dictionary.Add("About", "About");
            dictionary.Add("Submit", "Submit");
            dictionary.Add("Reason", "Reason");
            dictionary.Add("Present", "Present");
            dictionary.Add("Date", "Date");
            dictionary.Add("File", "File");
            dictionary.Add("Exit", "Exit");
            dictionary.Add("Update", "Update");
            dictionary.Add("Amount", "Amount");
            dictionary.Add("ClosingAmount", "Closing Amount");
            dictionary.Add("OpeningAmount", "Opening Amount");
            dictionary.Add("Action", "Action");
            dictionary.Add("Language", "Language");
            dictionary.Add("Remove", "Remove");
            dictionary.Add("Report", "Report");
            dictionary.Add("Author", "Author");
            dictionary.Add("Email", "Email");
        }

        public string GetString(string p_Key)
        {
            if (dictionary.ContainsKey(p_Key))
            {
                return dictionary.Single(ob => ob.Key == p_Key).Value;
            }
            else
            {
                throw new NullReferenceException("Key " + p_Key + " isn't exists");
            }
        }
    }
}
