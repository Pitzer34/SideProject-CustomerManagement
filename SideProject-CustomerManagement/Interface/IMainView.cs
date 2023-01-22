using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideProject_CustomerManagement.Interface
{
	public interface IMainView
	{
		event EventHandler ShowCustomerView;
		event EventHandler ShowStoreView;
		event EventHandler ShowReserveView;
	}
}
