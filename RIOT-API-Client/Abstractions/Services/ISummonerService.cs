using RIOT_API_Client.Abstractions.Models;
using RIOT_API_Client.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RIOT_API_Client.Abstractions.Services
{
    interface ISummonerService
    {
        Task<ISummoner> GetSummonerByAccount(string accountId);
        Task<ISummoner> GetSummonerByName(string summonerName);
        Task<ISummoner> GetSummonerByPuuid(string puuid);
        Task<ISummoner> GetSummonerBySummonerId(string summonerId);
    }
}
