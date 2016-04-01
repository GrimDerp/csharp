using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class Header 
	{ 
		public string ApplicationData {get; set;}
		public string EphemeralPublicKey {get; set;}
		public string PublicKeyHash {get; set;}
		public string TransactionID {get; set;}
	}
}