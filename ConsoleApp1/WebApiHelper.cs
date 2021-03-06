﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WebApiHelper
    {
        //get,post
        public WebApiHelper(string baseAddress)
        {
            client.BaseAddress = new Uri(baseAddress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

        }

        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> PostData(string requestUri, object data)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                requestUri, data);
            return response.Content.ReadAsStringAsync().Result;
        }

        public static async Task<string> GetData(string requestUri)
        {
            HttpResponseMessage response = await client.GetAsync(
                requestUri);
            return response.Content.ReadAsStringAsync().Result;
        }

    }
}
