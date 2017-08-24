# ISchemm.WinFormsOAuth

[![NuGet](https://img.shields.io/nuget/v/ISchemm.WinFormsOAuth.svg)](https://www.nuget.org/packages/ISchemm.WinFormsOAuth)

https://github.com/IsaacSchemm/WinFormsOAuth

This code allows you to implement OAuth for the Tumblr, Twitter, and/or Flickr APIs in a .NET desktop application, using the WebBrowser control available in .NET. It's based on David Quail's LinkedIn example: https://github.com/dquail/LinkedinOauth

Before you show the login window, you might want to set the FEATURE_BROWSER_EMULATION registry key so that the login window uses IE11's document mode (especially with Flickr.) You can do this with IECompatibility.SetForCurrentProcess.

Example usage:

	OAuthTumblr oauth = new OAuthTumblr("CONSUMER_KEY", "CONSUMER_SECRET");
	string requestToken = oauth.getRequestToken();
	string verifier = oauth.authorizeToken(); // display WebBrowser
	if (verifier == null) throw new Exception("Authentication failed or cancelled by user");
	string accessToken = oauth.getAccessToken();
	string accessTokenSecret = oauth.TokenSecret;

The call to getAccessToken() also fills in the TokenSecret property, so make sure to call them in that order. Tokens can be re-used, so you can store them somewhere - but remember that anyone with the access token & secret has all the permissions of the app for that user, so be careful!
