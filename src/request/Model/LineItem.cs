using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class LineItem 
	{ 
		public string ItemSequenceNumber {get; set;}
		public string ItemDescription {get; set;}
		public string ProductCode {get; set;}
		public string LineItemCount {get; set;}
		public string UnitOfMeasure {get; set;}
		public string TaxAmount {get; set;}
		public string LineItemTotalAmount {get; set;}
		public string LineItemTotalWithTax {get; set;}
		public string LineItemDiscountAmount {get; set;}
		public string ItemCommodityCode {get; set;}
		public string UnitCost {get; set;}
		public DetailTax DetailTax {get; set;}
		public DetailTax[] DetailTaxArray {get; set;}
	}
}