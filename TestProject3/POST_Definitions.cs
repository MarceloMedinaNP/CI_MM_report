using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace TestProject3
{
    [Binding]
    public class POST_Definitions
    {
        RestClient client = new RestClient("http://demostore.gatling.io/");
        RestRequest request = new RestRequest("/api/product/", Method.Post);
        RestResponse response;

        [Given(@"I need verified POST posts")]
        public void GivenINeedVerifiedPOSTPosts()
        {
            request.AddHeader("Authorization", "Bearer " + "eyJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJhZG1pbiIsImlhdCI6MTY4NjA2MzI2MywiZXhwIjoxNjg2MDY2ODYzfQ.5Tqetrh7V8bghdmAPZuzqeHShmelAIk5LOojU7J0Cmo");
            request.AddJsonBody(new { id = 15, name = "PPPPPPPP Glasses", description = "Purple Glasses", image = "purple -glasses.jpg", price = "19.99", categoryId = 7 });
        }

        [When(@"I send a get POST request")]
        public void WhenISendAGetPOSTRequest()
        {
            response = client.ExecutePost(request);
        }

        [Then(@"I expected a valid get POST code response")]
        public void ThenIExpectedAValidGetPOSTCodeResponse()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
