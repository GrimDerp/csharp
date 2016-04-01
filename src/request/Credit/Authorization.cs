using request.Model;
using Newtonsoft.Json;

namespace request.Credit
{
	public class Authorization : Request  
	{
		public Address Address {get; set;}
		public AdvancedFraudChecks AdvancedFraudChecks {get; set;}
		public Applepay Applepay {get; set;}
		public Application Application {get; set;}
		public Bml Bml {get; set;}
		public Card Card {get; set;}
		public CardholderAuthentication CardholderAuthentication {get; set;}
		public Credentials Credentials {get; set;}
		public CustomBilling CustomBilling {get; set;}
		public EnhancedData EnhancedData {get; set;}
		public Identification Identification {get; set;}
		public PayPal PayPal {get; set;}
		public PaymentAccount PaymentAccount {get; set;}
		public RecyclingRequest RecyclingRequest {get; set;}
		public Reports Reports {get; set;}
		public ScheduledTask ScheduledTask {get; set;}
		public Terminal Terminal {get; set;}
		public Transaction Transaction {get; set;}
		public Visa Visa {get; set;}
		public Wallet Wallet {get; set;}

		public Authorization()
			: base("payment", "credit", "authorization", "POST")
		{
			
		}

		public override string toJSON()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
		}
	}
}