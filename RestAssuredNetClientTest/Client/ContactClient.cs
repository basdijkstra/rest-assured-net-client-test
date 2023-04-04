using RestAssured.Response;
using RestAssuredNetClientTest.Models;
using static RestAssured.Dsl;

namespace RestAssuredNetClientTest.Client
{
    public class ContactClient : ClientBase
    {
        private static readonly Uri BaseUri = new Uri("http://localhost:9876/api/v2");

        public ContactClient() : base(BaseUri)
        {
        }

        public VerifiableResponse CreateContact(Contact contact)
        {
            return Given()
                .Spec(base.RequestSpec())
                .ContentType("application/json")
                .Body(contact)
                .When()
                .Post("/contact");
        }

        public VerifiableResponse GetContact(string contactId)
        {
            return Given()
                .Spec(base.RequestSpec())
                .When()
                .Get($"/contact/{contactId}");
        }
    }
}
