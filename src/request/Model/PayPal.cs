using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class PayPal 
	{ 
		public string PayerID {get; set;}
		public string Token {get; set;}
		public string TransactionID {get; set;}
		public string PayPalOrderComplete {get; set;}
		public string PayPalNotes {get; set;}
	}
}