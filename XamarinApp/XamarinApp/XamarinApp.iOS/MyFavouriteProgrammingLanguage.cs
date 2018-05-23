using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Unosquare.Labs.EmbedIO;
using Unosquare.Labs.EmbedIO.Constants;
using Unosquare.Labs.EmbedIO.Modules;

namespace XamarinApp.iOS
{
    public class MyFavouriteProgrammingLanguage : WebApiController
    {
        [WebApiHandler(HttpVerbs.Get, "/api/favouritelanguage")]
        public bool GetAll(WebServer server,
                            HttpListenerContext context)
        {
            var languageList = new List<string>();
            languageList.Add("C#");
            languageList.Add("TypeScript");

            return context.JsonResponse(new
            {
                list = languageList.ToArray()
            });
            
        }
    }
}
