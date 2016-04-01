using request.Model;
using Newtonsoft.Json;

namespace request.Credit
{
	public class Force : Request  
	{
		public Address Address {get; set;}
		public Application Application {get; set;}
		public Card Card {get; set;}
		public Credentials Credentials {get; set;}
		public CustomBilling CustomBilling {get; set;}
		public EnhancedData EnhancedData {get; set;}
		public PaymentAccount PaymentAccount {get; set;}
		public Reports Reports {get; set;}
		public Terminal Terminal {get; set;}
		public Transaction Transaction {get; set;}
		public Visa Visa {get; set;}

		public Force()
			: base("payment", "credit", "force", "POST")
		{
			
		}

		public override string toJSON()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
		}
	}
}