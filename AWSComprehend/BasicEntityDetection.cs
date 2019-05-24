using System.Collections.Generic;
using System.Linq;
using Amazon.Comprehend;
using Amazon.Comprehend.Model;

namespace AWSComprehend
{
    public class BasicEntityDetection
    {
        private readonly AmazonComprehendClient client;
        public BasicEntityDetection()
        {
            client = new AmazonComprehendClient(Amazon.RegionEndpoint.USWest2);
        }
        public List<Entity> Get(string inputText)
        {
            DetectEntitiesRequest detectEntitiesRequest =  new DetectEntitiesRequest
            {
                Text = inputText,
                LanguageCode = "en"
            };
            var response = client.DetectEntitiesAsync(detectEntitiesRequest).Result;

            return response.Entities.ToList();
        }
        
    }
}
