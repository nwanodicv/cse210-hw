namespace OnlineOrdering
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(int customerId, string firstName, string lastName, string email, string phoneNumber)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"Customer ID: {CustomerId}, Name: {FirstName} {LastName}, Email: {Email}, Phone: {PhoneNumber}";
        }
    }
}