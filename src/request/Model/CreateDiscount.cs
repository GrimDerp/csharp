using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class CreateDiscount 
	{ 
		public string DiscountCode {get; set;}
		public string Name {get; set;}
		public string Amount {get; set;}
		public string StartDate {get; set;}
		public string EndDate {get; set;}
	}
}