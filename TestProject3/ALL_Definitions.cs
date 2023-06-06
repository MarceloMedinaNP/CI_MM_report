using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace TestProject3
{
    [Binding]
    public class ALL_Definitions
    {
        RestClient client = new RestClient("http://demostore.gatling.io/");
        RestRequest request = new RestRequest("/api/product/", Method.Get);
        RestResponse response;

        [Given(@"I need verified ALL posts")]
        public void GivenINeedVerifiedALLPosts()
        {
            response = client.ExecuteGet(request);
        }

        [When(@"I send a get ALL request")]
        public void WhenISendAGetALLRequest()
        {
            response = client.ExecuteGet(request);
        }

        [Then(@"I expected a valid get ALL code response")]
        public void ThenIExpectedAValidGetALLCodeResponse()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
