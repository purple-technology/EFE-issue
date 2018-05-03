using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestingORM.Model
{
	public class Server
	{
		public int ServerID { get; set; }

		[Index(IsUnique = true), Required, MaxLength(40)]
		public string Name { get; set; }

		[Required, MaxLength(40)]
		public string Data { get; set; }
	}
}
