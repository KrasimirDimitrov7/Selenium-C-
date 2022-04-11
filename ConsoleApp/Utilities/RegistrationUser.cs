using System;

namespace ConsoleApp
{
    public class RegistrationUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string Days { get; set; }

        public string Month { get; set; }

        public string Year { get; set; }

        public string FirstName2 { get; set; }

        public string LastName2 { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostCode { get; set; }

        public string Company { get; set; }

        public string Phone { get; set; }

        public string Aliase { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public static implicit operator RegistrationUser(UserFactory v)
        {
            throw new NotImplementedException();
        }

    }
}