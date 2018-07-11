using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestingORM.Model
{
	public class Server
	{
		public int ServerID { get; set; }

		[Index(IsUnique = true), Required, MaxLength(40)]
		public string Name { get; set; }

		public Platform Platform { get; set; }
	}

	public enum Platform
	{
		Unknown = 0,
		x86 = 1,
		x64 = 2,
		Arm = 3
	};
}
