using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    internal class PersonModel
    {
        /// <summary>
        /// First name of the contestant/participator
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the contestant/participator
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email of the participator
        /// </summary>
        public string EmailAddress { get; set; }
        
        /// <summary>
        /// PhoneNumber of the participator to send texts to
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
