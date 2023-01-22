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
		int Id { get; set; }
		string Name { get; set; }
		bool Gender { get; set; }
		DateTime Birthday { get; set; }
		string Address { get; set; }
		
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
