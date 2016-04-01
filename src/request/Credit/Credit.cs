using request.Model;
using Newtonsoft.Json;

namespace request.Credit
{
	public class Credit : Request  
	{
		public Application Application {get; set;}
		public Credentials Credentials {get; set;}
		public CustomBilling CustomBilling {get; set;}
		public EnhancedData EnhancedData {get; set;}
		public PayPal PayPal {get; set;}
		public Reports Reports {get; set;}
		public Terminal Terminal {get; set;}
		public Transaction Transaction {get; set;}

		public Credit()
			: base("payment", "credit", "credit", "POST")
		{
			
		}

		public override string toJSON()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
		}
	}
}