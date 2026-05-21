using System;

namespace CustomerProductClasses
{
    public class Customer
    {
        private int id;
        private string email;
        private string firstName;
        private string lastName;
        private string phone;

        public Customer()
        {
            id = 0;
            email = "";
            firstName = "";
            lastName = "";
            phone = "";
        }

        public Customer(int id, string email, string firstName, string lastName, string phone)
        {
            Id = id;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public override string ToString()
        {
            return $"{id}, {email}, {firstName}, {lastName}, {phone}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Customer other)
            {
                return this.id == other.id;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}