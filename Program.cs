
using System;

namespace SeleniumTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Selenium Tests...");
            var test = new SeleniumTest();
            test.RunTest();

            if (test.HasFailed)
            {
                var bugCreator = new AzureDevOpsBugCreator();
                bugCreator.CreateBug("Test failed during execution");
            }
            else
            {
                Console.WriteLine("All tests passed.");
            }
        }
    }
}
