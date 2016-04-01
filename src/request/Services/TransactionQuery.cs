using request.Model;
using Newtonsoft.Json;

namespace request.Services
{
	public class TransactionQuery : Request  
	{
		public Application Application {get; set;}
		public Card Card {get; set;}
		public Credentials Credentials {get; set;}
		public Reports Reports {get; set;}
		public Transaction Transaction {get; set;}

		public TransactionQuery()
			: base("payment", "services", "transactionQuery", "POST")
		{
			
		}

		public override string toJSON()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
		}
	}
}