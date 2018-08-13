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

           



        }
    }
}