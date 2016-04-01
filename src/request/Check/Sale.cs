using request.Model;
using Newtonsoft.Json;

namespace request.Check
{
	public class Sale : Request  
	{
		public Address Address {get; set;}
		public Application Application {get; set;}
		public Credentials Credentials {get; set;}
		public CustomBilling CustomBilling {get; set;}
		public DemandDepositAccount DemandDepositAccount {get; set;}
		public PaymentAccount PaymentAccount {get; set;}
		public Reports Reports {get; set;}
		public Transaction Transaction {get; set;}

		public Sale()
			: base("payment", "check", "sale", "POST")
		{
			
		}

		public override string toJSON()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
		}
	}
}