using request.Model;
using Newtonsoft.Json;

namespace request.Credit
{
	public class Reversal : Request  
	{
		public Application Application {get; set;}
		public Credentials Credentials {get; set;}
		public PayPal PayPal {get; set;}
		public Reports Reports {get; set;}
		public Transaction Transaction {get; set;}

		public Reversal()
			: base("payment", "credit", "reversal", "POST")
		{
			
		}

		public override string toJSON()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
		}
	}
}