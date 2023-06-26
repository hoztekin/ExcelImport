using System.Data;

namespace ExcelImport.Concrete
{
	public interface ICustomer
	{
		string Documentupload(IFormFile formFile);
		DataTable CustomerDataTable(string path);
		void ImportCustomer(DataTable customer);
	}
}
