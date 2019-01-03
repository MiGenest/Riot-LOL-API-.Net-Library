using RIOT_API_Client.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RIOT_API_Client.Implementations.Models
{
    public class Sumonner : ISumonner
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string Name { get; set; }
        public long SummonerLevel { get; set; }
    }
}
