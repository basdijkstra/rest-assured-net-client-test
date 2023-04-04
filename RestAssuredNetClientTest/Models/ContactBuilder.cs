namespace RestAssuredNetClientTest.Models
{
    public class ContactBuilder
    {
        private readonly Contact client;

        private readonly string firstName = string.Empty;
        private readonly string lastName = string.Empty;
        private readonly string email = string.Empty;

        public ContactBuilder()
        {
            this.client = new Contact(this.firstName, this.lastName, this.email);
        }

        public ContactBuilder WithFirstName(string firstName)
        {
            this.client.FirstName = firstName;
            return this;
        }

        public ContactBuilder WithLastName(string lastName)
        {
            this.client.LastName = lastName;
            return this;
        }

        public ContactBuilder WithEmail(string email)
        {
            this.client.Email = email;
            return this;
        }

        public Contact Build()
        {
            return this.client;
        }
    }
}
