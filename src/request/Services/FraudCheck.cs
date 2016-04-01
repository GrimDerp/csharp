using request.Model;
using Newtonsoft.Json;

namespace request.Services
{
	public class FraudCheck : Request  
	{
		public Address Address {get; set;}
		public AdvancedFraudChecks AdvancedFraudChecks {get; set;}
		public Application Application {get; set;}
		public Credentials Credentials {get; set;}
		public Reports Reports {get; set;}
		public ScheduledTask ScheduledTask {get; set;}
		public Transaction Transaction {get; set;}

		public FraudCheck()
			: base("payment", "services", "fraudCheck", "POST")
		{
			
		}

		public override string toJSON()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
		}
	}
}