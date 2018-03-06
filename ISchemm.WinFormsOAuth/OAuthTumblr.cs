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
    public class OAuthTumblr : oAuthBase
    {
        public OAuthTumblr(string consumerKey, string consumerSecret) : base(consumerKey, consumerSecret) { }

        public override string REQUEST_TOKEN => "https://www.tumblr.com/oauth/request_token";
        public override string AUTHORIZE => "https://www.tumblr.com/oauth/authorize";
        public override string ACCESS_TOKEN => "https://www.tumblr.com/oauth/access_token";
    }
}