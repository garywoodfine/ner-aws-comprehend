using System;
using System.Linq;
using Amazon;
using Amazon.Comprehend;
using Amazon.Comprehend.Model;
using Amazon.S3;
using Amazon.S3.Model;


namespace AWSComprehend
{
    class Program
    {
        static void Main(string[] args)
        {
           var text = "Hi, my name is Gary Woodfine and I'm a UK based full stack developer. I am highly skilled in C#, .net core, ASP.net, PHP, Python, Laravel among a number of technologies.  I have my own company, threenine.co.uk which I work for providing software solutions to complex business problems. I run a popular tutorial based website, https://garywoodfine.com . I like to eat coconuts on a beach and drink pina coladas in the rain ";

            var detect = new BasicEntityDetection();
            var entites = detect.Get(text);
            
           
            foreach (var e in entites) 
                
                Console.WriteLine($"Text: {e.Text}, Type: {e.Type}, Score: {e.Score}, BeginOffset: {e.BeginOffset}, EndOffset: {e.EndOffset}");
            Console.WriteLine("Done");
        }
    }
}
