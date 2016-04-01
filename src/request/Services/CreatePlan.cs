using request.Model;
using Newtonsoft.Json;

namespace request.Services
{
	public class CreatePlan : Request  
	{
		public Application Application {get; set;}
		public Credentials Credentials {get; set;}
		public Reports Reports {get; set;}
		public ScheduledTask ScheduledTask {get; set;}
		public Transaction Transaction {get; set;}

		public CreatePlan()
			: base("payment", "services", "createPlan", "POST")
		{
			
		}

		public override string toJSON()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
		}
	}
}