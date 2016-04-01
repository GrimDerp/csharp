using request.Model;
using Newtonsoft.Json;

namespace request.Credit
{
	public class CaptureGivenAuth : Request  
	{
		public Address Address {get; set;}
		public Application Application {get; set;}
		public Bml Bml {get; set;}
		public Card Card {get; set;}
		public Credentials Credentials {get; set;}
		public CustomBilling CustomBilling {get; set;}
		public EnhancedData EnhancedData {get; set;}
		public FraudResult FraudResult {get; set;}
		public PaymentAccount PaymentAccount {get; set;}
		public Reports Reports {get; set;}
		public Terminal Terminal {get; set;}
		public Transaction Transaction {get; set;}
		public Visa Visa {get; set;}

		public CaptureGivenAuth()
			: base("payment", "credit", "captureGivenAuth", "POST")
		{
			
		}

		public override string toJSON()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
		}
	}
}