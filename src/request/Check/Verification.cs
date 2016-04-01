using request.Model;
using Newtonsoft.Json;

namespace request.Check
{
	public class Verification : Request  
	{
		public Address Address {get; set;}
		public Application Application {get; set;}
		public Credentials Credentials {get; set;}
		public DemandDepositAccount DemandDepositAccount {get; set;}
		public PaymentAccount PaymentAccount {get; set;}
		public Reports Reports {get; set;}
		public Transaction Transaction {get; set;}

		public Verification()
			: base("payment", "check", "verification", "POST")
		{
			
		}

		public override string toJSON()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
		}
	}
}