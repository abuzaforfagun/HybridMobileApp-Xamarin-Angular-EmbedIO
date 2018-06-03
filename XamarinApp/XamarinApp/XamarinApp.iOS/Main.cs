using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Foundation;
using UIKit;
using Unosquare.Labs.EmbedIO;
using Unosquare.Labs.EmbedIO.Modules;

namespace XamarinApp.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.

            var server = new WebServer("http://localhost:8080")
                                .EnableCors();
            server.RegisterModule(new WebApiModule());
            server.Module<WebApiModule>().RegisterController<MyFavouriteProgrammingLanguage>();
            server.RunAsync();
            

            UIApplication.Main(args, null, "AppDelegate");

        }
    }
}
