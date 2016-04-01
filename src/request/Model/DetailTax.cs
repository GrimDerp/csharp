using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class DetailTax 
	{ 
		public string TaxIncludedInTotal {get; set;}
		public string TaxAmount {get; set;}
		public string TaxRate {get; set;}
		public string AlternateTaxIdentifier {get; set;}
		public string TaxTypeIdentifier {get; set;}

		[JsonIgnore]
		public Dictionary<string, string> TaxTypeIdentifierDict = new Dictionary<string, string> {
			{"UNKOWN", "00"},
			{"NATL_SALES", "01"},
			{"ST_SALES", "02"},
			{"CTY_SALES", "03"},
			{"LCL_SALES", "04"},
			{"MUN_SALES", "05"},
			{"OTHER", "06"},
			{"VAT", "10"},
			{"GST", "11"},
			{"PST", "12"},
			{"HST", "13"},
			{"QST", "14"},
			{"ROOM", "20"},
			{"OCCUPANCY", "21"},
			{"ENERGY", "22"}
		};
	}
}