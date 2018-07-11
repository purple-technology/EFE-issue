using System.Collections.Generic;
using TestingORM.Model;
using TestingORM.DAL;
using System;

namespace db_testing
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var context = new TestingContext()) {
				context.Configuration.AutoDetectChangesEnabled = false;
				context.Configuration.LazyLoadingEnabled = false;

				const int count = 10;

				TestServersEFE(context, count);
			}
		}

		private static void TestServersEFE(TestingContext context, int count)
		{
			var servers = new List<Server>(count);
			for (var i = 0; i < count; ++i) {
				servers.Add(new Server {
					Name = "name_" + i,
					Platform = Platform.Arm,
				});
			}

			// Exception thrown here
			context.BulkInsert(servers, options => {
				options.Log = s => Console.WriteLine(s);
			});
		}
	}
}
