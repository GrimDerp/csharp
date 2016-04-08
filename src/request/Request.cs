using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Policy;
using System.Text;

namespace request
{
    public abstract class Request
    {
        [NonSerialized]
        private string url;

        [NonSerialized]
        private string method;

        [NonSerialized]
        protected Dictionary<string, string> queryParams = new Dictionary<string, string>();

        public Request(string category, string proxy, string endpoint, string method)
        {

            this.url = "https://" + Config.baseEndpoint + "/" + category + "/sp2/" + proxy + "/v" + Config.version + "/" + endpoint;
            this.method = method;
        }

        public string send()
        {
            if (Config.doNotSend)
            {
                return this.toJSON();
            }
            using (WebClient connection = new WebClient())
            {
                try
                {
                    //Concatenate query params
                    string queryParamString = "";
                    if (queryParams.Count != 0)
                    {
                        queryParamString = "?";
                        foreach (string key in queryParams.Keys)
                        {
                            queryParamString += key + "=" + queryParams[key] + "&";
                        }
                        queryParamString = queryParamString.Substring(0, queryParamString.Length);
                    }
                    //Add query params to url
                    Url url = new Url(this.url + queryParamString);
                    connection.BaseAddress = url.Value;

                    //Add proxy if needed
                    if (Config.proxy != null)
                    {
                        connection.Proxy = Config.proxy;
                        if (Config.proxyAuth != null)
                        {
                            connection.Headers.Add("Proxy-Authorization", "Basic " + Config.proxyAuth);
                        }
                    }

                    //Add Vantiv license header
                    connection.Headers.Add("Authorization", "VANTIV license=\"" + Config.license + "\"");

                    //For all methods but GET
                    if (!method.Equals("GET"))
                    {
                        connection.Headers.Add("Content-Type", "application/json");

                        //Request is this object stringified to JSON
                        string request = this.toJSON();

                        //Print request if specified in Config.cs
                        if (Config.printRequest)
                        {
                            Console.WriteLine(request);
                        }

                        //Receive Response
                        byte[] jsonOut = Encoding.UTF8.GetBytes(request);
                        string response = Encoding.UTF8.GetString(connection.UploadData(connection.BaseAddress, jsonOut));

                        //Print response if specified
                        if (Config.printResponse)
                        {
                            Console.WriteLine(response);
                        }

                        return response;
                    }

                    //For GET requests
                    using (Stream readStream = connection.OpenRead(connection.BaseAddress))
                    {
                        using (StreamReader streamReader = new StreamReader(readStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
                catch (WebException e)
                {
                    try
                    {
                        if (e.Response != null)
                        {
                            using (StreamReader streamReader = new StreamReader(e.Response.GetResponseStream()))
                            {
                                Console.WriteLine(streamReader.ReadToEnd());
                            }
                        }
                        else
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    catch (Exception e1)
                    {
                        Console.WriteLine(e1.ToString());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                return null;
            }
        }

        public abstract string toJSON();

    }
}
