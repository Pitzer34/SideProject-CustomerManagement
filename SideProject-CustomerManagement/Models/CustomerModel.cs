using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SideProject_CustomerManagement.Models
{
	public class CustomerModel
	{
		//Properties - Validations
		[Display(Name ="客戶編號")]
		public int Id { get; set; }

		[Display(Name ="客戶姓名")]
		[Required]
		public string Name { get; set; }

		[Display(Name ="性別")]
		[Required]
		public bool Gender { get; set; }

		[Display(Name ="出生日期")]
		[Required]		
		public DateTime Birthday { get; set; }

		[Display(Name ="通訊地址")]
		[Required]
		public string Address { get; set; }
	}
}
