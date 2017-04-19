using System;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net;
using OVHApi;
using System.Threading;

namespace IP_Refresher
{
    internal static class Program
    {
        //Environment.SetEnvironmentVariable("OVH_ENDPOINT", "ovh-eu");
        //Environment.SetEnvironmentVariable("OVH_APPLICATION_KEY", "J1MXVC7BkTJzoTi4");
        //Environment.SetEnvironmentVariable("OVH_APPLICATION_SECRET", "q3DUZlTvv0Eag01dML1LLo7KapYAj7rQ");
        //Environment.SetEnvironmentVariable("OVH_CONSUMER_KEY", "s1SL3ItS4noJTfWKo8gmRpb9wwVAi6VR");
        private static OvhApiClient Api { get; set; }

        private static void Main(string[] args)
        {
            while(true)
            {
                //Check 8.8.8.8 or 8.8.4.4
                var isInternetUp = CheckIpUp(@"8.8.8.8");
                if (!isInternetUp)
                {
                    isInternetUp = CheckIpUp(@"8.8.4.4");
                }
                if (isInternetUp)
                {
                    InitApi();
                    //Get current ip address
                    var currentIp = CallRemoteApi("https://api.ipify.org");
                    //Get OVH ip address
                    var ovhIp = CallOvhAsync().Result;
                    //if different, update.
                    if (currentIp != ovhIp)
                    {
                        PostOvhAsync(currentIp);
                    }
                    Console.Read();
                }
                Thread.Sleep(300000);
            }
        }

        private static bool CheckIpUp(string ipAddress)
        {
            var isPingable = false;
            var pinger = new Ping();
            try
            {
                var reply = pinger.Send(ipAddress);
                if (reply != null) isPingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                //Ignore exceptio and return false
            }
            return isPingable;
        }

        private static string CallRemoteApi(string url)
        {
            var client = new WebClient();
            return client.DownloadString(new Uri(url));
        }

        private static async Task<string> CallOvhAsync()
        {
            var r = await Api.GetDomainZoneRecord(@"legagladio.it", 1445634879);
            return r.Target;
        }

        private static async void PostOvhAsync(string currentIp)
        {
            var r = await Api.GetDomainZoneRecord(@"legagladio.it", 1445634879);
            r.Target = currentIp;
            await Api.UpdateDomainZoneRecord(r, @"legagladio.it", 1445634879);
        }

        private static void InitApi()
        {
            if (Api == null) Api = new OvhApiClient(@"J1MXVC7BkTJzoTi4", @"q3DUZlTvv0Eag01dML1LLo7KapYAj7rQ", OvhInfra.Europe, @"s1SL3ItS4noJTfWKo8gmRpb9wwVAi6VR");
        }
    }
}