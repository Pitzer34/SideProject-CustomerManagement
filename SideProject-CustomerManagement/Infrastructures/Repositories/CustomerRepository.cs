using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SideProject_CustomerManagement.Interface;
using SideProject_CustomerManagement.Models;

namespace SideProject_CustomerManagement.Infrastructures.Repositories
{
	public class CustomerRepository : BaseRepository, ICustomerRepository
	{
		//Constructor
		public CustomerRepository(string connectionString)
		{
			this.connectionString = connectionString;
		}

		//Methods
		public void Create(CustomerModel customerModel)
		{
			using (var connection = new SqlConnection(connectionString))
			using (var command = new SqlCommand())
			{
				connection.Open();
				command.Connection = connection;
				command.CommandText = "Insert into Customers values(@name, @gender, @birthday, @address)";
				command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customerModel.Name;
				command.Parameters.Add("@gender", SqlDbType.Bit).Value = customerModel.Gender;
				command.Parameters.Add("@birthday", SqlDbType.DateTime).Value = customerModel.Birthday;
				command.Parameters.Add("@address", SqlDbType.NVarChar).Value = customerModel.Address;
				command.ExecuteNonQuery();
			}
		}
		public void Edit(CustomerModel customerModel)
		{
			using (var connection = new SqlConnection(connectionString))
			using (var command = new SqlCommand())
			{
				connection.Open();
				command.Connection = connection;
				command.CommandText = "Update Customers " +
									"set Customer_Name = @name, Customer_Gender = @gender, Customer_Birthday = @birthday, Customer_Address = @address " +
									"where Customer_Id = @id";
				command.Parameters.Add("@id", SqlDbType.Int).Value = customerModel.Id;
				command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customerModel.Name;
				command.Parameters.Add("@gender", SqlDbType.Bit).Value = customerModel.Gender;
				command.Parameters.Add("@birthday", SqlDbType.DateTime).Value = customerModel.Birthday;
				command.Parameters.Add("@address", SqlDbType.NVarChar).Value = customerModel.Address;
				command.ExecuteNonQuery();
			}
		}
		public void Delete(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			using (var command = new SqlCommand())
			{
				connection.Open();
				command.Connection = connection;
				command.CommandText = "Delete from Customers where Customer_Id = @id";
				command.Parameters.Add("@id", SqlDbType.Int).Value = id;
				
				command.ExecuteNonQuery();
			}
		}

		public IEnumerable<CustomerModel> GetAll()
		{
			var customerList = new List<CustomerModel>();
			using (var connection = new SqlConnection(connectionString))
			using (var command = new SqlCommand())
			{
				connection.Open();
				command.Connection = connection;
				command.CommandText = "Select * from Customers Order by Customer_Id desc";
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var customers = new CustomerModel();
						customers.Id = (int)reader[0];
						customers.Name = (string)reader[1];
						customers.Gender = (bool)reader[2];
						customers.Birthday = (DateTime)reader[3];
						customers.Address = (string)reader[4];

						customerList.Add(customers);
					}
				}
			}

			return customerList;
		}
		public IEnumerable<CustomerModel> GetByValue(string value)
		{
			var customerList = new List<CustomerModel>();
			int id = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
			string name = value;
			using (var connection = new SqlConnection(connectionString))
			using (var command = new SqlCommand())
			{
				connection.Open();
				command.Connection = connection;
				command.CommandText = @"Select * from Customers 
										Where Customer_Id = @id or Customer_Name like '%' + @name + '%' 
										Order by Customer_Id desc";

				command.Parameters.Add("@id", SqlDbType.Int).Value = id;
				command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var customers = new CustomerModel();
						customers.Id = (int)reader[0];
						customers.Name = (string)reader[1];
						customers.Gender = (bool)reader[2];
						customers.Birthday = (DateTime)reader[3];
						customers.Address = (string)reader[4];

						customerList.Add(customers);
					}
				}
			}

			return customerList;
		}
	}
}

