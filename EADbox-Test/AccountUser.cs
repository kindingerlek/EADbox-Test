using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADbox_Test
{
    public class AccountUser
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Locale { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return string.Format("facebook ID: {0}\n FacebookUserName:{1} \n Facebook Account Name: {2}", ID, UserName, FirstName + " " + LastName);
        }
    }
}
