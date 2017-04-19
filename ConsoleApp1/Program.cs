using Ovh.Api;
using System;
using System.Collections.Generic;
using System.IO;

namespace api_tester
{
    class Program
    {
        static void Main(string[] args)
        {
            if(!File.Exists("./ovh.conf"))
            {
                throw new IOException();
            }
            Environment.SetEnvironmentVariable("OVH_ENDPOINT", "ovh-eu");
            Environment.SetEnvironmentVariable("OVH_APPLICATION_KEY", "J1MXVC7BkTJzoTi4");
            Environment.SetEnvironmentVariable("OVH_APPLICATION_SECRET", "q3DUZlTvv0Eag01dML1LLo7KapYAj7rQ");
            Environment.SetEnvironmentVariable("OVH_CONSUMER_KEY", "oYkmfjAambiOUqCwMx8me5En4lgBBtfq");
            Client client = new Client();
            CredentialRequest requestPayload = new CredentialRequest(
                new List<AccessRight>(){
    new AccessRight("GET", "/*"),
    new AccessRight("PUT", "/*"),
    new AccessRight("POST", "/*"),
    new AccessRight("DELETE", "/*"),
                }, "http://www.google.com"
            );

            CredentialRequestResult credentialRequestResult =
                client.RequestConsumerKey(requestPayload);
            Console.Write(
                String.Format("Please visit {0} to authenticate ",
                    credentialRequestResult.ValidationUrl));
            Console.WriteLine("and press enter to continue");
            Console.ReadLine();

            PartialMe me = client.Get<PartialMe>("/me");

            Console.WriteLine(
                String.Format("Welcome, {0}", me.firstname));
            Console.WriteLine(
                String.Format("Btw, your 'consumerKey' is {0}",
                    credentialRequestResult.ConsumerKey));
            Console.ReadLine();
        }
    }

    class PartialMe
    {
        public string firstname { get; set; }
        public string name { get; set; }
    }
}