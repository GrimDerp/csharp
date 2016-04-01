using System.Net;

namespace request
{
    public class Config {

        public static string license = "";
        public static string baseEndpoint = "apis.cert.vantiv.com";
        public static int version = 1;
        public static WebProxy proxy = null;
        public static string proxyAuth = "";

        // debugging assistance
        public static bool printRequest = false;
        public static bool printResponse = false;
        public static bool doNotSend = false;
    }
}
