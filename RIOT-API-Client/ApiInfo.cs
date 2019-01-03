using System;
using System.Collections.Generic;
using System.Text;

namespace LOL_Riot_Api_Client
{
    internal class ApiInfo
    {
        private static ApiInfo instance;
        private static readonly object Locker = new object();


        // property to get thread-safe singleton instance
        public static ApiInfo GetInstance
        {
            get
            {
                if(instance == null)
                {
                    lock (Locker)
                    {
                        if (instance == null)
                        {
                            instance = new ApiInfo();
                        }
                    }
                }

                return instance;   
            }
        }

        internal readonly string RiotApiKey =
          "RGAPI-639ff8e9-40fb-4daa-a70f-78cc2865455b";

    }
}
