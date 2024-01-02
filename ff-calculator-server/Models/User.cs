using System;
namespace ff_calculator_server.Models
{
	public class User
	{
		public int Id { get; set; }
		public int Name { get; set; }
		public Stage[] stages;
	}
}

