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
		[Required(ErrorMessage = "客戶姓名必填")]
		public string Name { get; set; }

		[Display(Name ="性別")]
		[Required(ErrorMessage = "性別必填")]
		public bool Gender { get; set; }

		[Display(Name ="出生日期")]
		[Required(ErrorMessage = "出生日期必填")]		
		public DateTime Birthday { get; set; }

		[Display(Name ="通訊地址")]
		[Required(ErrorMessage = "地址必填")]
		public string Address { get; set; }
	}
}
