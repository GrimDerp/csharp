using request.Model;
using Newtonsoft.Json;

namespace request.Check
{
	public class Redeposit : Request  
	{
		public Application Application {get; set;}
		public Credentials Credentials {get; set;}
		public DemandDepositAccount DemandDepositAccount {get; set;}
		public PaymentAccount PaymentAccount {get; set;}
		public Reports Reports {get; set;}
		public Transaction Transaction {get; set;}

		public Redeposit()
			: base("payment", "check", "redeposit", "POST")
		{
			
		}

		public override string toJSON()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
		}
	}
}