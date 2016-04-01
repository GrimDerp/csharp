using Newtonsoft.Json;
using System.Collections.Generic;

namespace request.Model
{
	public class ScheduledTask 
	{ 
		public string ScheduledTaskID {get; set;}
		public string RunCycles {get; set;}
		public string RunStartDate {get; set;}
		public string Amount {get; set;}
		public CreateDiscount CreateDiscount {get; set;}
		public CreateDiscount[] CreateDiscountArray {get; set;}
		public CreateAddOn CreateAddOn {get; set;}
		public CreateAddOn[] CreateAddOnArray {get; set;}
		public string SubscriptionID {get; set;}
		public string Name {get; set;}
		public string Description {get; set;}
		public string RunFrequency {get; set;}
		public string TrialRunCycles {get; set;}
		public string TrialRunFrequency {get; set;}
		public string Active {get; set;}
		public string BillingDate {get; set;}
		public UpdateDiscount UpdateDiscount {get; set;}
		public UpdateDiscount[] UpdateDiscountArray {get; set;}
		public DeleteDiscount DeleteDiscount {get; set;}
		public DeleteDiscount[] DeleteDiscountArray {get; set;}
		public UpdateAddOn UpdateAddOn {get; set;}
		public UpdateAddOn[] UpdateAddOnArray {get; set;}
		public DeleteAddOn DeleteAddOn {get; set;}
		public DeleteAddOn[] DeleteAddOnArray {get; set;}
	}
}