using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class RecyclingRequest 
	{ 
		public string RecycleID {get; set;}
		public string RecycleBy {get; set;}

		[JsonIgnore]
		public Dictionary<string, string> RecycleByDict = new Dictionary<string, string> {
			{"MERCHANT", "Merchant"},
			{"LITLE", "Litle"},
			{"NONE", "None"}
		};
	}
}