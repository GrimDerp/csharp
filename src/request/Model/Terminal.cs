using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class Terminal 
	{ 
		public string TerminalID {get; set;}
		public string Capability {get; set;}
		public string EntryMode {get; set;}
		public string CardholderID {get; set;}
		public string CapabilityOfCatTerminal {get; set;}

		[JsonIgnore]
		public Dictionary<string, string> CapabilityDict = new Dictionary<string, string> {
			{"NOT_USED", "notused"},
			{"MAG_STRIPE", "magstripe"},
			{"KEYED_ONLY", "keyedonly"}
		};
		[JsonIgnore]
		public Dictionary<string, string> EntryModeDict = new Dictionary<string, string> {
			{"NOT_USED", "notused"},
			{"KEYED", "keyed"},
			{"TRACK1", "track1"},
			{"TRACK2", "track2"},
			{"COMPLETE_READ", "completeread"}
		};
		[JsonIgnore]
		public Dictionary<string, string> CardholderIDDict = new Dictionary<string, string> {
			{"SIGNATURE", "signature"},
			{"PIN", "pin"},
			{"NO_PIN", "nopin"},
			{"DIRECT_MARKET", "directmarket"}
		};
		[JsonIgnore]
		public Dictionary<string, string> CapabilityOfCatTerminalDict = new Dictionary<string, string> {
			{"SELF_SERVICE", "self service"}
		};
	}
}