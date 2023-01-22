using SideProject_CustomerManagement.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SideProject_CustomerManagement.Models;
using SideProject_CustomerManagement.Persenters;
using SideProject_CustomerManagement.Interface;
using SideProject_CustomerManagement.Infrastructures.Repositories;
using System.Configuration;

namespace SideProject_CustomerManagement
{
	internal static class Program
	{
		/// <summary>
		/// 應用程式的主要進入點。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
			IMainView view = new MainView();	
			new MainPersenter(view, sqlConnectionString);			
			Application.Run((Form)view);
		}
	}
}
