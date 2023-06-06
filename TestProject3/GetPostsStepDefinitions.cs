using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace TestProject3
{
    [Binding]
    public class GetPostsStepDefinitions
    {
        RestClient client = new RestClient("http://demostore.gatling.io/");
        RestRequest request = new RestRequest("/api/product/{id}", Method.Get);
        RestResponse response;

        [Given(@"I have an id with value (.*)")]
        public void GivenIHaveAnIdWithValue(int p0)
        {
            request.AddUrlSegment("id", p0);
        }

        [When(@"I send a get request")]
        public void WhenISendIGetRequest()
        {
            response = client.ExecuteGet(request);
        }

        [Then(@"I expected a valid code response")]
        public void ThenIExpectedAValidCodeResponse()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
