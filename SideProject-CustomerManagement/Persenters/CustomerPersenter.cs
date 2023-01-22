using SideProject_CustomerManagement.Interface;
using SideProject_CustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideProject_CustomerManagement.Persenters
{
	public class CustomerPersenter
	{
		//Fields
		private ICustomerView view;
		private ICustomerRepository repository;
		private BindingSource customersBindingSource;
		private IEnumerable<CustomerModel> customerList;

		//Constructor
		public CustomerPersenter(ICustomerView view, ICustomerRepository repository)
		{
			this.customersBindingSource = new BindingSource();
			this.view = view;
			this.repository = repository;

			//Subscribe event handler methods to  view enents
			this.view.SearchEvent += SearchCustomer;
			this.view.CreateEvent += CreateCustomer;
			this.view.EditEvent += EditCustomer;
			this.view.DeleteEvent += DeleteCustomer;
			this.view.SaveEvent += SaveCustomer;
			this.view.CancelEvent += CancelCustomer;

			//Set customers binding source
			this.view.SetCustomerListBindingSource(customersBindingSource);

			//Load customer list view
			LoadAllCustomerList();

			//Show view
			this.view.Show();
		}

		private void LoadAllCustomerList()
		{
			customerList = repository.GetAll();
			customersBindingSource.DataSource = customerList;//Set data source
		}

		private void SearchCustomer(object sender, EventArgs e)
		{
			bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
			if(emptyValue == false)
			{
				customerList = repository.GetByValue(this.view.SearchValue);
			}
			else
			{
				customerList = repository.GetAll();
			}

			customersBindingSource.DataSource = customerList;
		}

		private void CreateCustomer(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
		private void EditCustomer(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
		private void DeleteCustomer(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void SaveCustomer(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}						

		private void CancelCustomer(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

	}
}
