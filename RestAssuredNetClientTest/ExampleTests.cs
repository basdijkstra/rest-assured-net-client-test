using NUnit.Framework;
using RestAssuredNetClientTest.Client;
using RestAssuredNetClientTest.Models;

namespace RestAssuredNetClientTest
{
    public class ExampleTests
    {
        private readonly ContactClient contactClient = new ContactClient();

        [Test]
        public void CanUseClientTestModel()
        {
            Contact contact = new ContactBuilder()
                .WithFirstName("John")
                .WithLastName("Doe")
                .WithEmail("john@doe.com")
                .Build();

            this.contactClient
                .CreateContact(contact)
                .Then()
                .StatusCode(201);
        }

        [Test]
        public void CanUseClientTestModelWithAnonymousObject()
        {
            var contact = new
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john@doe.com"
            };

            this.contactClient
                .CreateContact(contact)
                .Then()
                .StatusCode(201);
        }
    }
}