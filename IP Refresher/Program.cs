using System;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net;
using OVHApi;
using System.Threading;

namespace IP_Refresher
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                //Check 8.8.8.8 or 8.8.4.4
                var isInternetUp = checkIPUp(@"8.8.8.8");
                if (!isInternetUp)
                {
                    isInternetUp = checkIPUp(@"8.8.4.4");
                }
                if (isInternetUp)
                {
                    //Get current ip address
                    var currentIP = callRemoteAPI("https://api.ipify.org");
                    //Get OVH ip address
                    var ovhIP = callOVHAsync().Result;
                    //if different, update.
                    if (currentIP != ovhIP)
                    {
                        postOVHAsync(currentIP);
                    }
                    Console.Read();
                }
                Thread.Sleep(300000);
            }
        }

        private static Boolean checkIPUp(String ipAddress)
        {
            bool isPingable = false;
            Ping pinger = new Ping();
            try
            {
                PingReply reply = pinger.Send(ipAddress);
                isPingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {

            }
            return isPingable;
        }

        private static String callRemoteAPI(String url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(new Uri(url));
        }

        private static async Task<string> callOVHAsync()
        {

            //Environment.SetEnvironmentVariable("OVH_ENDPOINT", "ovh-eu");
            //Environment.SetEnvironmentVariable("OVH_APPLICATION_KEY", "J1MXVC7BkTJzoTi4");
            //Environment.SetEnvironmentVariable("OVH_APPLICATION_SECRET", "q3DUZlTvv0Eag01dML1LLo7KapYAj7rQ");
            //Environment.SetEnvironmentVariable("OVH_CONSUMER_KEY", "s1SL3ItS4noJTfWKo8gmRpb9wwVAi6VR");
            OvhApiClient api = new OvhApiClient("J1MXVC7BkTJzoTi4", "q3DUZlTvv0Eag01dML1LLo7KapYAj7rQ", OvhInfra.Europe, "s1SL3ItS4noJTfWKo8gmRpb9wwVAi6VR");
            OvhApi.Models.Domain.Zone.Record r = await api.GetDomainZoneRecord("legagladio.it", 1445634879);
            return r.Target;
        }


        private static async void postOVHAsync(string currentIP)
        {
            var api = new OvhApiClient("J1MXVC7BkTJzoTi4", "q3DUZlTvv0Eag01dML1LLo7KapYAj7rQ", OvhInfra.Europe, "s1SL3ItS4noJTfWKo8gmRpb9wwVAi6VR");
            var r =  await api.GetDomainZoneRecord("legagladio.it", 1445634879);
            r.Target = currentIP;
            api.UpdateDomainZoneRecord(r, "legagladio.it", 1445634879);
        }
    }
}