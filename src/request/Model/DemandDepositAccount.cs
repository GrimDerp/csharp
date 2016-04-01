using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class DemandDepositAccount 
	{ 
		public string DDAAccountType {get; set;}
		public string AccountNumber {get; set;}
		public string RoutingNumber {get; set;}
		public string CheckNumber {get; set;}
		public string CCDPaymentInformation {get; set;}
	}
}