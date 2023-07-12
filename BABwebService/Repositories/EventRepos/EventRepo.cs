using System;
using Dapper;
using Microsoft.Extensions.Configuration;
using BABwebService.Models;
using BABwebService.Context;


namespace BABwebService.Repositories.EventRepos
{
	public class EventRepo : IEventRepo
	{
        private readonly IConfiguration _configuration;
        private readonly DapperContext _dapperContext;

		public EventRepo(IConfiguration configuration, DapperContext dapperContext)
		{
            _configuration = configuration;
            _dapperContext = dapperContext;
		}

        public async Task<IEnumerable<EventModel>> GetEvents(Guid guid)
        {
            var query = "SELECT * FROM [dbo].[eventInfo]";

            using (var connection = _dapperContext.CreateConnection())
            {
                var events = await connection.QueryAsync<EventModel>(query);
                return events.ToList();
            }
        }
    }
}

