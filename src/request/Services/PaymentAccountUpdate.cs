using request.Model;
using Newtonsoft.Json;

namespace request.Services
{
	public class PaymentAccountUpdate : Request  
	{
		public Application Application {get; set;}
		public Card Card {get; set;}
		public Credentials Credentials {get; set;}
		public PaymentAccount PaymentAccount {get; set;}
		public Reports Reports {get; set;}
		public Transaction Transaction {get; set;}

		public PaymentAccountUpdate()
			: base("payment", "services", "paymentAccountUpdate", "POST")
		{
			
		}

		public override string toJSON()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
		}
	}
}