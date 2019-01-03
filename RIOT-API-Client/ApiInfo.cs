using System;
using System.Collections.Generic;
using System.Text;

namespace LOL_Riot_Api_Client
{
    internal class ApiInfo
    {
        private static ApiInfo instance;
        private static readonly object Locker = new object();
        internal string RiotApiKey { get; set; }

        private ApiInfo()
        {

        }

        private ApiInfo(string key)
        {
            this.RiotApiKey = key;
        }

        // method to get thread-safe singleton instance
        public static ApiInfo GetApiConfigInstance(string key)
        {
                if(instance == null)
                {
                    lock (Locker)
                    {
                        if (instance == null)
                        {
                            instance = new ApiInfo(key);
                        }
                    }
                }

                return instance;   
        }



    }
}
