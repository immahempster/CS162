using System;

namespace CustomerProductClasses
{
    public class Customer
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Customer other = (Customer)obj;
            return Id == other.Id &&
                   Email == other.Email &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   Phone == other.Phone;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^
                   Email.GetHashCode() ^
                   FirstName.GetHashCode() ^
                   LastName.GetHashCode() ^
                   Phone.GetHashCode();
        }
    }
}