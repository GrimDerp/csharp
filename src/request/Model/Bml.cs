using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class Bml 
	{ 
		public string MerchantID {get; set;}
		public string ProductType {get; set;}
		public string TermsAndConditions {get; set;}
		public string PreApprovalNumber {get; set;}
		public string VirtualAuthenticationKeyPresenceIndicator {get; set;}
		public string VirtualAuthenticationKeyData {get; set;}
		public string ItemCategoryCode {get; set;}
	}
}