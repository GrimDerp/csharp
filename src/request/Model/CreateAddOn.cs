using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class CreateAddOn 
	{ 
		public string AddOnCode {get; set;}
		public string Name {get; set;}
		public string Amount {get; set;}
		public string StartDate {get; set;}
		public string EndDate {get; set;}
	}
}