using System;
namespace ff_calculator_server.Models
{
	public class Stage
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int FromAge { get; set; }
		public int ToAge { get; set; }
		public int StageLength { get; set; }
		public Revenue RevenueModel { get; set; }
		public Expense ExpenseModel { get; set; }
		public int StageOfLife { get; set; }

	}
}

