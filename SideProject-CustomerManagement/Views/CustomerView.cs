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
			btnClose.Click += delegate { this.Close(); };			
		}

		private void AssociateAndRaiseViewEvents()
		{
			//Search
			btnListSearch.Click += delegate
			{
				if(SearchEvent != null) SearchEvent(this, EventArgs.Empty);
			};

			//Search by txtEnter
			txtSearch.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
				{
					if (SearchEvent != null) SearchEvent(this, EventArgs.Empty);
				}
			};

			//Create
			btnListCreate.Click += delegate
			{
				if (CreateEvent != null) CreateEvent(this, EventArgs.Empty);
				tabControl1.TabPages.Remove(tabPageList);
				tabControl1.TabPages.Add(tabPageDetail);
				tabPageDetail.Text = "Add new customer";
			};

			//Edit
			btnListEdit.Click += delegate
			{
				if (EditEvent != null) EditEvent(this, EventArgs.Empty);
				tabControl1.TabPages.Remove(tabPageList);
				tabControl1.TabPages.Add(tabPageDetail);
				tabPageDetail.Text = "Edit customer";
			};

			//Delete
			btnListDelete.Click += delegate
			{
				var result = MessageBox.Show("Are you sure you want to delete the select customer?", "Warning", 
								MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if(result == DialogResult.Yes)
				{
					if(DeleteEvent != null) DeleteEvent(this, EventArgs.Empty);
					MessageBox.Show(Message);
				}				
			};

			//Save changes
			btnDetailSave.Click += delegate
			{
				if (SaveEvent != null) SaveEvent(this, EventArgs.Empty);
				if (IsSuccessful)
				{
					tabControl1.TabPages.Remove(tabPageDetail);
					tabControl1.TabPages.Add(tabPageList);
				}

				MessageBox.Show(Message);
			};

			//Cancel
			btnDetailCancel.Click += delegate
			{
				if (CancelEvent != null) CancelEvent(this, EventArgs.Empty);
				tabControl1.TabPages.Remove(tabPageDetail);
				tabControl1.TabPages.Add(tabPageList);
			};
		}

		public string customerId 
		{
			get { return textCustomerId.Text; }
			set { textCustomerId.Text = value; }
		}
		public string customerName 
		{
			get { return textCustomerName.Text; }
			set { textCustomerName.Text = value; }
		}
		public bool customerGender { get; set; }
		public DateTime customerBirthday 
		{
			get { return dtpCustomerBirthday.Value; }
			set { dtpCustomerBirthday.Value = value; }
		}
		public string customerAddress 
		{
			get { return textCustomerAddress.Text; }
			set { textCustomerAddress.Text = value; }
		}

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

		//Singleton pattern(Open a single form instance)
		private static CustomerView instance;
		public static CustomerView GetInstance(Form parentContainer)
		{
			if(instance == null || instance.IsDisposed)
			{
				instance = new CustomerView();
				instance.MdiParent = parentContainer;
				instance.FormBorderStyle = FormBorderStyle.None;
				instance.Dock = DockStyle.Fill;
			}
			else
			{
				if(instance.WindowState == FormWindowState.Minimized)
				{
					instance.WindowState = FormWindowState.Normal;
				}
				else
				{
					instance.BringToFront();
				}
			}

			return instance;
		}
	}
}
