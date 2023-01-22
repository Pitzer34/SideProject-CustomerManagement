using SideProject_CustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideProject_CustomerManagement.Interface
{
	public interface ICustomerRepository
	{
		void Create(CustomerModel customers);
		void Edit(CustomerModel customers);
		void Delete(int id);

		IEnumerable<CustomerModel> GetAll();
		IEnumerable<CustomerModel> GetByValue(string value);//Searchs
	}
}
