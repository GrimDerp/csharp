using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class Card 
	{ 
		public string CardNumber {get; set;}
		public string ExpirationMonth {get; set;}
		public string ExpirationYear {get; set;}
		public string CVV {get; set;}
		public string Track1Data {get; set;}
		public string Track2Data {get; set;}
		public string PaypageRegistrationID {get; set;}
		public string AccountNumber {get; set;}
		public string Type {get; set;}

		[JsonIgnore]
		public Dictionary<string, string> TypeDict = new Dictionary<string, string> {
			{"MC", "MC"},
			{"VI", "VI"},
			{"AX", "AX"},
			{"DC", "DC"},
			{"DI", "DI"},
			{"PP", "PP"},
			{"JC", "JC"},
			{"BL", "BL"},
			{"EC", "EC"},
			{"GC", "GC"},
			{"NONE", ""}
		};
	}
}