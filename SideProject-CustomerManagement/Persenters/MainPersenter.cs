using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SideProject_CustomerManagement.Views;
using SideProject_CustomerManagement.Infrastructures.Repositories;
using SideProject_CustomerManagement.Models;
using SideProject_CustomerManagement.Interface;
using System.Windows.Forms;

namespace SideProject_CustomerManagement.Persenters
{
	public class MainPersenter
	{
		private IMainView mainView;
		private readonly string sqlConnectionString;

		public MainPersenter(IMainView mainView, string sqlConnectionString)
		{
			this.mainView = mainView;
			this.sqlConnectionString = sqlConnectionString;
			this.mainView.ShowCustomerView += ShowCustomerView;
		}

		private void ShowCustomerView(object sender, EventArgs e)
		{
			ICustomerView view = CustomerView.GetInstance((MainView)mainView);
			ICustomerRepository repository = new CustomerRepository(sqlConnectionString);
			new CustomerPersenter(view, repository);
		}
	}
}
