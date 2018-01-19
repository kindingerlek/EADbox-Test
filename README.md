EADbox-Test

# Requirements

 - Visual Studio 2017
 - Newtonsoft.Json Library

# Installing this Project

After cloning this repo, open it in Visual Studio. Then, open `Tools > NuGet Package Manager > Package Manager Console` and type in console:

```
    Install-Package Newtonsoft.Json
```

After that, the Newtonsoft Library is installed;

# Setting Up the Project

First, go to [Facebook Graph Explorer](https://developers.facebook.com/tools/explorer/) and click in `Get Token >  Get User Access Token` to create a new access token. Make sure, this AccessToken provides the permissions: email and publish_actions.

Go to FacebookSettings.cs class, and add your Graph API Access Token. 

# Running this Project

Just tap 'Start' in Main Menu. That's it!

# References

This project was create following the Piotr Gankiewickz's article. 