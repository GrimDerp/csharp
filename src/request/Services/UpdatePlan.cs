using request.Model;
using Newtonsoft.Json;

namespace request.Services
{
	public class UpdatePlan : Request  
	{
		public Application Application {get; set;}
		public Credentials Credentials {get; set;}
		public Reports Reports {get; set;}
		public ScheduledTask ScheduledTask {get; set;}
		public Transaction Transaction {get; set;}

		public UpdatePlan()
			: base("payment", "services", "updatePlan", "POST")
		{
			
		}

		public override string toJSON()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
		}
	}
}