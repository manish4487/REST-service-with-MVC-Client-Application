using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MVCAPP
{
    public class Globalvariables
    {
        public static HttpClient WebapiClient = new HttpClient();

        Globalvariables()
        {

            WebapiClient.BaseAddress = new Uri("http://localhost:61074/api/");
            WebapiClient.DefaultRequestHeaders.Clear();
            WebapiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}