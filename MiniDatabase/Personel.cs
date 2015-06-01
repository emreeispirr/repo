using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDatabase
{
    public class Personel
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public DateTime AccountEndDate { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return "Username: " + Username + "\n"
                    + "Full Name: " + FirstName + " " + LastName + "\n"
                    + "Department: " + Department + "\n"
                    + "Account End Date: " + AccountEndDate.ToString("yyyy-MM-dd") + "\n";
        }
    }
}
