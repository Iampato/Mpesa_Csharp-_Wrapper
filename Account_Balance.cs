using System;
using System.Text;
using System.IO;
using System.Net;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Title="Account Balance";
            String a = "https://sandbox.safaricom.co.ke/mpesa/accountbalance/v1/query";

            string baseUrl = a;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl);
            String token = "ACCESS_TOKEN";
            request.Headers.Add("authorization", "Bearer " + token);
            request.ContentType = "application/json";
            request.Headers.Add("cache-control", "no-cache");

           	request.KeepAlive = false;
            request.Method = "POST";


            using (StreamWriter streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"Initiator\":\" \"," +
                              "\"SecurityCredential\":\" \"," +
                              "\"CommandID\":\"AccountBalance\"," +
                              "\"PartyA\":\" \"," +
                              "\"IdentifierType\":\"4\"," +
                              "\"Remarks\":\" \"," +
                              "\"QueueTimeOutURL\":\"https://ip_address:port/timeout_url\"," +
                              "\"ResultURL\":\"https://ip_address:port/result_url\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }


        }
    }
}