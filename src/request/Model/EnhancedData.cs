using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class EnhancedData 
	{ 
		public string PurchaseOrder {get; set;}
		public string TaxAmount {get; set;}
		public string TaxExempt {get; set;}
		public string DiscountAmount {get; set;}
		public string FreightAmount {get; set;}
		public string DutyAmount {get; set;}
		public string ShipFromPostalCode {get; set;}
		public string DestinationPostalCode {get; set;}
		public string DestinationCountryCode {get; set;}
		public string InvoiceReferenceNumber {get; set;}
		public string OrderDate {get; set;}
		public DetailTax DetailTax {get; set;}
		public DetailTax[] DetailTaxArray {get; set;}
		public LineItem LineItem {get; set;}
		public LineItem[] LineItemArray {get; set;}
		public string DeliveryType {get; set;}

		[JsonIgnore]
		public Dictionary<string, string> DeliveryTypeDict = new Dictionary<string, string> {
			{"CNC", "CNC"},
			{"DIG", "DIG"},
			{"PHY", "PHY"},
			{"SVC", "SVC"},
			{"TBD", "TBD"}
		};
	}
}