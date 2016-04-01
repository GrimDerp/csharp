using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class Applepay 
	{ 
		public string Data {get; set;}
		public Header Header {get; set;}
		public string Signature {get; set;}
		public string Version {get; set;}
	}
}