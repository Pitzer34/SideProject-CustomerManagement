using SideProject_CustomerManagement.Infrastructures;
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
			view.IsEdit = false;
		}
		private void EditCustomer(object sender, EventArgs e)
		{
			var customer = (CustomerModel)customersBindingSource.Current;
			view.customerId = customer.Id.ToString();
			view.customerName = customer.Name;
			view.customerGender = customer.Gender;
			view.customerBirthday = customer.Birthday;
			view.customerAddress = customer.Address;
			view.IsEdit = true;
		}
		private void DeleteCustomer(object sender, EventArgs e)
		{
			try
			{
				var customer = (CustomerModel)customersBindingSource.Current;
				repository.Delete(customer.Id);
				view.IsSuccessful = true;
				view.Message = "Customer deleted successfully";
				LoadAllCustomerList();
			}
			catch (Exception ex)
			{
				view.IsSuccessful = false;
				view.Message = "An error ocurred, could not delete customer";
			}
		}

		private void SaveCustomer(object sender, EventArgs e)
		{
			var model = new CustomerModel();
			model.Id = Convert.ToInt32(view.customerId);
			model.Name = view.customerName;
			model.Gender = view.customerGender;
			model.Birthday = view.customerBirthday;
			model.Address = view.customerAddress;

			try
			{
				new ModelDataVaildation().Vaildation(model);

				//Edit model
				if (view.IsEdit == true)
				{
					repository.Edit(model);
					view.Message = "Customer edited successfully";
				}
				//Create model
				else
				{
					repository.Create(model);
					view.Message = "Customer Created successfully";
				}

				view.IsSuccessful = true;
				LoadAllCustomerList();
				CleanViewFields();
			}
			catch(Exception ex)
			{
				view.IsSuccessful = false;
				view.Message = ex.Message;
			}
		}
		
		private void CleanViewFields()
		{
			view.customerId = "0";
			view.customerName = "";
			view.customerGender = true;
			view.customerBirthday = DateTime.Today;
			view.customerAddress = "";
		}

		private void CancelCustomer(object sender, EventArgs e)
		{
			CleanViewFields();
		}

	}
}
