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
		public void Create(CustomerModel customers)
		{

		}
		public void Edit(CustomerModel customers)
		{

		}
		public void Delete(int id)
		{

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
										Where Customer_Id = @Id or Customer_Name like '%' + @Name + '%' 
										Order by Customer_Id desc";

				command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
				command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;

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

