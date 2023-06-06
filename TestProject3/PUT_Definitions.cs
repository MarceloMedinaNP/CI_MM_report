using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace TestProject3
{
    [Binding]
    public class PUT_Definitions
    {
        RestClient client = new RestClient("http://demostore.gatling.io/");
        RestRequest request = new RestRequest("/api/product/{id}", Method.Put);
        RestResponse response;

        [Given(@"I need verified PUT posts")]
        public void GivenINeedVerifiedPUTPosts()
        {
            request.AddUrlSegment("id", "20");
            request.AddHeader("Authorization", "Bearer " + "eyJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJhZG1pbiIsImlhdCI6MTY4NjA1NTIwMCwiZXhwIjoxNjg2MDU4ODAwfQ.5obR8herso8a4D4Q4fTiOdgmrkql2a_sh7Et0dnZvZM");
            request.AddJsonBody(new { name = "20PPPPPPPP Glasses", description = "20Purple Glasses", image = "purple -glasses.jpg", price = "19.99", categoryId = 7 });
        }

        [When(@"I send a get PUT request")]
        public void WhenISendAGetPUTRequest()
        {
            response = client.ExecutePut(request);
        }

        [Then(@"I expected a valid get PUT code response")]
        public void ThenIExpectedAValidGetPUTCodeResponse()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
