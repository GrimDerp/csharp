using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class FraudResult 
	{ 
		public string AvsResult {get; set;}
		public string CardValidationResult {get; set;}
		public string AuthenticationResult {get; set;}
		public string AdvancedAVSResult {get; set;}
		public AdvancedFraudResults AdvancedFraudResults {get; set;}
	}
}