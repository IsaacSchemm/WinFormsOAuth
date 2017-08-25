using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Net;
using System.IO;
using System.Collections.Specialized;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace ISchemm.WinFormsOAuth
{
    public class OAuthTwitter : oAuthBase
    {
        public OAuthTwitter(string consumerKey, string consumerSecret) : base(consumerKey, consumerSecret) { }

        public override string REQUEST_TOKEN => "https://api.twitter.com/oauth/request_token";
        public override string AUTHORIZE => "https://api.twitter.com/oauth/authorize";
        public override string ACCESS_TOKEN => "https://api.twitter.com/oauth/access_token";
    }
}