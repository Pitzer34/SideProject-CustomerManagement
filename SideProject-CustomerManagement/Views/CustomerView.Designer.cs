namespace SideProject_CustomerManagement.Views
{
	partial class CustomerView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblCustomers = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageList = new System.Windows.Forms.TabPage();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.btnListDelete = new System.Windows.Forms.Button();
			this.btnListEdit = new System.Windows.Forms.Button();
			this.btnListCreate = new System.Windows.Forms.Button();
			this.btnListSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.tabPageDetail = new System.Windows.Forms.TabPage();
			this.dtpCustomerBirthday = new System.Windows.Forms.DateTimePicker();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rbtnFemale = new System.Windows.Forms.RadioButton();
			this.rbtnMale = new System.Windows.Forms.RadioButton();
			this.textCustomerName = new System.Windows.Forms.TextBox();
			this.textCustomerAddress = new System.Windows.Forms.TextBox();
			this.textCustomerId = new System.Windows.Forms.TextBox();
			this.btnDetailCancel = new System.Windows.Forms.Button();
			this.btnDetailSave = new System.Windows.Forms.Button();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblBirthday = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.lblCustomerID = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPageList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.tabPageDetail.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblCustomers
			// 
			this.lblCustomers.AutoSize = true;
			this.lblCustomers.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomers.Location = new System.Drawing.Point(112, 32);
			this.lblCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCustomers.Name = "lblCustomers";
			this.lblCustomers.Size = new System.Drawing.Size(149, 32);
			this.lblCustomers.TabIndex = 0;
			this.lblCustomers.Text = "Customers";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.lblCustomers);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1034, 115);
			this.panel1.TabIndex = 1;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPageList);
			this.tabControl1.Controls.Add(this.tabPageDetail);
			this.tabControl1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(0, 115);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1034, 543);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPageList
			// 
			this.tabPageList.BackColor = System.Drawing.Color.White;
			this.tabPageList.Controls.Add(this.dataGridView);
			this.tabPageList.Controls.Add(this.btnListDelete);
			this.tabPageList.Controls.Add(this.btnListEdit);
			this.tabPageList.Controls.Add(this.btnListCreate);
			this.tabPageList.Controls.Add(this.btnListSearch);
			this.tabPageList.Controls.Add(this.txtSearch);
			this.tabPageList.Controls.Add(this.lblSearch);
			this.tabPageList.Location = new System.Drawing.Point(4, 32);
			this.tabPageList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageList.Name = "tabPageList";
			this.tabPageList.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageList.Size = new System.Drawing.Size(1026, 507);
			this.tabPageList.TabIndex = 0;
			this.tabPageList.Text = "CustomerList";
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(13, 90);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(863, 413);
			this.dataGridView.TabIndex = 7;
			// 
			// btnListDelete
			// 
			this.btnListDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnListDelete.Location = new System.Drawing.Point(894, 185);
			this.btnListDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnListDelete.Name = "btnListDelete";
			this.btnListDelete.Size = new System.Drawing.Size(110, 37);
			this.btnListDelete.TabIndex = 6;
			this.btnListDelete.Text = "Delete";
			this.btnListDelete.UseVisualStyleBackColor = true;
			// 
			// btnListEdit
			// 
			this.btnListEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnListEdit.Location = new System.Drawing.Point(894, 138);
			this.btnListEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnListEdit.Name = "btnListEdit";
			this.btnListEdit.Size = new System.Drawing.Size(110, 37);
			this.btnListEdit.TabIndex = 5;
			this.btnListEdit.Text = "Edit";
			this.btnListEdit.UseVisualStyleBackColor = true;
			// 
			// btnListCreate
			// 
			this.btnListCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnListCreate.Location = new System.Drawing.Point(894, 91);
			this.btnListCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnListCreate.Name = "btnListCreate";
			this.btnListCreate.Size = new System.Drawing.Size(110, 37);
			this.btnListCreate.TabIndex = 4;
			this.btnListCreate.Text = "Create";
			this.btnListCreate.UseVisualStyleBackColor = true;
			// 
			// btnListSearch
			// 
			this.btnListSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnListSearch.Location = new System.Drawing.Point(775, 45);
			this.btnListSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnListSearch.Name = "btnListSearch";
			this.btnListSearch.Size = new System.Drawing.Size(100, 37);
			this.btnListSearch.TabIndex = 3;
			this.btnListSearch.Text = "Search";
			this.btnListSearch.UseVisualStyleBackColor = true;
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.Location = new System.Drawing.Point(13, 45);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(754, 31);
			this.txtSearch.TabIndex = 1;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(9, 17);
			this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(186, 23);
			this.lblSearch.TabIndex = 0;
			this.lblSearch.Text = "Search Customer:";
			// 
			// tabPageDetail
			// 
			this.tabPageDetail.Controls.Add(this.dtpCustomerBirthday);
			this.tabPageDetail.Controls.Add(this.panel2);
			this.tabPageDetail.Controls.Add(this.textCustomerName);
			this.tabPageDetail.Controls.Add(this.textCustomerAddress);
			this.tabPageDetail.Controls.Add(this.textCustomerId);
			this.tabPageDetail.Controls.Add(this.btnDetailCancel);
			this.tabPageDetail.Controls.Add(this.btnDetailSave);
			this.tabPageDetail.Controls.Add(this.lblAddress);
			this.tabPageDetail.Controls.Add(this.lblBirthday);
			this.tabPageDetail.Controls.Add(this.lblName);
			this.tabPageDetail.Controls.Add(this.lblGender);
			this.tabPageDetail.Controls.Add(this.lblCustomerID);
			this.tabPageDetail.Location = new System.Drawing.Point(4, 32);
			this.tabPageDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageDetail.Name = "tabPageDetail";
			this.tabPageDetail.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageDetail.Size = new System.Drawing.Size(1026, 507);
			this.tabPageDetail.TabIndex = 1;
			this.tabPageDetail.Text = "CustomerDetail";
			this.tabPageDetail.UseVisualStyleBackColor = true;
			// 
			// dtpCustomerBirthday
			// 
			this.dtpCustomerBirthday.Location = new System.Drawing.Point(298, 177);
			this.dtpCustomerBirthday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dtpCustomerBirthday.Name = "dtpCustomerBirthday";
			this.dtpCustomerBirthday.Size = new System.Drawing.Size(200, 31);
			this.dtpCustomerBirthday.TabIndex = 14;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rbtnFemale);
			this.panel2.Controls.Add(this.rbtnMale);
			this.panel2.Location = new System.Drawing.Point(298, 80);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(202, 37);
			this.panel2.TabIndex = 13;
			// 
			// rbtnFemale
			// 
			this.rbtnFemale.AutoSize = true;
			this.rbtnFemale.Location = new System.Drawing.Point(104, 4);
			this.rbtnFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rbtnFemale.Name = "rbtnFemale";
			this.rbtnFemale.Size = new System.Drawing.Size(94, 27);
			this.rbtnFemale.TabIndex = 12;
			this.rbtnFemale.Text = "Female";
			this.rbtnFemale.UseVisualStyleBackColor = true;
			// 
			// rbtnMale
			// 
			this.rbtnMale.AutoSize = true;
			this.rbtnMale.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.rbtnMale.Location = new System.Drawing.Point(15, 4);
			this.rbtnMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rbtnMale.Name = "rbtnMale";
			this.rbtnMale.Size = new System.Drawing.Size(72, 27);
			this.rbtnMale.TabIndex = 11;
			this.rbtnMale.Text = "male";
			this.rbtnMale.UseVisualStyleBackColor = true;
			// 
			// textCustomerName
			// 
			this.textCustomerName.Location = new System.Drawing.Point(55, 177);
			this.textCustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textCustomerName.Name = "textCustomerName";
			this.textCustomerName.Size = new System.Drawing.Size(200, 31);
			this.textCustomerName.TabIndex = 10;
			// 
			// textCustomerAddress
			// 
			this.textCustomerAddress.Location = new System.Drawing.Point(55, 278);
			this.textCustomerAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textCustomerAddress.Multiline = true;
			this.textCustomerAddress.Name = "textCustomerAddress";
			this.textCustomerAddress.Size = new System.Drawing.Size(443, 74);
			this.textCustomerAddress.TabIndex = 8;
			// 
			// textCustomerId
			// 
			this.textCustomerId.Location = new System.Drawing.Point(55, 80);
			this.textCustomerId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textCustomerId.Name = "textCustomerId";
			this.textCustomerId.ReadOnly = true;
			this.textCustomerId.Size = new System.Drawing.Size(200, 31);
			this.textCustomerId.TabIndex = 7;
			// 
			// btnDetailCancel
			// 
			this.btnDetailCancel.Location = new System.Drawing.Point(298, 386);
			this.btnDetailCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDetailCancel.Name = "btnDetailCancel";
			this.btnDetailCancel.Size = new System.Drawing.Size(202, 56);
			this.btnDetailCancel.TabIndex = 6;
			this.btnDetailCancel.Text = "Cancel";
			this.btnDetailCancel.UseVisualStyleBackColor = true;
			// 
			// btnDetailSave
			// 
			this.btnDetailSave.Location = new System.Drawing.Point(55, 386);
			this.btnDetailSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDetailSave.Name = "btnDetailSave";
			this.btnDetailSave.Size = new System.Drawing.Size(200, 56);
			this.btnDetailSave.TabIndex = 5;
			this.btnDetailSave.Text = "Save";
			this.btnDetailSave.UseVisualStyleBackColor = true;
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(51, 251);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(98, 23);
			this.lblAddress.TabIndex = 4;
			this.lblAddress.Text = "Address:";
			// 
			// lblBirthday
			// 
			this.lblBirthday.AutoSize = true;
			this.lblBirthday.Location = new System.Drawing.Point(294, 138);
			this.lblBirthday.Name = "lblBirthday";
			this.lblBirthday.Size = new System.Drawing.Size(109, 23);
			this.lblBirthday.TabIndex = 3;
			this.lblBirthday.Text = "Birthday:";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(51, 138);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(65, 23);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "Name:";
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Location = new System.Drawing.Point(294, 44);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(87, 23);
			this.lblGender.TabIndex = 1;
			this.lblGender.Text = "Gender:";
			// 
			// lblCustomerID
			// 
			this.lblCustomerID.AutoSize = true;
			this.lblCustomerID.Location = new System.Drawing.Point(51, 44);
			this.lblCustomerID.Name = "lblCustomerID";
			this.lblCustomerID.Size = new System.Drawing.Size(142, 23);
			this.lblCustomerID.TabIndex = 0;
			this.lblCustomerID.Text = "Customer ID:";
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(970, 32);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(38, 37);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// CustomerView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1034, 658);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "CustomerView";
			this.Text = "CustomerView";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPageList.ResumeLayout(false);
			this.tabPageList.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.tabPageDetail.ResumeLayout(false);
			this.tabPageDetail.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblCustomers;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageList;
		private System.Windows.Forms.TabPage tabPageDetail;
		private System.Windows.Forms.Button btnListDelete;
		private System.Windows.Forms.Button btnListEdit;
		private System.Windows.Forms.Button btnListCreate;
		private System.Windows.Forms.Button btnListSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rbtnFemale;
		private System.Windows.Forms.RadioButton rbtnMale;
		private System.Windows.Forms.TextBox textCustomerName;
		private System.Windows.Forms.TextBox textCustomerAddress;
		private System.Windows.Forms.TextBox textCustomerId;
		private System.Windows.Forms.Button btnDetailCancel;
		private System.Windows.Forms.Button btnDetailSave;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblBirthday;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.Label lblCustomerID;
		private System.Windows.Forms.DateTimePicker dtpCustomerBirthday;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button btnClose;
	}
}