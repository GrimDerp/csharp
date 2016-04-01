using request.Model;
using Newtonsoft.Json;

namespace request.Credit
{
	public class Void : Request  
	{
		public Application Application {get; set;}
		public Credentials Credentials {get; set;}
		public Reports Reports {get; set;}
		public Transaction Transaction {get; set;}

		public Void()
			: base("payment", "credit", "void", "POST")
		{
			
		}

		public override string toJSON()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
		}
	}
}