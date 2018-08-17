# HybridMobileApp-Xamarin-Angular-EmbedIO

Step 1: Do the business logic and data communication development with your favourite language C#.

Step 2: Develop your front end using Angular/React/Javascript whatever you want. And what you can deploy over web server too. Just make sure your app communicate over Web API.

Step 3: Create Xamarin.Forms app with single page and single WebView. You also can use Xam.Plugin.Webview (https://github.com/SKLn-Rad/Xam.Plugin.Webview/tree/master/SampleApp)

Step 4: Install EmbedIO.

Step 5: Re-do only web api controller section using embedio

Step 6: Initialize and run web server from your App(App.xaml.cs).

Step 7: Add your deployment ready front end files to xamarin platform specific resource folder. Note: you may face problem to add huge ammount of files over visual studio/xamarin studio. And you easily can fix it by following silly tricks. Copy files over file manager and edit your .csproj file to add that full folder. Ex:
```
<BundleResource Include="Resources\dist\**" /> 
```

Step 8: Point to that local file to server your web view

Step 9: Take a coffee for saving your 100+ hours.
