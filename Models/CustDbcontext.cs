using Microsoft.EntityFrameworkCore;

namespace ExcelImport.Models
{
	public class CustDbcontext : DbContext
	{
		public CustDbcontext(DbContextOptions<CustDbcontext> options) : base(options)
		{

		}

		public virtual DbSet<Customer> Customers { get; set; }
	}
}
