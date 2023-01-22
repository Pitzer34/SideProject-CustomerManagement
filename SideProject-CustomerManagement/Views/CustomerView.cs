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
	public partial class CustomerView : Form, ICustomerView
	{
		//Constructor
		public CustomerView()
		{
			InitializeComponent();
			AssociateAndRaiseViewEvents();
			tabControl1.TabPages.Remove(tabPageDetail);
			
		}

		private void AssociateAndRaiseViewEvents()
		{
			btnListSearch.Click += delegate
			{
				if(SearchEvent != null) SearchEvent(this, EventArgs.Empty);
			};

			txtSearch.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
				{
					if (SearchEvent != null) SearchEvent(this, EventArgs.Empty);
				}
			};
			//Others
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public bool Gender { get; set; }
		public DateTime Birthday { get; set; }
		public string Address { get; set; }

		public string SearchValue
		{
			get { return txtSearch.Text; }
			set { txtSearch.Text = value; }
		}
		public bool IsEdit { get; set; }
		public bool IsSuccessful { get; set; }
		public string Message { get; set; }

		//Events
		public event EventHandler SearchEvent;
		public event EventHandler CreateEvent;
		public event EventHandler EditEvent;
		public event EventHandler DeleteEvent;
		public event EventHandler SaveEvent;
		public event EventHandler CancelEvent;

		//Methods
		public void SetCustomerListBindingSource(BindingSource customerList)
		{			
			dataGridView.DataSource = customerList;
		}

		
	}
}
