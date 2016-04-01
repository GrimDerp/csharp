using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class Transaction 
	{ 
		public string CustomerID {get; set;}
		public string PartialCapture {get; set;}
		public string ReferenceNumber {get; set;}
		public string AuthorizationDate {get; set;}
		public string ApprovalNumber {get; set;}
		public string TransactionAmount {get; set;}
		public string TransactionID {get; set;}
		public string ConvenienceFeeAmount {get; set;}
		public string PartialApprovedFlag {get; set;}
		public string FraudFilterOverride {get; set;}
		public string SurchargeFee {get; set;}
		public string ActionReason {get; set;}
		public string Verify {get; set;}
		public string TransactionType {get; set;}
		public string OrderSource {get; set;}
		public string TaxType {get; set;}

		[JsonIgnore]
		public Dictionary<string, string> OrderSourceDict = new Dictionary<string, string> {
			{"ECOMMERCE", "ecommerce"},
			{"INSTALLMENT", "installment"},
			{"MAIL_ORDER", "mailorder"},
			{"RECURRING", "recurring"},
			{"RETAIL", "retail"},
			{"TELEPHONE", "telephone"},
			{"AUTH_3DS", "3dsAuthenticated"},
			{"ATTEMPTED_3DS", "3dsAttempted"},
			{"RECURRING_TEL", "recurringtel"},
			{"ECHECK_PPD", "echeckppd"},
			{"APPLEPAY", "applepay"}
		};
		[JsonIgnore]
		public Dictionary<string, string> TaxTypeDict = new Dictionary<string, string> {
			{"PAYMENT", "payment"},
			{"FEE", "fee"}
		};
	}
}