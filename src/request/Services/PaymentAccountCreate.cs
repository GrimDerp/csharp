using request.Model;
using Newtonsoft.Json;

namespace request.Services
{
	public class PaymentAccountCreate : Request  
	{
		public Applepay Applepay {get; set;}
		public Application Application {get; set;}
		public Card Card {get; set;}
		public Credentials Credentials {get; set;}
		public DemandDepositAccount DemandDepositAccount {get; set;}
		public Reports Reports {get; set;}
		public Transaction Transaction {get; set;}

		public PaymentAccountCreate()
			: base("payment", "services", "paymentAccountCreate", "POST")
		{
			
		}

		public override string toJSON()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
		}
	}
}