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
        List<string> languageList;
        public MyFavouriteProgrammingLanguage()
        {
            languageList = new List<string>();
            addDummyData();
        }

        private void addDummyData()
        {
            languageList.Add("C#");
            languageList.Add("TypeScript");
            languageList.Add("JavaScript");
            languageList.Add("PHP");
        }

        [WebApiHandler(HttpVerbs.Get, "/api/favouritelanguage")]
        public bool GetAll(WebServer server,
                            HttpListenerContext context)
        {
            var languageList = new List<string>();

            return context.JsonResponse(
                languageList.ToArray());
            
        }

        [WebApiHandler(HttpVerbs.Post, "/api/favouritelanguage")]
        public bool Post(WebServer server, HttpListenerContext context)
        {
            var model = context.ParseJson<string>();

            this.languageList.Add(model);
            // Do dataase operation
            return context.JsonResponse(languageList.ToArray());
        }
    }
}
