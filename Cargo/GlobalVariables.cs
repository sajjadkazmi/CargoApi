﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Cargo
{
    public static class GlobalVariable
    {
        public static HttpClient WebApiClient = new HttpClient();


        static GlobalVariable()
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:49055/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}