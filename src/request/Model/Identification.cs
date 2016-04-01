using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class Identification 
	{ 
		public string Ssn {get; set;}
		public string BirthDate {get; set;}
		public string CustomerRegistrationDate {get; set;}
		public string IncomeAmount {get; set;}
		public string CustomerCheckingAccount {get; set;}
		public string CustomerSavingsAccount {get; set;}
		public string EmployerName {get; set;}
		public string CustomerWorkTelephone {get; set;}
		public string YearsAtResidence {get; set;}
		public string YearsAtEmployer {get; set;}
		public string CustomerType {get; set;}
		public string IncomeCurrency {get; set;}
		public string ResidenceStatus {get; set;}

		[JsonIgnore]
		public Dictionary<string, string> CustomerTypeDict = new Dictionary<string, string> {
			{"NEW", "New"},
			{"EXISTING", "Existing"}
		};
		[JsonIgnore]
		public Dictionary<string, string> IncomeCurrencyDict = new Dictionary<string, string> {
			{"AUD", "AUD"},
			{"CAD", "CAD"},
			{"CHF", "CHF"},
			{"DKK", "DKK"},
			{"EUR", "EUR"},
			{"GBP", "GBP"},
			{"HKD", "HKD"},
			{"JPY", "JPY"},
			{"NOK", "NOK"},
			{"NZD", "NZD"},
			{"SEK", "SEK"},
			{"SGD", "SGD"},
			{"USD", "USD"}
		};
		[JsonIgnore]
		public Dictionary<string, string> ResidenceStatusDict = new Dictionary<string, string> {
			{"OWN", "Own"},
			{"RENT", "Rent"},
			{"OTHER", "Other"}
		};
	}
}