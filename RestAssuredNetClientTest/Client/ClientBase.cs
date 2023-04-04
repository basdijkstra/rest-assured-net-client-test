using RestAssured.Request.Builders;
using RestAssured.Request.Logging;

namespace RestAssuredNetClientTest.Client
{
    public abstract class ClientBase
    {
        private Uri baseUri;

        protected ClientBase(Uri baseUri)
        {
            this.baseUri = baseUri; 
        }

        public RequestSpecification RequestSpec()
        {
            return new RequestSpecBuilder()
                .WithScheme(this.baseUri.Scheme)
                .WithHostName(this.baseUri.Host)
                .WithBasePath(this.baseUri.AbsolutePath)
                .WithPort(this.baseUri.Port)
                .WithRequestLogLevel(RequestLogLevel.All)
                .Build();
        }
    }
}
