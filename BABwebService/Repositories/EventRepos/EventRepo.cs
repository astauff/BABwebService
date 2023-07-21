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

        public async Task<int> PostEvent(EventModel eventModel, Guid guid)
        {
            var query = $"INSERT INTO [dbo].[eventInfo] VALUES ('{eventModel.eventName}', '{eventModel.eventDate}', '{eventModel.eventStart}', '{eventModel.eventEnd}', '{eventModel.groupEvent}', '{eventModel.groupMembers}');";

            try
            {
                using (var connection = _dapperContext.CreateConnection())
                {
                    await connection.ExecuteAsync(query);
                }

                return 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

                return 9;
            }
        }
    }
}

