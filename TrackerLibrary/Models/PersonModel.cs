using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {

        /// <summary>
        /// Unique identifier for the prize
        /// </summary>
        public int Id { get; set; }

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


        public string FullName
        {
            get
            {
                return $"{ FirstName }, { LastName }";
            }
        }


#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public PersonModel()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }

        public PersonModel(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }
    }



}
