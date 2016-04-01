using request.Model;
using Newtonsoft.Json;

namespace request.Services
{
	public class ScheduledTaskUpdate : Request  
	{
		public Address Address {get; set;}
		public Application Application {get; set;}
		public Card Card {get; set;}
		public Credentials Credentials {get; set;}
		public PaymentAccount PaymentAccount {get; set;}
		public Reports Reports {get; set;}
		public ScheduledTask ScheduledTask {get; set;}
		public Transaction Transaction {get; set;}

		public ScheduledTaskUpdate()
			: base("payment", "services", "scheduledTaskUpdate", "POST")
		{
			
		}

		public override string toJSON()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
		}
	}
}