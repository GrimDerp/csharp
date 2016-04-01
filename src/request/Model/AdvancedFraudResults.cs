using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class AdvancedFraudResults 
	{ 
		public string DeviceReviewStatus {get; set;}
		public string DeviceReputationScore {get; set;}
		public string TriggeredRule {get; set;}
	}
}