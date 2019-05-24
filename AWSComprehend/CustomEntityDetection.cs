using Amazon.Comprehend;

namespace AWSComprehend
{
    public class CustomEntityDetection
    {
        private readonly AmazonComprehendClient client;
        
        public CustomEntityDetection()
        {
            client = new AmazonComprehendClient(Amazon.RegionEndpoint.USWest2);
        }
       
        
        
        
    }
}
