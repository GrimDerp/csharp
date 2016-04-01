using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class FraudCheck 
	{ 
		public string AuthenticationValue {get; set;}
		public string AuthenticationTransactionID {get; set;}
		public string CustomerIpAddress {get; set;}
		public string AuthenticatedByMerchant {get; set;}
	}
}