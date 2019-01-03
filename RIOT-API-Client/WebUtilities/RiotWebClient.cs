using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LOL_Riot_Api_Client.WebUtilities
{
    internal class WebClient
    {
        private static WebClient _instance;
        private readonly static object _locker = new object();


        // property  to get thread-safe webClient singleton object
        public static WebClient GetInstance
        {
            get
            {
                
                if(_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new WebClient();
                        }
                    }
                }

                return _instance;
            }
        }


        public async Task<string> GetAsync(string uri)
        {
            var request = (HttpWebRequest)WebRequest.Create(uri);

            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
