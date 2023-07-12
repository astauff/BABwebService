using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BABwebService.Context
{
	public class DapperContext
	{
		private readonly IConfiguration _configuration;
		private readonly string _connectionString;

		public DapperContext(IConfiguration configuration)
		{
			_configuration = configuration;
			_connectionString = _configuration.GetConnectionString("BABbase");
		}

		public IDbConnection CreateConnection()
			=> new SqlConnection(_connectionString);
	}
}

