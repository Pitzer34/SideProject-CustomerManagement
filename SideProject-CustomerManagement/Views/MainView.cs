using SideProject_CustomerManagement.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideProject_CustomerManagement.Views
{
	public partial class MainView : Form, IMainView
	{
		public MainView()
		{
			InitializeComponent();
			btnCustomers.Click += delegate
			{
				if (ShowCustomerView != null) ShowCustomerView(this, EventArgs.Empty);				
			};
		}

		public event EventHandler ShowCustomerView;
		public event EventHandler ShowStoreView;
		public event EventHandler ShowReserveView;
	}
}
