using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideProject_CustomerManagement.Interface
{
	public interface ICustomerView
	{
		//properties - Fields
		string customerId { get; set; }
		string customerName { get; set; }
		bool customerGender { get; set; }
		DateTime customerBirthday { get; set; }
		string customerAddress { get; set; }
		
		string SearchValue { get; set; }
		bool IsEdit { get; set; }
		bool IsSuccessful { get; set; }
		string Message { get; set; }

		//Events
		event EventHandler SearchEvent;
		event EventHandler CreateEvent;
		event EventHandler EditEvent;
		event EventHandler DeleteEvent;
		event EventHandler SaveEvent;
		event EventHandler CancelEvent;

		//Methods
		void SetCustomerListBindingSource(BindingSource customerList);
		void Show();//Optional
	}
}
