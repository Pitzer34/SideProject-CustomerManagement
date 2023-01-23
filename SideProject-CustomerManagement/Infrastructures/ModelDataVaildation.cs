using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SideProject_CustomerManagement.Infrastructures
{
	public class ModelDataVaildation
	{
		public void Vaildation(object model)
		{
			string errorMassage = "";
			List<ValidationResult> results = new List<ValidationResult>();
			ValidationContext context = new ValidationContext(model);
			bool isValid = Validator.TryValidateObject(model, context, results, true);

			if (isValid == false)
			{
				foreach(var item in results)
				{
					errorMassage += "- " + item.ErrorMessage + "\n";
				}

				throw new Exception(errorMassage);
			}
		}
	}
}
