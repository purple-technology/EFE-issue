using Npgsql;
using TestingORM.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TestingORM.DAL
{
	public class TestingContext : DbContext
	{
		public DbSet<Server> Servers { get; set; }

		public TestingContext() : base(new NpgsqlConnectionFactory().CreateConnection("connection_string"), true)
		{
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			Database.SetInitializer<TestingContext>(null);
			modelBuilder.HasDefaultSchema("public");
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}
