using RIOT_API_Client.Abstractions.Models;
using RIOT_API_Client.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RIOT_API_Client.Implementations.Services
{
    class SummonerService : ISummonerService
    {

        public Task<ISummoner> GetSummonerByAccount(string accountId)
        {
            throw new NotImplementedException();
        }

        public Task<ISummoner> GetSummonerByName(string summonerName)
        {
            throw new NotImplementedException();
        }

        public Task<ISummoner> GetSummonerByPuuid(string puuid)
        {
            throw new NotImplementedException();
        }

        public Task<ISummoner> GetSummonerBySummonerId(string summonerId)
        {
            throw new NotImplementedException();
        }
    }
}
