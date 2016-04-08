
using System;
using Newtonsoft.Json.Linq;

namespace request
{
    public class Utilities
    {

        /**
         * Converts a JSON formatted string to a JObject.
         * @param input The string to be converted
         * @return the JObject
         */
        public static JObject toJson(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;
            else
                return JObject.Parse(input);
        }

        /**
         * Extracts the transactionID from a response object
         * @param response must be the response of a transaction
         * @return the transactionID as a String or null if not found
         */
        public static string getTransactionID(string response)
        {
            JObject jObject = toJson(response);
            if (jObject == null)
                return null;
            foreach (JToken desc in jObject.Descendants())
            {
                var temp = desc as JProperty;
                if (temp?.Name == "TransactionID")
                {
                    return temp.Value?.ToString();
                }
            }
            return null;
        }

    }
}