using System;
using System.Collections.Generic;
using System.Text;

namespace M7_3
{
    public class Url
    {
        public static string  AddOrChangeUrlParameter(string url,string keyValueParameter)
        {
            string[] helperForUrl = url.Split("?");
            if (helperForUrl.Length == 1)
            {
                url += "?" + keyValueParameter;
            }
            else
            {
                string[] helperForkeyValueParameter = keyValueParameter.Split("=");
                string[] helperForKey = helperForUrl[1].Split("=");
                if (helperForkeyValueParameter[0] == helperForKey[0])
                {
                    url = helperForUrl[0] + "?" + keyValueParameter;
                }
                else
                {
                    url += "&" + keyValueParameter;
                }
            }
            return url;
        }
    }
}
