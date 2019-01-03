using System;
using System.Collections.Generic;
using System.Text;

namespace RIOT_API_Client.Abstractions.Models
{
    public interface ISumonner
    {
        long Id { get; set; }
        long AccountId { get; set; }
        string Name { get; set; }
        long SummonerLevel { get; set; }
    }
}
